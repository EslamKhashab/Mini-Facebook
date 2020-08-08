using Microsoft.Extensions.Configuration;
using System.IO;

namespace MiniFacebook.Shared.GlobalAppSettingsConfigurations
{
    public class AppSettingsConfigurations
    {
        public static IConfigurationRoot raedConfigurationFromAppSettings()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);
            var root = configurationBuilder.Build();
            return root;
        }
    }
}
