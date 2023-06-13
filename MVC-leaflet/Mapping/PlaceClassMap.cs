using CsvHelper.Configuration;
using MVC_leaflet.DB;

namespace MVC_leaflet.Mapping
{
    public class PlaceClassMap : ClassMap<Place>
    {
        public PlaceClassMap() 
        { 
            //Map(m => m.Id).Name("Id");
            Map(m => m.Code).Name("KODS");
            Map(m => m.Type).Name("TIPS_CD");
            Map(m => m.Name).Name("NOSAUKUMS");
            Map(m => m.LocationCode).Name("VKUR_CD");
            Map(m => m.LocationType).Name("VKUR_TIPS");
            Map(m => m.GeoAddress).Name("STD");
            Map(m => m.Long).Name("KOORD_X");
            Map(m => m.Lat).Name("KOORD_Y");
            Map(m => m.DDE).Name("DD_N");
            Map(m => m.DDN).Name("DD_E");
        }


    }
}
