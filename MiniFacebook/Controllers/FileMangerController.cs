using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniFacebook.Shared.GlobalResponse;
using MiniFacebook.Shared.GlobalReturnsController;
using MiniFacebook.Shared.Helper;

namespace DQ.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json", "application/xml")]
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [Authorize]
    public class FileMangerController : BaseController
    {
        private readonly IUploadClass _uploadClass;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uploadClass"></param>
        public FileMangerController(IUploadClass uploadClass)
        {
            _uploadClass = uploadClass;
        }

        /// <summary>
        /// Upload One File
        /// </summary>
        /// <param name="File"></param>
        /// <returns></returns>

        [HttpPost("Upload")]
        [ProducesResponseType(typeof(string), 200)]
        public async Task<IActionResult> UploadFile(IFormFile File)
        {
            return Ok(await _uploadClass.UploadPhoto(File));
        }
        /// <summary>
        /// Upload Multiple File
        /// </summary>
        /// <param name="Files"></param>
        /// <returns></returns>
        [HttpPost("UploadMultipleFiles")]
        [ProducesResponseType(typeof(List<string>), 200)]
        [Authorize]
        public async Task<IActionResult> UploadMultipleFiles(IFormFileCollection Files)
        {
            return Ok(await _uploadClass.UploadGallery(Files));
        }
    }
}