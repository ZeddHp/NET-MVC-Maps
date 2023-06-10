namespace MVC_leaflet.Models
{
    /// <summary>
    /// AW_VIETA_CENTROIDS
    /// This table is referenced in section 2.2.17 of the documentation.
    /// Documentation Link: https://www.vzd.gov.lv/lv/media/6149/download?attachment 
    /// </summary>
    public class CentroidDataDTO
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
        public int TypeCD { get; set; }

        /// <summary>
        /// NOSAUKUMS
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// VKUR_CD
        /// </summary>
        public int AddressObjectCode { get; set; }

        /// <summary>
        /// VKUR_TIPS
        /// </summary>
        public int AddressObjectTypeCode { get; set; }

        /// <summary>
        /// STD
        /// </summary>
        public string AddressObjectDescription { get; set; }

        /// <summary>
        /// KOORD_X
        /// </summary>
        public decimal CentroidXCoordinate { get; set; }

        /// <summary>
        /// KOORD_Y 
        /// </summary>
        public decimal CentroidYCoordinate { get; set; }

        /// <summary>
        /// DD_E
        /// </summary>
        public decimal CentroidDDECoordinate { get; set; }

        /// <summary>
        /// DD_N
        /// </summary>
        public decimal CentroidDDNCoordinate { get; set; }
    }
}
