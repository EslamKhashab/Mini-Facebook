using System.Collections;
using System.Collections.Generic;

namespace MiniFacebook.Models.Entities
{
    public class PostPrivacy
    {
        public PostPrivacy()
        {
            Posts = new HashSet<Post>();
        }
        public int Id { get; set; }
        public string PrivacyType { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
