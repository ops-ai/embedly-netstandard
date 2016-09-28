using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace EmbedlyClient.Extract
{
    [DataContract]
    public class Keyword
    {
        /// <summary>
        /// Name of the keyword.
        /// </summary>
        [DataMember(Name = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Score of the keyword from the article, larger numbers infer more relevance.
        /// </summary>
        [DataMember(Name = "score")]
        public string Score { get; set; }
    }
}
