using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace MiniFacebook.Shared.GlobalException
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="next"></param>
        /// <param name="loggerFactory"></param>
        /// <param name="configuration"></param>
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception e)
        {
            var exception = new
            {
                e.Message,
                e.StackTrace,
                e.InnerException,
                context.Response.StatusCode
            };

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                var ErrorMessageEn = GlobalErrorParsing.ErrorParsing.GetErrorDetailsByMessageId("ERR_Internal_01")[1].ToString();
                var ErrorMessageAr = GlobalErrorParsing.ErrorParsing.GetErrorDetailsByMessageId("ERR_Internal_01")[0].ToString();
                await context.Response.WriteAsync(new GlobalResponse.GlobalResponse()
                {
                    Success = false,
                    Data = null,
                    ErrorCode = "ERR_Internal_01",
                    ErrorMessage = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName == "en" ? ErrorMessageEn : ErrorMessageAr
                }.ToString());
            
            Log.ForContext("Message", e.Message)
                 .ForContext("StackTrace", e.StackTrace)
                 .ForContext("InnerException", e.InnerException)
                 .ForContext("ErrorId", null)
                 .ForContext("ExceptionType", context.Response.StatusCode)
                 .Error(LogEventLevel.Error.ToString());



        }
    }
}
