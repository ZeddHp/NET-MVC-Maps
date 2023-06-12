using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace MVC_leaflet.Enums
{
    /// <summary>
    /// Adresācijas objekta tips
    /// <para> This table is referenced in attachments section 1. </para>
    /// <para> Documentation Link: https://www.vzd.gov.lv/lv/media/6149/download?attachment </para>
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LocationTypeEnum
    {
        /// <summary>
        /// Latvijas Republika
        /// </summary>
        [EnumMember(Value = "101")]
        RepublicOfLatvia = 101,

        /// <summary>
        /// Rajons
        /// </summary>
        [EnumMember(Value = "102")]
        District = 102,

        /// <summary>
        /// Pilsēta
        /// </summary>
        [EnumMember(Value = "104")]
        City = 104,

        /// <summary>
        /// Pagasts
        /// </summary>
        [EnumMember(Value = "105")]
        Parish = 105,

        /// <summary>
        /// Ciems/mazciems
        /// </summary>
        [EnumMember(Value = "106")]
        Village = 106,

        /// <summary>
        /// Iela
        /// </summary>
        [EnumMember(Value = "107")]
        Street = 107,

        /// <summary>
        /// Ēka, apbūvei paredzēta zemes vienība
        /// </summary>
        [EnumMember(Value = "108")]
        Building = 108,

        /// <summary>
        /// Telpu grupa
        /// </summary>
        [EnumMember(Value = "109")]
        GroupOfPremises = 109,

        /// <summary>
        /// Novads
        /// </summary>
        [EnumMember(Value = "113")]
        Municipality = 113
    }
}
