using AutoMapper;
using DQ.API.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Extensions.Localization;
using MiniFacebook.Shared.GlobalResponse;
using MiniFacebook.Shared.GlobalUOW;
using MiniFacebook.Shared.Helper;
using MiniFacebook.Shared.Helper.AppsettingHelper;
using MiniFacebook.Shared.Localization;
using MiniFacebook.Orchestrator.Services.AuthenticateService;
using MiniFacebook.DAL.Repository.UserRepository;
using MiniFacebook.DAL.DataContext;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Serialization;
using MiniFacebook.DAL.Repository.UserFriendRepository;
using MiniFacebook.DAL.Repository.PostRepository;
using MiniFacebook.Orchestrator.Services.FriendService;
using MiniFacebook.Orchestrator.Services.PostService;

namespace MiniFacebook.API.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class ConfigureServicesExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterAppServices(this IServiceCollection services)
        {

            services.AddControllers(setupAction =>
            {
                setupAction.Filters.Add(
                    new ProducesResponseTypeAttribute(typeof(GlobalBadRequestResponse), StatusCodes.Status400BadRequest));
                setupAction.Filters.Add(
                    new ProducesResponseTypeAttribute(typeof(GlobalResponse), StatusCodes.Status406NotAcceptable));
                setupAction.Filters.Add(
                    new ProducesResponseTypeAttribute(typeof(GlobalResponse), StatusCodes.Status500InternalServerError));
                setupAction.Filters.Add(
                    new ProducesDefaultResponseTypeAttribute());

                setupAction.ReturnHttpNotAcceptable = true;
            })

           .AddNewtonsoftJson(options =>
                              options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver())

           .ConfigureApiBehaviorOptions(options =>
           {
               options.InvalidModelStateResponseFactory = context =>
               {
                   var problems = new CustomBadRequest(context, context.HttpContext);
                   return new BadRequestObjectResult(problems);
               };
           });

            services.AddAutoMapper();
            return services;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                // Specify the default API Version
                config.DefaultApiVersion = new ApiVersion(1, 0);
                // If the client hasn't specified the API version in the request, use the default API version number 
                config.AssumeDefaultVersionWhenUnspecified = true;
                // Advertise the API versions supported for the particular endpoint
                config.ReportApiVersions = true;

                // DEFAULT Version reader is QueryStringApiVersionReader();  
                // clients request the specific version using the X-version header
                config.ApiVersionReader = new HeaderApiVersionReader("X-version");

                // Supporting multiple versioning scheme
                //config.ApiVersionReader = ApiVersionReader.Combine(new HeaderApiVersionReader("X-version"), new QueryStringApiVersionReader("api-version"));
            });

            return services;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddSwaggerConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwaggerGen(setupAction =>
            {
                setupAction.SwaggerDoc(
                  "MiniFacebookSpecification",
                  new OpenApiInfo
                  {
                      Title = "MiniFacebook API",
                      Version = "1",
                  });

                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);
                setupAction.IncludeXmlComments(xmlCommentsFullPath);
                setupAction.OperationFilter<RequiredHeaderParameter>();

                setupAction.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                });
                setupAction.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
                });

            });

            return services;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IFriendService, FriendService>();
            services.AddTransient<IUploadClass, UploadClass>();
            services.AddTransient<IFilesValidation, FilesValidation>();
            services.AddTransient<IAppSettingConfiguration, AppSettingConfiguration>();
            services.AddTransient<IAuthenticateService, AuthenticateService>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
            services.AddSingleton<IdentityLocalizationService>();
            services.AddLocalization(o =>
            {
                // We will put our translations in a folder called Resources
                o.ResourcesPath = "Resources";
            });
            services.AddSingleton<IStringLocalizerFactory, JsonStringLocalizerFactory>();
            services.AddSingleton<IStringLocalizer, JsonStringLocalizer>();

            return services;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<IUserFriendRepository, UserFriendRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection DatabaseConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<DbContext, UserContext>();
            services.AddDbContext<UserContext>(opts =>
                 opts.UseSqlServer(configuration["ConnectionStrings:UserDatabase"]));
            services.AddScoped(typeof(UserContext));

            services.AddScoped<DbContext, FacebookDbContext>();
            services.AddDbContext<FacebookDbContext>(opts =>
                 opts.UseSqlServer(configuration["ConnectionStrings:FacebookDatabase"]));
            services.AddScoped(typeof(FacebookDbContext));


            return services;
        }

    }
}
