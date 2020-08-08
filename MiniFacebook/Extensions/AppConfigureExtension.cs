using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MiniFacebook.DAL.DataContext;

namespace MiniFacebook.API.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class AppConfigureExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public static void ConfigureDatabaseIfNotExists(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<FacebookDbContext>();
                context.Database.EnsureCreated();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        public static void ConfigureSwaggerUI(this IApplicationBuilder app)
        {
            app.UseSwaggerUI(setupAction =>
            {
                setupAction.SwaggerEndpoint(
                   "/swagger/MiniFacebookSpecification/swagger.json",
                   "MiniFacebook API");

                setupAction.RoutePrefix = "";

                setupAction.InjectStylesheet("/swagger-custom/swagger-custom-styles.css");
                setupAction.InjectJavascript("/swagger-custom/swagger-custom-script.js", "text/javascript");
            });
        }
    }
}
