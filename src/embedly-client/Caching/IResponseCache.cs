﻿using Embedly.OEmbed;
using System.Threading.Tasks;

namespace Embedly.Caching
{
    /// <summary>
    /// Interface for cache providers
    /// </summary>
    public interface IResponseCache
    {
        /// <summary>
        /// Gets the cached response for the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<Response> Get(string url);

        /// <summary>
        /// Caches the response for the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="response">The response.</param>
        Task Put(string url, Response response);
    }
}