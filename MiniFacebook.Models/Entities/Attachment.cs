using System;
using System.Collections.Generic;
using System.Text;

namespace MiniFacebook.Models.Entities
{
    public class Attachment : Audit
    {
        public Guid Id { get; set; }
        public string MyProperty { get; set; }
    }
}
