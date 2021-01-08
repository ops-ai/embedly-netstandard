using System.Runtime.Serialization;

namespace EmbedlyClient.Extract
{
    [DataContract]
    public class Entity
    {
        /// <summary>
        /// Name of the entity (person, place, or thing).
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Number of times an entity appears in the text.
        /// </summary>
        [DataMember(Name = "count")]
        public int Count { get; set; }
    }
}
