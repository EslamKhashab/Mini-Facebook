using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MiniFacebook.Shared.Helper
{
    public interface IUploadClass
    {
        Task<GlobalResponse.GlobalResponse> UploadGallery(IFormFileCollection Files);
        Task<bool> Delete(string FileName);
        Task<GlobalResponse.GlobalResponse> UploadPhoto(IFormFile File);
    }
}
