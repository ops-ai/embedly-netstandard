﻿using System.Runtime.Serialization;

namespace Embedly.OEmbed
{
    /// <summary>
    /// Represents an oEmbed rich content response
    /// </summary>
    [DataContract]
    public class EmbedRich : EmbedLink
    {
        /// <summary>
        /// Gets the HTML.
        /// </summary>
        [DataMember(Name = "html")]
        public string Html { get; set; }

        /// <summary>
        /// Gets the width.
        /// </summary>
        [DataMember(Name = "width")]
        public int Width { get; set; }

        /// <summary>
        /// Gets the height.
        /// </summary>
        [DataMember(Name = "height")]
        public int Height { get; set; }

        #region Optional Media fields.

        /// <summary>
        /// Age restrictions, valid values include variations of 18+, 13+, R, PG. Only present if populated.
        /// </summary>
        [DataMember(Name = "age_restriction")]
        public string AgeRestriction { get; set; }

        /// <summary>
        /// Duration of video, audio segment in seconds. Only present if populated.
        /// </summary>
        [DataMember(Name = "duration")]
        public float Duration { get; set; }

        #endregion
    }
}