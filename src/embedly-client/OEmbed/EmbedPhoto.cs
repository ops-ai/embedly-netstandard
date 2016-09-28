using System.Runtime.Serialization;

namespace Embedly.OEmbed
{
    /// <summary>
    /// Represents an oEmbed photo response
    /// </summary>
    [DataContract]
    public class EmbedPhoto : EmbedLink
    {
        /// <summary>
        /// Gets the width.
        /// </summary>
        [DataMember(Name = "width")]
        public int Width { get; private set; }

        /// <summary>
        /// Gets the height.
        /// </summary>
        [DataMember(Name = "height")]
        public int Height { get; private set; }

        #region Optional Media fields.

        /// <summary>
        /// Age restrictions, valid values include variations of 18+, 13+, R, PG. Only present if populated.
        /// </summary>
        [DataMember(Name = "age_restriction")]
        public string AgeRestriction { get; set; }

        #endregion
    }
}