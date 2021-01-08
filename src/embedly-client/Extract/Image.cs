using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EmbedlyClient.Extract
{
    [DataContract]
    public class Image
    {
        /// <summary>
        /// Short description of what the image is depicting.
        /// </summary>
        [DataMember(Name = "caption")]
        public string Caption { get; set; }

        /// <summary>
        /// Image url.
        /// </summary>
        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// The height of the image in pixels.
        /// </summary>
        [DataMember(Name = "height")]
        public int Height { get; set; }

        /// <summary>
        /// The width of the image in pixels.
        /// </summary>
        [DataMember(Name = "width")]
        public int Width { get; set; }

        /// <summary>
        /// The dominant colors of the image.
        /// </summary>
        [DataMember(Name = "colors")]
        public List<ImageColor> Colors { get; set; }

        /// <summary>
        /// Image entropy can be roughly thought of as how "busy" an image is.
        /// </summary>
        [DataMember(Name = "entropy")]
        public decimal Entropy { get; set; }

        /// <summary>
        /// The size in bytes of the image.
        /// </summary>
        [DataMember(Name = "size")]
        public long Size { get; set; }
    }
}
