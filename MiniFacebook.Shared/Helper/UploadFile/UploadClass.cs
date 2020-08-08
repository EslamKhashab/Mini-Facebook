using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MiniFacebook.Shared.Helper
{
    public class UploadClass : IUploadClass
    {
        private readonly IFilesValidation _filesValidation;

        public UploadClass(IFilesValidation filesValidation)
        {
            _filesValidation = filesValidation;
        }
        public async Task<GlobalResponse.GlobalResponse> UploadGallery(IFormFileCollection Files)
        {
            var ValidPhotos = await _filesValidation.IsValidPhotos(Files);
            if (ValidPhotos.Success == false)
            {
                return ValidPhotos;
            }
            var UploadFolderPath = Path.Combine(@"wwwroot\Images");
            List<string> PhotosName = new List<string>();
            if (!Directory.Exists(UploadFolderPath))
                Directory.CreateDirectory(UploadFolderPath);
            foreach (var item in Files)
            {
                var FileName = Guid.NewGuid().ToString() + Path.GetExtension(item.FileName);
                var FilePath = Path.Combine(UploadFolderPath, FileName);
                PhotosName.Add(FileName);
                using (var stream = new FileStream(FilePath, FileMode.Create))
                {
                    item.CopyTo(stream);
                }
            }
            return new GlobalResponse.GlobalResponse { Data = PhotosName, Success = true };
        }
        public async Task<bool> Delete(string FileName)
        {
            var FolderPath = Path.Combine(@"wwwroot\images\uploads\gallery\" + FileName);
            File.Delete(FolderPath);
            return true;
        }

        public async Task<GlobalResponse.GlobalResponse> UploadPhoto(IFormFile File)
        {
            var ValidPhoto = await _filesValidation.IsValidPhoto(File);
            if (ValidPhoto.Success == false)
            {
                return ValidPhoto;
            }
            if (File != null)
            {
                var UploadFolderPath = Path.Combine(@"wwwroot\Images\");
                if (!Directory.Exists(UploadFolderPath))
                    Directory.CreateDirectory(UploadFolderPath);
                var FileName = Guid.NewGuid().ToString() + Path.GetExtension(File.FileName);
                var FilePath = Path.Combine(UploadFolderPath, FileName);
                using (var stream = new FileStream(FilePath, FileMode.Create))
                {
                    File.CopyTo(stream);
                }
                return new GlobalResponse.GlobalResponse { Data = FileName, Success = true };
            }
            return new GlobalResponse.GlobalResponse { Data = null, Success = false };
        }


    }
}
