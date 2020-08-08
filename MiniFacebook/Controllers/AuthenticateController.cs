using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MiniFacebook.Shared.GlobalReturnsController;
using MiniFacebook.Orchestrator.Services.AuthenticateService;
using MiniFacebook.ViewModel.Auth;
using MiniFacebook.Shared.GlobalResponse;
using System;

namespace MiniFacebook.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json", "application/xml")]
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "MiniFacebookSpecification")]
    public class AuthenticateController : BaseController
    {

        private readonly IAuthenticateService _authenticateService;

        /// <summary>  
        /// </summary>  
        public AuthenticateController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("Login")]
        [ProducesResponseType(typeof(TokenDto), 200)]
        public async Task<IActionResult> Login([FromBody] LoginDto data)
        {
            var result = (GlobalResponse)await _authenticateService.Login(data);

            if (result.Success == true)
            {
                return Ok(result);
            }
            return Ok(result);
        }

        /// <summary>
        /// Register A new user
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("Register")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<IActionResult> Register([FromBody] RegisterDto data)
        {
            return Ok(await _authenticateService.Register(data));
        }

        /// <summary>
        /// Forget Password
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("ForgetPassword")]
        public async Task<IActionResult> ForgetPassword([FromBody] ForgetPasswordDto data)
        {
            return Success(await _authenticateService.ForgetPassword(data));
        }

        /// <summary>
        /// Reset Password
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] RestPasswordDto data)
        {
            return Success(await _authenticateService.RestPassword(data));
        }

        /// <summary>
        /// Confirm Phone
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="Token"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("ConfirmPhone")]
        [ProducesResponseType(typeof(TokenDto), 200)]
        public async Task<IActionResult> ConfirmPhone(string UserId,string Token)
        {
            return Success(await _authenticateService.ConfirmPhone(UserId,Token));
        }


    }
}