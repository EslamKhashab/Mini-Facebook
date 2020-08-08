using System;
using System.Text;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using AutoMapper;
using System.Security.Claims;
using MiniFacebook.Shared.GlobalResponse;
using MiniFacebook.DAL.Repository.UserRepository;
using MiniFacebook.ViewModel.Auth;
using MiniFacebook.Models.Entities;
using MiniFacebook.Shared.GlobalUOW;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Microsoft.Extensions.Localization;
using MiniFacebook.Shared.Localization;

namespace MiniFacebook.Orchestrator.Services.AuthenticateService
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private Microsoft.Extensions.Configuration.IConfiguration _config;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer _localizer;


        public AuthenticateService(Microsoft.Extensions.Configuration.IConfiguration iConfig, SignInManager<IdentityUser> signInManager,
                                    UserManager<IdentityUser> userManager, IMapper mapper, IUserRepository userRepository,
                                    IUnitOfWork unitOfWork, IStringLocalizer localizer)
        {
            _signInManager = signInManager;
            _config = iConfig;
            _userManager = userManager;
            _mapper = mapper;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }
        private string GenerateJSONWebToken(IdentityUser User)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[] {
                                new Claim("UserId", User.Id),
                                new Claim("UserName", User.UserName),
                                //new Claim(ClaimTypes.Role, "Manager")
                               };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
             _config["Jwt:Issuer"],
             claims,
             expires: DateTime.Now.AddDays(1),
             signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public async Task<object> Login(LoginDto data)
        {
            var User = await _userManager.FindByEmailAsync(data.Email);
            if (User == null)
            {
                User = await _userManager.FindByNameAsync(data.Email);
            }
            if (User != null)
            {
                var result = await _signInManager.PasswordSignInAsync(User.UserName, data.Password, true, lockoutOnFailure: true);
                if (result.IsNotAllowed)
                {
                    return new GlobalResponse { Data = false, Success = false, ErrorMessage = _localizer[LocalizationKeys.VerifyAccount] };
                }
                if (result.Succeeded)
                {
                    var tokenString = GenerateJSONWebToken(User);
                    var Final = new TokenDto();
                    Final.Token = tokenString;
                    Final.UserName = User.UserName;
                    return new GlobalResponse { Data = Final, Success = true };

                }
            }
            return new GlobalResponse { Data = false, Success = false, ErrorMessage = _localizer[LocalizationKeys.InvalidLogin] };
        }

        public async Task<object> Register(RegisterDto registerDto)
        {

            var user = new IdentityUser { UserName = registerDto.UserName, Email = registerDto.Email, PhoneNumber = registerDto.Phone };
            var result = await _userManager.CreateAsync(user, registerDto.Password);
            if (result.Succeeded)
            {
                var User = _mapper.Map<User>(registerDto);
                User.Id = Guid.Parse(user.Id);
                await _userRepository.AddAsync(User);
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                TwilioClient.Init(_config["twilio:accountSid"], _config["twilio:authToken"]);

                var message = MessageResource.Create(
                    body: token,
                    from: new Twilio.Types.PhoneNumber("+14359195361"),
                    to: new Twilio.Types.PhoneNumber("+2" + registerDto.Phone)
                );
                await _unitOfWork.CompleteAsync();
                return new GlobalResponse { Data = user.Id, Success = true, SuccessMessage = _localizer[LocalizationKeys.UserCreated] };
            }
            return new GlobalResponse { Data = false, Success = false, ErrorMessage = result.Errors.ToString() };
        }

        public async Task<object> RestPassword(RestPasswordDto data)
        {
            var user = await _userManager.FindByEmailAsync(data.Email);
            var result = await _userManager.ResetPasswordAsync(user, data.Code, data.Password);
            if (result.Succeeded)
            {
                return new GlobalResponse { Data = true, Success = true, SuccessMessage = "Password Rest Successfully" };

            }
            return new GlobalResponse { Data = false, Success = false, ErrorMessage = "Invalid Token" };

        }

        public async Task<object> ForgetPassword(ForgetPasswordDto data)
        {
            if (data != null)
            {
                var user = await _userManager.FindByEmailAsync(data.Email);
                if (user != null)
                {
                    var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                    return new GlobalResponse { Data = code, Success = true };
                }
            }
            return new GlobalResponse { Data = false, Success = false, ErrorMessage = "Invalid Email" };
        }
        public async Task<object> ConfirmPhone(string userId, string code)
        {

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return false;
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);

            if (!result.Succeeded)
            {

                return false;
            }
            user.PhoneNumberConfirmed = true;
            await _userManager.UpdateAsync(user);
            return GenerateJSONWebToken(user);
        }

    }
}
