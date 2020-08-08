using Newtonsoft.Json;

namespace MiniFacebook.Shared.GlobalException
{
    public class ErrorDetails
    {
        public ErrorDetails()
        {
            Success = false;
            Data = null;
        }

        public string ErrorMessage { get; set; }
        public bool? Success { get; set; }
        public string ErrorCode { get; set; }
        public object Data { get; set; }
        public bool? IsActive { get; set; } = false;

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
