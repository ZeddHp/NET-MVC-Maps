using AutoMapper;
using MVC_leaflet.DB;
using MVC_leaflet.Enums;
using MVC_leaflet.Mapping;

namespace MVC_leaflet.Models
{
    /// <summary>
    /// AW_VIETA_CENTROIDS
    /// This table is referenced in section 2.2.17 of the documentation.
    /// Documentation Link: https://www.vzd.gov.lv/lv/media/6149/download?attachment 
    /// </summary>
    public class CentroidDataDto : IMapFrom<Place>
    {
        /// <summary>
        /// Centroid Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// KODS
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// TIPS_CD
        /// </summary>
        public LocationTypeEnum Type { get; set; }

        /// <summary>
        /// NOSAUKUMS
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// VKUR_CD
        /// </summary>
        public int LocationCode { get; set; }

        /// <summary>
        /// VKUR_TIPS
        /// </summary>
        public LocationTypeEnum LocationType { get; set; }

        /// <summary>
        /// STD
        /// </summary>
        public string? GeoAddress { get; set; }

        /// <summary>
        /// KOORD_X
        /// </summary>
        public decimal Long { get; set; }

        /// <summary>
        /// KOORD_Y 
        /// </summary>
        public decimal Lat { get; set; }

        /// <summary>
        /// DD_E
        /// </summary>
        public decimal DDE { get; set; }

        /// <summary>
        /// DD_N
        /// </summary>
        public decimal DDN { get; set; }

        //public void Mapping(Profile profile)
        //{
        //    profile.CreateMap<Place, CentroidDataDto>();
        //}
    }
}
