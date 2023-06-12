using CsvHelper;
using Microsoft.EntityFrameworkCore;
using MVC_leaflet.DB;
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

                // Apply any pending migrations
                context.Database.Migrate();
            }

            // Read CSV file
            // TODO: replace with runtime file path
            using (var streamReader = new StreamReader(@"C:\Users\valte\Downloads\AW_VIETU_CENTROIDI.csv"))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    var records = csvReader.GetRecords<dynamic>().ToList();
                }
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
