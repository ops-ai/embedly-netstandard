using System.Runtime.Serialization;

namespace EmbedlyClient.Extract
{
    [DataContract]
    public class Author
    {
        /// <summary>
        /// Author's name.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Url of author's page.
        /// </summary>
        [DataMember(Name = "url")]
        public string Url { get; set; }
    }
}
