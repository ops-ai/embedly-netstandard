using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Embedly.OEmbed
{
    /// <summary>
    /// Represents an author
    /// </summary>
    [DataContract]
    public class Author
    {
        /// <summary>
        /// Name of the author
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Url of the author
        /// </summary>
        [DataMember(Name = "url")]
        public string Url { get; private set; }
    }
}