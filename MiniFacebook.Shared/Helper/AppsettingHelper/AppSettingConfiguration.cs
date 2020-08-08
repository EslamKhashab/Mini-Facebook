using Microsoft.Extensions.Options;

namespace MiniFacebook.Shared.Helper.AppsettingHelper
{
    public class AppSettingConfiguration : IAppSettingConfiguration
    {
        private readonly ImagesFolderSettings _imagesFolderSettings;
        private string _baseImageFolder;
        public AppSettingConfiguration(IOptionsSnapshot<ImagesFolderSettings> IoptionsSnapshot)
        {
            _imagesFolderSettings = IoptionsSnapshot.Value;
            _baseImageFolder = _imagesFolderSettings.BaseUrl + _imagesFolderSettings.BaseImageFolder;


        }
        public string GetAppsettingValueById()
        {
            return _baseImageFolder;
        }

        private string GetServerString()
        {
            return _imagesFolderSettings.BaseUrl;
        }
    }
}
