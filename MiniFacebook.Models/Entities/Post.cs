using System;

namespace MiniFacebook.Models.Entities
{
    public class Post : Audit
    {
        public Guid Id { get; set; }
        public string ImageUrl { get; set; }
        public string Text { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public int PostPrivacyId { get; set; }
        public PostPrivacy PostPrivacy { get; set; }

    }
}
