using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MiniFacebook.Shared.Middlewares
{
    public class CurrentCultureMiddleware
    {
        private readonly RequestDelegate _next;

        public CurrentCultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var lang = context.Request.Headers["LanguageCode"].ToString();
            if (string.IsNullOrEmpty(lang))
            {
                lang = "en";
            }
            string firstLanguage = lang.Split(',').FirstOrDefault().ToLower();
            Thread.CurrentThread.CurrentCulture = new CultureInfo(firstLanguage);
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            await _next(context);
        }
    }
}
