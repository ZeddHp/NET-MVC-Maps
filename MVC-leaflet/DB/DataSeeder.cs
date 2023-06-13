using MVC_leaflet.DB;
using MVC_leaflet.Enums;

namespace MVC_leaflet.Seeding
{
    public static class DataSeeder
    {

        public static void SeedData(Context context)
        {
            if (!IsSeeded(context))
            {
                List<Place> places = GenerateLocations(); // Generate locations

                foreach (Place place in places)
                {
                    context.Places.Add(place);
                }

                context.SaveChanges();

                MarkAsSeeded(context); // Mark seeding as completed
            }
        }

        public static bool IsSeeded(Context context)
        {
            // Check if the seeding marker exists in the database
            return context.SeedingMarkers.Any(m => m.SeedingCompleted) ? context.SeedingMarkers == null : false;
        }

        private static void MarkAsSeeded(Context context)
        {
            // Create or update the seeding marker in the database
            SeedingMarker marker = context.SeedingMarkers.FirstOrDefault();

            if (marker == null)
            {
                marker = new SeedingMarker { SeedingCompleted = true };
                context.SeedingMarkers.Add(marker);
            }
            else
            {
                marker.SeedingCompleted = true;
            }

            context.SaveChanges();
        }


        private static List<Place> GenerateLocations()
        {
            List<Place> places = new List<Place>();

            for (int i = 1; i <= 10; i++)
            {
                //random int from 101 - 113
                int randomInt = new Random().Next(101, 114);
                
                Place place = new Place
                {
                    Code = i,
                    Type = (LocationTypeEnum)randomInt,
                    Name = $"Place {i}",
                    LocationCode = i,
                    LocationType = (LocationTypeEnum)randomInt,
                    GeoAddress = $"Address {i}",
                    Long = i * 1.0m,
                    Lat = i * 2.0m,
                    DDE = i * 3.0m,
                    DDN = i * 4.0m
                };

                places.Add(place);
            }

            return places;
        }
    }
}