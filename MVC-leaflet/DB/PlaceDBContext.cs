using Microsoft.EntityFrameworkCore;

namespace MVC_leaflet.DB
{
    public class PlaceDBContext : DbContext
    {
        public PlaceDBContext(DbContextOptions<PlaceDBContext> options) : base(options)
        {
        }
        public DbSet<Place> Place { get; set; }

    }
}
