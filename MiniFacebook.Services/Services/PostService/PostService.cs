using AutoMapper;
using Microsoft.Extensions.Localization;
using MiniFacebook.DAL.Repository.PostRepository;
using MiniFacebook.DAL.Repository.UserFriendRepository;
using MiniFacebook.Models.Entities;
using MiniFacebook.Shared.GlobalResponse;
using MiniFacebook.Shared.GlobalUOW;
using MiniFacebook.Shared.Helper;
using MiniFacebook.Shared.Helper.AppsettingHelper;
using MiniFacebook.Shared.Localization;
using MiniFacebook.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFacebook.Orchestrator.Services.PostService
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postrepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer _localizer;
        private readonly IUserFriendRepository _friendRepository;
        private readonly IAppSettingConfiguration _appSettingConfiguration;



        public PostService(IPostRepository postrepository, IUnitOfWork unitOfWork, IMapper mapper, IUploadClass uploadClass, IUserFriendRepository friendRepository,
                           IAppSettingConfiguration appSettingConfiguration, IStringLocalizer localizer)
        {
            _postrepository = postrepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _localizer = localizer;
            _friendRepository = friendRepository;
            _appSettingConfiguration = appSettingConfiguration;
        }
        public async Task<object> AddPost(AddPostDto Payload)
        {
            if (Payload != null)
            {
                var Post = _mapper.Map<Post>(Payload);
                Post.UserId = MethodsHelper.GetCurrentUserId();
                Post.PostPrivacyId = 2;
                Post.CreatedDate = DateTime.UtcNow;
                await _postrepository.AddAsync(Post);
                await _unitOfWork.CompleteAsync();
                return new GlobalResponse { Data = true, SuccessMessage = _localizer[LocalizationKeys.PostAdd] };
            }
            return new GlobalResponse { Data = false, ErrorMessage = _localizer[LocalizationKeys.Error] };
        }

        public async Task<object> ListMyWall(PaginationObject paginationObject)
        {
            var Posts = _postrepository.GetAll(x => x.IsArchive == false &&
                                               x.UserId == MethodsHelper.GetCurrentUserId())
                                       .AsQueryable()
                                       .ApplyOrdering(SortType.Descending, x => x.CreatedDate);

            var Result = _mapper.Map<IEnumerable<PostDto>>(Posts).AsQueryable();
            foreach (var item in Result)
            {
                item.ImageUrl = _appSettingConfiguration.GetAppsettingValueById() + item.ImageUrl;
            }
            return PagedList.Create(Result, paginationObject);
        }
        private async Task<bool> AreFriend(Guid UserId)
        {
            var Query = await _friendRepository.GetAsync(x => x.IsAccept == true
                                                   && (x.FriendId == UserId
                                                   && x.UserId == MethodsHelper.GetCurrentUserId())
                                                   || (x.UserId == UserId
                                                   && x.FriendId == MethodsHelper.GetCurrentUserId()));
            if (Query != null)
            {
                return true;
            }
            return false;

        }
        public async Task<object> ListMyFriendPosts(Guid UserId, PaginationObject paginationObject)
        {
            if (!await AreFriend(UserId))
            {
                return new GlobalResponse { Data = false, ErrorMessage = _localizer[LocalizationKeys.AreFriends] };
            }
            var Posts = _postrepository.GetAll(x => x.IsArchive == false && x.UserId == UserId).AsQueryable()
                                       .ApplyOrdering(SortType.Descending, x => x.CreatedDate);

            var Result = _mapper.Map<IEnumerable<PostDto>>(Posts).AsQueryable();

            foreach (var item in Result)
            {
                item.ImageUrl = _appSettingConfiguration.GetAppsettingValueById() + item.ImageUrl;
            }

            return new GlobalResponse { Data = PagedList.Create(Result, paginationObject) };
        }
        public async Task<object> DeletePost(Guid Id)
        {
            var Post = await _postrepository.GetAsync(x => x.Id == Id && x.UserId == MethodsHelper.GetCurrentUserId());

            if (Post != null)
            {
                await _postrepository.RemoveAsync(Post);
                await _unitOfWork.CompleteAsync();
                return new GlobalResponse { Data = true, SuccessMessage = _localizer[LocalizationKeys.PostDelete], Success = true };
            }
            return new GlobalResponse { Data = true, ErrorMessage = _localizer[LocalizationKeys.Error], Success = false };
        }
    }
}
