using MiniFacebook.Shared.GlobalException;
using Microsoft.AspNetCore.Builder;
using MiniFacebook.Shared.Middlewares;

namespace MiniFacebook.Shared.Middlewares
{
    public static class ExceptionMiddlewareExtensions
    {
        public static void ConfigureCustomExceptionMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ExceptionMiddleware>();
            app.UseMiddleware<CurrentCultureMiddleware>();

        }
    }
}
