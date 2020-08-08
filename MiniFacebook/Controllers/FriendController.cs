using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniFacebook.Orchestrator.Services.FriendService;
using MiniFacebook.Shared.GlobalResponse;
using MiniFacebook.Shared.GlobalReturnsController;

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
    public class FriendController : BaseController
    {
        private readonly IFriendService _friendService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="friendService"></param>
        public FriendController(IFriendService friendService)
        {
            _friendService = friendService;
        }

        /// <summary>
        /// Send Friend Request
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>     
        [Authorize]
        [HttpPost("FriendRequset")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<IActionResult> SendFrinedRequset(Guid Id)
        {
            return Ok(await _friendService.SendFriendRequset(Id));
        }

        /// <summary>
        /// Accept Friend Request
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>      
        [Authorize]
        [HttpPost("AcceptFriendRequest")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<IActionResult> AcceptFriendRequest(Guid Id)
        {
            return Success(await _friendService.AcceptFriendRequset(Id));
        }

        /// <summary>
        /// Reject Friend Request
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost("RejectFriendRequest")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<IActionResult> RejectFriendRequest(Guid Id)
        {
            return Success(await _friendService.RejectFriendRequset(Id));
        }
    }
}