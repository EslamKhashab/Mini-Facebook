using MiniFacebook.Shared.Helper;
using MiniFacebook.ViewModel;
using System;
using System.Threading.Tasks;

namespace MiniFacebook.Orchestrator.Services.PostService
{
    public interface IPostService
    {
        Task<object> AddPost(AddPostDto Payload);
        Task<object> ListMyFriendPosts(Guid UserId, PaginationObject paginationObject);
        Task<object> DeletePost(Guid Id);
        Task<object> ListMyWall(PaginationObject paginationObject);
    }
}
