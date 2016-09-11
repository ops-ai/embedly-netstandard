using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Embedly.OEmbed
{
    /// <summary>
    /// The keywords object gives you a list of ranked keywords extracted from the article or blog text of a URL. This is different from the meta keywords defined by the page. Embedly uses its own ranking system to determine which keywords are the most relevant. 
    /// </summary>
    [DataContract]
    public class Keyword
    {
        /// <summary>
        /// Name of the keyword.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Score of the keyword from the article, larger numbers infer more relevance.
        /// </summary>
        [DataMember(Name = "score")]
        public long Score { get; private set; }
    }
}