using Microsoft.EntityFrameworkCore;
using MVC_leaflet.Models;

namespace MVC_leaflet.DB
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Place> Places { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .EnableSensitiveDataLogging()
                .UseInMemoryDatabase(databaseName: "PlacesDb");
        }

    }
}