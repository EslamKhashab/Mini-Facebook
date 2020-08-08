namespace MiniFacebook.Shared.GlobalException.ExceptionTypes
{
    public class GlobalException : GlobalExepectionType
    {
        public Errors Error { get; }


        public GlobalException(Errors error)
        {
            Error = error;
        }

        public GlobalException(string errorId)
        {
            this.ErrorId = errorId;
            ExepectionType = "GlobalException";

        }

        public enum Errors
        {
            GlobalError
        }
    }
}
