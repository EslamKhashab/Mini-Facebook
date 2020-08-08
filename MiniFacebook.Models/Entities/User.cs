using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace MiniFacebook.Models.Entities
{
    public class User 
    {
        public User()
        {
            Posts = new HashSet<Post>();
            UserFriends = new HashSet<UserFriend>();
            UserFriends1 = new HashSet<UserFriend>();


        }
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<UserFriend> UserFriends { get; set; }
        public ICollection<UserFriend> UserFriends1 { get; set; }



    }
}
