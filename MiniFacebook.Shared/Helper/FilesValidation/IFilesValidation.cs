using Microsoft.AspNetCore.Http;
using MiniFacebook.Shared.GlobalResponse;
using System.Threading.Tasks;

namespace MiniFacebook.Shared.Helper
{
    public interface IFilesValidation
    {
        Task<GlobalBadRequestResponse> IsValidPhotos(IFormFileCollection Photos);
        Task<GlobalBadRequestResponse> IsValidPhoto(IFormFile Photo);
    }
}
