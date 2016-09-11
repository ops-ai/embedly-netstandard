using System;
using System.Security.Cryptography;
using System.Text;

namespace Embedly
{
    /// <summary>
    /// Represents an individual embedly url request with the associated provider that is expected to fulfill it
    /// </summary>
    public class UrlRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrlRequest"/> class.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="url">The URL.</param>
        public UrlRequest(Provider provider, string url)
        {
            Provider = provider;
            Url = url;
        }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public string Url { get; set; }
    }
}