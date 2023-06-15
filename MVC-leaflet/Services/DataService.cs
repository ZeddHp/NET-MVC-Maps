using MVC_leaflet.DB;
using MVC_leaflet.Enums;
using MVC_leaflet.Interfaces;
using MVC_leaflet.Models;

namespace MVC_leaflet.Services
{
    public class DataService : IDataService
    {
        private readonly Context _dbContext;

        public DataService(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public void PopulateDatabase(string data)
        {
            string[] lines = data.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            // title line
            lines = lines.Skip(1).ToArray();

            foreach (string line in lines)
            {
                string[] fields = line.Split(new[] { ";" }, StringSplitOptions.None);

                var entity = new Place
                {
                    Code = int.Parse(fields[0]),
                    Type = (LocationTypeEnum)int.Parse(fields[1]),
                    Name = fields[2],
                    LocationCode = int.Parse(fields[3]),
                    LocationType = (LocationTypeEnum)int.Parse(fields[4]),
                    GeoAddress = fields[5],
                    Long = decimal.Parse(fields[6]),
                    Lat = decimal.Parse(fields[7]),
                    DDE = decimal.Parse(fields[8]),
                    DDN = decimal.Parse(fields[9])
            };

                _dbContext.Places.Add(entity);
            };
            _dbContext.SaveChanges();
        }
    }
}
