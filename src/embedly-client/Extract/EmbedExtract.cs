using Embedly;
using Embedly.OEmbed;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace EmbedlyClient.Extract
{
    [DataContract]
    public class EmbedExtract
    {
        /// <summary>
        /// Lead paragraph that is a brief summary of the rest of the article.
        /// </summary>
        [DataMember(Name = "lead")]
        public string Lead { get; set; }

        /// <summary>
        /// Language of the article.
        /// </summary>
        [DataMember(Name = "language")]
        public string Language { get; set; }

        /// <summary>
        /// The url that was passed into Embedly.
        /// </summary>
        [DataMember(Name = "original_url")]
        public string OriginalUrl { get; set; }

        /// <summary>
        /// List of proper nouns (persons, places, and things) extracted from the article or blog text of a URL.
        /// </summary>
        [DataMember(Name = "entities")]
        public List<Entity> Entities { get; set; }

        /// <summary>
        /// Attribute that tells you if the url is on a phishing or malware list.
        /// </summary>
        [DataMember(Name = "safe")]
        public bool Safe { get; set; }

        /// <summary>
        /// Include for display purposes, it's the subdomain, hostname, and public suffix of the provider.
        /// </summary>
        [DataMember(Name = "provider_display")]
        public string ProviderDisplay { get; set; }

        /// <summary>
        /// Not implemented
        /// </summary>
        [DataMember(Name = "related")]
        public List<object> Related { get; set; }

        /// <summary>
        /// List of ranked keywords extracted from the article or blog text of a URL.
        /// </summary>
        [DataMember(Name = "keywords")]
        public List<Keyword> Keywords { get; set; }

        /// <summary>
        /// Html pulled from the URL. It's been sanitized, all tag attributes have been removed as well.
        /// </summary>
        [DataMember(Name = "content")]
        public string Content { get; set; }

        /// <summary>
        /// A list of all the authors that are associated with this article.
        /// </summary>
        [DataMember(Name = "authors")]
        public List<Author> Authors { get; set; }

        /// <summary>
        /// The url of the favicon.
        /// </summary>
        [DataMember(Name = "favicon_url")]
        public string FaviconUrl { get; set; }

        /// <summary>
        /// List of dominant colors extracted from favicon_url.
        /// </summary>
        [DataMember(Name = "favicon_colors")]
        public List<ImageColor> FaviconColors { get; set; }

        /// <summary>
        /// A representation of the date which the article was published in milliseconds.
        /// </summary>
        [DataMember(Name = "published")]
        public long Published { get; set; }

        /// <summary>
        /// The UTC offset of the published date in milliseconds.
        /// </summary>
        [DataMember(Name = "offset")]
        public long Offset { get; set; }

        /// <summary>
        /// List of, at most, 5 images that Embedly found while processing the URL.
        /// </summary>
        [DataMember(Name = "images")]
        public List<Image> Images { get; set; }

        /// <summary>
        /// Deep links like App Links, Twitter's App Card and Google's App Indexing.
        /// </summary>
        [DataMember(Name = "app_links")]
        public List<AppLink> AppLinks { get; set; }

        /// <summary>
        /// Gets or sets the media value.
        /// </summary>
        /// <value>
        /// The media value.
        /// </value>
        [DataMember(Name = "media")]
        private JObject MediaValue
        {
            get { return null; }
            set
            {
                if (!value.HasValues)
                    return;

                var obj = value.ToObject<Response>();
                switch (obj.Type)
                {
                    case ResourceType.image:
                        Media = value.ToObject<EmbedPhoto>();
                        break;
                    case ResourceType.video:
                        Media = value.ToObject<EmbedVideo>();
                        break;
                    case ResourceType.link:
                    case ResourceType.html:
                    case ResourceType.rss:
                    case ResourceType.xml:
                    case ResourceType.atom:
                    case ResourceType.json:
                    case ResourceType.ppt:
                    case ResourceType.audio:
                        Media = value.ToObject<EmbedRich>();
                        break;
                    default:
                        Media = value.ToObject<EmbedError>();
                        break;
                }
            }
        }

        /// <summary>
        /// Primary type of content (video, photo, etc.) that is associated with a url.
        /// It follows the general pattern of the /1/oembed Response, but with only a limited set of attributes. 
        /// Note: It is optional and only available if we can classify it as such type.
        /// </summary>
        [IgnoreDataMember]
        [JsonIgnore]
        public IEmbedContent Media { get; set; }

        #region Common members with EmbedLink type

        /// <summary>
        /// The effective url of the request. Whatever Embedly found at the end of any redirects.
        /// </summary>
        [DataMember(Name = "url")]
        public string Url { get; set; }

        /// <summary>
        /// The title of the resource.
        /// </summary>
        [DataMember(Name = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The name of the resource provider.
        /// </summary>
        [DataMember(Name = "provider_name")]
        public string Provider { get; set; }

        /// <summary>
        /// The url of the resource provider.
        /// </summary>
        [DataMember(Name = "provider_url")]
        public string ProviderUrl { get; set; }

        /// <summary>
        /// How long Embedly is going to cache the response for.
        /// </summary>
        [DataMember(Name = "cache_age")]
        public string CacheAge { get; set; }

        /// <summary>
        /// The description of the resource.
        /// </summary>
        [DataMember(Name = "description")]
        public string Description { get; set; }

        #endregion

        #region Common members with Response type

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
            set { Type = (ResourceType)Enum.Parse(typeof(ResourceType), value, true); }
        }

        /// <summary>
        /// Gets the type.
        /// </summary>
        [IgnoreDataMember]
        [JsonIgnore]
        public ResourceType Type { get; set; }

        #endregion
    }
}
