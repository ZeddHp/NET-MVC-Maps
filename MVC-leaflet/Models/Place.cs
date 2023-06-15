using CsvHelper.Configuration.Attributes;
using MessagePack;
using MVC_leaflet.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_leaflet.Models
{
    public class Place
    {
        /// <summary>
        /// Centroid Id
        /// </summary>
        public Guid Id { get; set; }

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
        public string Name { get; set; }

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
        public string GeoAddress { get; set; }

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
    }
}
