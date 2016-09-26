using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace Embedly.OEmbed
{
    /// <summary>
    /// Represents a base oEmbed response primarily used to identify the type
    /// </summary>
    [DataContract]
    [KnownType(typeof (EmbedError))]
    [KnownType(typeof (EmbedLink))]
    public class Response : IEmbedContent
    {
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type value.
        /// </summary>
        /// <value>
        /// The type value.
        /// </value>
        [DataMember(Name = "type")]
        private string TypeValue
        {
            get { return Type.ToString(); }
            set { Type = (ResourceType)Enum.Parse(typeof (ResourceType), value, true); }
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        [IgnoreDataMember]
        [JsonIgnore]
        public ResourceType Type { get; set; }

        /// <summary>
        /// Gets the version.
        /// </summary>
        [DataMember(Name = "version")]
        public string Version { get; set; }
    }
}