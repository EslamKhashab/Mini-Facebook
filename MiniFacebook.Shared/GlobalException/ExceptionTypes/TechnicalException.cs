namespace MiniFacebook.Shared.GlobalException.ExceptionTypes
{
    public class TechnicalException : GlobalExepectionType
    {
        public Errors Error { get; }


        public TechnicalException(Errors error)
        {
            Error = error;
        }

        public TechnicalException(string errorId)
        {
            ErrorId = errorId;
            ExepectionType = "TechnicalException";

        }

        public enum Errors
        {
            ConnectionHasAnIssue
        }
    }
}
