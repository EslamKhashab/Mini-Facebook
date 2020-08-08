using System;

namespace MiniFacebook.Shared.GlobalException.ExceptionTypes
{
    public class GlobalExepectionType : Exception
    {
        public string ErrorId { get; set; }
        public string ExepectionType { get; set; }

    }
}
