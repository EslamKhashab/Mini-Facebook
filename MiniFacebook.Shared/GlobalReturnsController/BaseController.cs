using Microsoft.AspNetCore.Mvc;

namespace MiniFacebook.Shared.GlobalReturnsController
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected OkObjectResult Success()
        {
            var result = new GlobalResponse.GlobalResponse().SuccessResult();
            //var result = new GlobalResponse().SuccessResult();
            return new OkObjectResult(result);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="successMessage"></param>
        /// <returns></returns>
        protected OkObjectResult Success(object data, string successMessage = null)
        {

            var result = new GlobalResponse.GlobalResponse().SuccessResult(data, successMessage);
            return new OkObjectResult(result);
        }
     

    }
}