using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MiniFacebook.ViewModel.Auth;

namespace MiniFacebook.Orchestrator.Services.AuthenticateService
{
    public interface IAuthenticateService
    {
        Task<object> Login(LoginDto data);
        Task<object> Register(RegisterDto registerDto);
        Task<object> ForgetPassword(ForgetPasswordDto data);
        Task<object> RestPassword(RestPasswordDto data);
        Task<object> ConfirmPhone(string userId, string code);

    }
}
