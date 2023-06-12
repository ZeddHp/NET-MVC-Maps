using CsvHelper.Configuration.Attributes;
using MVC_leaflet.Enums;
using MVC_leaflet.Models;
using System;

namespace MVC_leaflet.DB
{
    public class Place : CentroidDataDto
    {

        /// <summary>
        /// Centroid Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// KODS
        /// </summary>
        [Name("KODS")]
        public int Code { get; set; }

        /// <summary>
        /// TIPS_CD
        /// </summary>
        [Name("TIPS_CD")]
        public LocationTypeEnum Type { get; set; }

        /// <summary>
        /// NOSAUKUMS
        /// </summary>
        [Name("NOSAUKUMS")]
        public string Name { get; set; }

        /// <summary>
        /// VKUR_CD
        /// </summary>
        [Name("VKUR_CD")]
        public int LocationCode { get; set; }

        /// <summary>
        /// VKUR_TIPS
        /// </summary>
        [Name("VKUR_TIPS")]
        public LocationTypeEnum LocationType { get; set; }

        /// <summary>
        /// STD
        /// </summary>
        [Name("STD")]
        public string GeoAddress { get; set; }

        /// <summary>
        /// KOORD_X
        /// </summary>
        [Name("KOORD_X")]
        public decimal Long { get; set; }

        /// <summary>
        /// KOORD_Y 
        /// </summary>
        [Name("KOORD_Y")]
        public decimal Lat { get; set; }

        /// <summary>
        /// DD_E
        /// </summary>
        [Name("DD_E")]
        public decimal DDE { get; set; }

        /// <summary>
        /// DD_N
        /// </summary>
        [Name("DD_N")]
        public decimal DDN { get; set; }


        //remove first and last letter from string
        public static string FirsLast(string word)
        {

            string retVal = string.Format("{0}...{1}", word.Substring(0, 1), word.Substring(word.Length - 1));

            return retVal;
        }
    }
}
