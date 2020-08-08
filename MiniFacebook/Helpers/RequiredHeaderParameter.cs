using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace DQ.API.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public class RequiredHeaderParameter : IOperationFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="context"></param>
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {

            operation.Parameters.Add(new OpenApiParameter
            {
                Name = "LanguageCode",
                In = ParameterLocation.Header,
                Required = true,
                Schema = new OpenApiSchema
                {
                    Type = "string",
                    Default = new OpenApiString("en")
                },
            });  
        }
    }
}
