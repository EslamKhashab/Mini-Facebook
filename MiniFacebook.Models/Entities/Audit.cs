using System;

namespace MiniFacebook.Models.Entities
{
    public class Audit
    {
        public Audit()
        {
            IsArchive = false;
            ModifiedDate = DateTime.UtcNow;
        }
        public bool IsArchive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
