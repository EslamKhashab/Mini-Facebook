using System;
using System.Threading.Tasks;

namespace MiniFacebook.Orchestrator.Services.FriendService
{
    public interface IFriendService
    {
        Task<object> SendFriendRequset(Guid Id);
        Task<object> AcceptFriendRequset(Guid Id);
        Task<object> RejectFriendRequset(Guid Id);
    }
}
