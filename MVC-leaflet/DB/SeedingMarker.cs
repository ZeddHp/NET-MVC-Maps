using System.ComponentModel.DataAnnotations;

namespace MVC_leaflet.DB
{
    public class SeedingMarker
    {
        [Key]
        public int Id { get; set; }

        public bool SeedingCompleted { get; set; }
    }
}