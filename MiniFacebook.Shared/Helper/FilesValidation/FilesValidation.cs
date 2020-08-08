
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using MiniFacebook.Shared.GlobalResponse;
using MiniFacebook.Shared.Helper.AppsettingHelper;
using System.Linq;
using System.Threading.Tasks;

namespace MiniFacebook.Shared.Helper
{
    public class FilesValidation : IFilesValidation
    {
        private readonly PhotoSettings _photoSettings;
        public FilesValidation(IOptionsSnapshot<PhotoSettings> Imageoptions)
        {
            _photoSettings = Imageoptions.Value;
        }

        public async Task<GlobalBadRequestResponse> IsValidPhotos(IFormFileCollection Photos)
        {
            long MaxBytes = 0;
            if (Photos == null)
                return new GlobalBadRequestResponse { Success = false, ErrorMessage = "No File To Upload" };
            if (Photos.Count() <= 1 && Photos.First().Length == 0)
                return new GlobalBadRequestResponse { Success = false, ErrorMessage = "Empty File" };

            if (Photos.Count() == 1 && !_photoSettings.IsSupported(Photos.FirstOrDefault().FileName))
            {
                return new GlobalBadRequestResponse { Success = false, ErrorMessage = "File Should By JPG or JPEG or PNG" };
            }
            if (Photos.Count() > 1)
            {
                foreach (var item in Photos)
                {
                    MaxBytes += item.Length;
                    if (!_photoSettings.IsSupported(item.FileName))
                    {
                        return new GlobalBadRequestResponse { Success = false, ErrorMessage = "File Should By JPG or JPEG or PNG" };
                    }
                }
                if (MaxBytes > _photoSettings.MaxBytes)
                    return new GlobalBadRequestResponse { Success = false, ErrorMessage = "Files Should By less than 200 MB" };
            }
            return new GlobalBadRequestResponse { Success = true, ErrorMessage = "Files Uploaded Successfully" };

        }
        public async Task<GlobalBadRequestResponse> IsValidPhoto(IFormFile Photo)
        {
            long MaxBytes = 0;
            if (Photo == null)
                return new GlobalBadRequestResponse { Success = false, ErrorMessage = "No File To Upload" };
            if (Photo.Length == 0)
                return new GlobalBadRequestResponse { Success = false, ErrorMessage = "Empty File" };

            if (!_photoSettings.IsSupported(Photo.FileName))
            {
                return new GlobalBadRequestResponse { Success = false, ErrorMessage = "File Should By JPG or JPEG or PNG" };
            }
            if (MaxBytes > _photoSettings.MaxBytes)
                return new GlobalBadRequestResponse { Success = false, ErrorMessage = "Files Should By less than 200 MB" };

            return new GlobalBadRequestResponse { Success = true, ErrorMessage = "Files Uploaded Successfully" };

        }


    }
}

