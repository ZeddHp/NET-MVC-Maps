using Microsoft.EntityFrameworkCore;

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
            optionsBuilder.UseSqlServer
            (
                @"Server=(localdb)\local;Database=PlaceDB;Trusted_Connection=True;"
            );
        }
    }
}