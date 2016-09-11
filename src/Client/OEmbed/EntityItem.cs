using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Embedly.OEmbed
{
    /// <summary>
    /// The entities object gives you a list of proper nouns (persons, places, and things) extracted from the article or blog text of a URL. 
    /// </summary>
    [DataContract]
    public class EntityItem
    {
        /// <summary>
        /// Name of the entity (person, place, or thing).
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Number of times an entity appears in the text.
        /// </summary>
        [DataMember(Name = "count")]
        public long Count { get; private set; }
    }
}