using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MiniFacebook.Orchestrator.Services.PostService;
using MiniFacebook.Shared.GlobalReturnsController;
using MiniFacebook.Shared.Helper;
using MiniFacebook.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
    public class PostController : BaseController
    {
        private readonly IPostService _postService;
        /// <summary>
        /// 
        /// </summary>
        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        /// <summary>
        /// Add Post
        /// </summary>
        /// <param name="Payload"></param>
        /// <returns></returns>     
        [Authorize]
        [HttpPost("AddPost")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<IActionResult> AddPost([FromForm] AddPostDto Payload)
        {
            return Ok(await _postService.AddPost(Payload));
        }

        /// <summary>
        /// List Posts
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="paginationObject"></param>
        /// <returns></returns>     
        [Authorize]
        [HttpGet("GetPosts/{UserId}")]
        [ProducesResponseType(typeof(IEnumerable<PostDto>), 200)]
        public async Task<IActionResult> ListFriendPosts(Guid UserId,[FromQuery] PaginationObject paginationObject)
        {
            return Ok(await _postService.ListMyFriendPosts(UserId, paginationObject));
        }

        /// <summary>
        /// List My Posts
        /// </summary>
        /// <param name="paginationObject"></param>
        /// <returns></returns>     
        [Authorize]
        [HttpGet("Mywall")]
        [ProducesResponseType(typeof(IEnumerable<PostDto>), 200)]
        public async Task<IActionResult> ListMyWall([FromQuery] PaginationObject paginationObject)
        {
            return Success(await _postService.ListMyWall(paginationObject));
        }

        /// <summary>
        /// Delete Post
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>     
        [Authorize]
        [HttpDelete("Delete/{Id}")]
        [ProducesResponseType(typeof(bool), 200)]
        public async Task<IActionResult> DeletePost(Guid Id)
        {
            return Ok(await _postService.DeletePost(Id));
        }

    }
}
