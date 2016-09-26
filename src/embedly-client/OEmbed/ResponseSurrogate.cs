using System.Runtime.Serialization;

namespace Embedly.OEmbed
{
    /// <summary>
    /// Surrogate class used when deserializing embedly oEmbed response
    /// </summary>
    [DataContract]
    public class ResponseSurrogate
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        [DataMember(Name = "version")]
        public string Version { get; private set; }
    }
}