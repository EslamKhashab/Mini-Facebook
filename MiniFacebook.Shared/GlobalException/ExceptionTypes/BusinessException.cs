namespace MiniFacebook.Shared.GlobalException.ExceptionTypes
{
    public class BusinessException : GlobalExepectionType
    {
        public Errors Error { get; }

       

        public BusinessException(Errors error)
        {
            Error = error;
        }

        public BusinessException(string errorId)
        {
            this.ErrorId = errorId;
            ExepectionType = "BusinessException";
        }

        public enum Errors
        {
            ListCouldNotBeNull, GlobalBusiness
        }
    }
}
