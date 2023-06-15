using CsvHelper;
using Microsoft.EntityFrameworkCore;
using MVC_leaflet.DB;
using MVC_leaflet.Models;
using System.Globalization;

namespace MVC_leaflet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<Context>();

                context.Database.EnsureCreated();

                context.Database.IsInMemory(); 
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddScoped<Context>();
                });
    }
}
