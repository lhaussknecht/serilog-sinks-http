﻿using System.Net.Http;
using System.Threading.Tasks;

namespace Serilog.Sinks.Http
{
    /// <summary>
    /// Interface responsible for posting HTTP requests.
    /// </summary>
    public interface IHttpClient
    {
        /// <summary>
        /// Sends a POST request to the specified Uri as an asynchronous operation.
        /// </summary>
        /// <param name="requestUri">The Uri the request is sent to.</param>
        /// <param name="content">The HTTP request content sent to the server.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content);

        /// <summary>
        /// Releases the unmanaged resources and disposes of the managed resources used by the
        /// <see cref="IHttpClient"/>.
        /// </summary>
        void Dispose();
    }
}
