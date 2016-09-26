using System.Runtime.Serialization;

namespace Embedly.OEmbed
{
    /// <summary>
    /// Represents an oEmbed link response
    /// </summary>
    [DataContract]
    [KnownType(typeof (EmbedPhoto))]
    [KnownType(typeof (EmbedRich))]
    [KnownType(typeof (EmbedVideo))]
    public class EmbedLink : Response
    {
        /// <summary>
        /// Gets the URL.
        /// </summary>
        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets the title.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets the author.
        /// </summary>
        [DataMember(Name = "author_name")]
        public string Author { get; set; }

        /// <summary>
        /// Gets the author URL.
        /// </summary>
        [DataMember(Name = "author_url")]
        public string AuthorUrl { get; set; }

        /// <summary>
        /// Gets the provider.
        /// </summary>
        [DataMember(Name = "provider_name")]
        public string Provider { get; set; }

        /// <summary>
        /// Gets the provider URL.
        /// </summary>
        [DataMember(Name = "provider_url")]
        public string ProviderUrl { get; set; }

        /// <summary>
        /// Gets the cache age.
        /// </summary>
        [DataMember(Name = "cache_age")]
        public string CacheAge { get; set; }

        /// <summary>
        /// Gets the thumbnail URL.
        /// </summary>
        [DataMember(Name = "thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Gets the width of the thumbnail.
        /// </summary>
        [DataMember(Name = "thumbnail_width")]
        public int ThumbnailWidth { get; set; }

        /// <summary>
        /// Gets the height of the thumbnail.
        /// </summary>
        [DataMember(Name = "thumbnail_height")]
        public int ThumbnailHeight { get; set; }

        /// <summary>
        /// Gets the description.
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }
    }
}