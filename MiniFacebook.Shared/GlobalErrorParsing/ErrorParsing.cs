using Microsoft.Extensions.Configuration;
using MiniFacebook.Shared.GlobalAppSettingsConfigurations;
using MiniFacebook.ViewModel.DTO.CustomError;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniFacebook.Shared.GlobalErrorParsing
{
    public static class ErrorParsing
    {
        private static List<Error> GetAllErrors()
        {
            IConfigurationRoot root = AppSettingsConfigurations.raedConfigurationFromAppSettings();
            var errors = root.GetSection("Errors");
            string filePath = errors["JsonErrorsPath"].ToLower();
            
            string json = System.IO.File.ReadAllText(filePath, Encoding.UTF8);
            return JsonConvert.DeserializeObject<List<Error>>(json);

        }
        public static List<string> GetErrorDetailsByMessageId(string messageId)
        {
            var currentError = GetAllErrors().FirstOrDefault(m => m.Message_ID == messageId);
            return currentError == null ? null : new List<string> { currentError.Message_Description_EN, currentError.Message_Description_AR };
        }
    }
}
