using AutoMapper;
using Microsoft.Extensions.Localization;
using MiniFacebook.DAL.Repository.UserFriendRepository;
using MiniFacebook.DAL.Repository.UserRepository;
using MiniFacebook.Models.Entities;
using MiniFacebook.Shared.GlobalResponse;
using MiniFacebook.Shared.GlobalUOW;
using MiniFacebook.Shared.Helper;
using MiniFacebook.Shared.Localization;
using MiniFacebook.ViewModel;
using System;
using System.Threading.Tasks;

namespace MiniFacebook.Orchestrator.Services.FriendService
{
    public class FriendService : IFriendService
    {
        private readonly IUserFriendRepository _friendRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer _localizer;

        public FriendService(IUserFriendRepository friendRepository, IMapper mapper, IUnitOfWork unitOfWork, IUserRepository userRepository, IStringLocalizer localizer)
        {
            _friendRepository = friendRepository;
            _unitOfWork = unitOfWork;
            _userRepository = userRepository;
            _mapper = mapper;
            _localizer = localizer;
        }
        public async Task<object> SendFriendRequset(Guid Id)
        {
            var User = await _userRepository.GetAsync(x => x.Id == Id);
            if (User != null)
            {
                var FriendRequset = new FriendRequestDto();
                FriendRequset.RequesterId = Id;
                await _friendRepository.AddAsync(_mapper.Map<UserFriend>(FriendRequset));
                await _unitOfWork.CompleteAsync();
                return new GlobalResponse { Data = true, Success = true };

            }
            return new GlobalResponse { Data = false, Success = false };
        }
        public async Task<object> AcceptFriendRequset(Guid Id)
        {
            var FriendRequset = await _friendRepository.GetAsync(x => x.UserId == Id && x.FriendId == MethodsHelper.GetCurrentUserId());
            if (FriendRequset != null)
            {
                FriendRequset.IsAccept = true;
                await _friendRepository.UpdateAsync(FriendRequset);
                await _unitOfWork.CompleteAsync();
                return new GlobalResponse { Data = true, SuccessMessage = _localizer[LocalizationKeys.FriendAdd], Success = true };
            }
            return new GlobalResponse { Data = false, ErrorMessage = _localizer[LocalizationKeys.Error], Success = false };
        }
        public async Task<object> RejectFriendRequset(Guid Id)
        {
            var FriendRequset = await _friendRepository.GetAsync(x => x.UserId == Id && x.FriendId == MethodsHelper.GetCurrentUserId());
            if (FriendRequset != null)
            {
                await _friendRepository.RemoveAsync(FriendRequset);
                await _unitOfWork.CompleteAsync();
                return true;
            }
            return false;
        }
    }
}
