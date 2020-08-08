using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

namespace MiniFacebook.Shared.Helper
{
    public static class MethodsHelper
    {
        private static IHttpContextAccessor _httpContextAccessor;
        private static void Init()
        {
            IHttpContextAccessor httpContextAccessor = new HttpContextAccessor();
            _httpContextAccessor = httpContextAccessor;
        }

        public static Guid GetCurrentUserId()
        {
            Init();
            var currentUser = _httpContextAccessor.HttpContext.User;
            var UserId = currentUser.Claims.FirstOrDefault(x => x.Type == "UserId").Value;
            return Guid.Parse(UserId);
        }
    }
}
