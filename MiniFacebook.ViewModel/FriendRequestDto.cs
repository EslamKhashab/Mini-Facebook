using MiniFacebook.Shared.Helper;
using System;

namespace MiniFacebook.ViewModel
{
    public class FriendRequestDto
    {
        public Guid UserId { get; set; } = MethodsHelper.GetCurrentUserId();
        public Guid RequesterId { get; set; }
    }
}
