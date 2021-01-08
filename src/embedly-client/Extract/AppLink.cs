using System.Runtime.Serialization;

namespace EmbedlyClient.Extract
{
    [DataContract]
    public class AppLink
    {
        /// <summary>
        /// The type of the deep link.
        /// </summary>
        [DataMember(Name = "namespace")]
        public string Namespace { get; set; }

        /// <summary>
        /// The type of the device the deep link targets.
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}
