using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using MiniFacebook.API.Extensions;
using MiniFacebook.DAL.DataContext;
using MiniFacebook.Shared.Helper;
using MiniFacebook.Shared.Helper.AppsettingHelper;
using MiniFacebook.Shared.Middlewares;
using System;

namespace MiniFacebook.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public static readonly string AllowOriginPolicy = "allowOriginPolicy";


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.DatabaseConfig(Configuration);

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedPhoneNumber = true)
                .AddEntityFrameworkStores<UserContext>();
            services.Configure<DataProtectionTokenProviderOptions>(o =>
                                                                   o.TokenLifespan = TimeSpan.FromHours(3));
            //services.Configure<AuthMessageSenderOptions>(Configuration);

            services.RegisterServices();
            services.RegisterAppServices();
            services.RegisterRepositories();
            services.AddSwaggerConfig(Configuration);
            services.AddVersioning();
            services.RegisterAppServices();
            services.Configure<PhotoSettings>(Configuration.GetSection("PhotoSettings"));
            services.Configure<ImagesFolderSettings>(Configuration.GetSection("ServerSetting"));

            //var emailConfig = Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
            //services.AddSingleton(emailConfig);
            services.AddCors(options =>
            {
                options.AddPolicy(AllowOriginPolicy, builder =>
                {
                    builder
                        .AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .Build();
                }
                );
            });

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ClockSkew = TimeSpan.Zero,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
                };
            });
            services.AddResponseCaching(options =>
            {
                options.MaximumBodySize = 1024;
                options.UseCaseSensitivePaths = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.ConfigureCustomExceptionMiddleware();
            app.ConfigureDatabaseIfNotExists();

            app.UseSwagger();
            app.ConfigureSwaggerUI();

            //app.UseCors();

            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseResponseCaching();

            app.Use(async (context, next) =>
            {
                context.Response.GetTypedHeaders().CacheControl =
                    new Microsoft.Net.Http.Headers.CacheControlHeaderValue()
                    {
                        Public = true,
                        MaxAge = TimeSpan.FromSeconds(10)
                    };
                context.Response.Headers[Microsoft.Net.Http.Headers.HeaderNames.Vary] =
                    new string[] { "Accept-Encoding" };

                await next();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
