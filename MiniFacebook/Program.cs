using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using MiniFacebook.API.Extensions;
using Serilog;
using System.IO;

namespace MiniFacebook.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new ProgramConfigureExtension();
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseSerilog();
                    webBuilder.UseContentRoot(Directory.GetCurrentDirectory());
                    webBuilder.UseStartup<Startup>();
                });
    }
}
