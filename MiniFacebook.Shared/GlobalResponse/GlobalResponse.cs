using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MiniFacebook.Shared.GlobalResponse
{
    public class GlobalResponse : ActionResult, IActionResult
    {
        public GlobalResponse()
        {
            Success = false;
        }

        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
        public bool? Success { get; set; }
        public string ErrorCode { get; set; }
        public object Data { get; set; }
        public bool IsActive { get; set; } = true;

        public GlobalResponse SuccessResult()
        {
            var result = new GlobalResponse { Success = true, Data = new object() };
            return result;
        }

        public GlobalResponse SuccessResult(object data, string successMessage)
        {
            var result = new GlobalResponse { Success = true, Data = data, SuccessMessage = successMessage };
            return result;
        }

        public GlobalResponse ErrorResult(string errorMessage, string errorCode)
        {
            var result = new GlobalResponse { Success = false, Data = new object(), ErrorCode = errorCode, ErrorMessage = errorMessage };
            return result;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
