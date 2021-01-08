using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EmbedlyClient.Extract
{
    [DataContract]
    public class ImageColor
    {
        /// <summary>
        /// RGB representation of the color
        /// </summary>
        [DataMember(Name = "color")]
        public List<int> Color { get; set; }

        /// <summary>
        /// Weight determines how prevalent that color is in the image.
        /// </summary>
        [DataMember(Name = "weight")]
        public decimal Weight { get; set; }
    }
}
