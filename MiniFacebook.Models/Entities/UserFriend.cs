using System;
using System.Collections.Generic;
using System.Text;

namespace MiniFacebook.Models.Entities
{
    public class UserFriend 
    {
        public Guid UserId { get; set; }
        public Guid FriendId { get; set; }
        public bool IsAccept { get; set; }
        public User User { get; set; }
        public User Friend { get; set; }
    }
}
