using Microsoft.EntityFrameworkCore;
using MVC_leaflet.DB;
using MVC_leaflet.Interfaces;
using MVC_leaflet.Services;

namespace MVC_leaflet
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            //services.AddDbContext<Context>(options =>
            //               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<Context>(options =>
                           options.UseInMemoryDatabase(databaseName: "PlacesDb"));

            services.AddHttpClient();

            services.AddScoped<IDataService, DataService>();
            services.AddScoped<IDatabasePopulator, DatabasePopulator>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            using (var scope = app.ApplicationServices.CreateScope())
            {
                var databasePopulator = scope.ServiceProvider.GetRequiredService<IDatabasePopulator>();
                databasePopulator.PopulateDatabase();
            }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
