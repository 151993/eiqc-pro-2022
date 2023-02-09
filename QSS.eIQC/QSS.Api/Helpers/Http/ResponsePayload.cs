using System;
using Newtonsoft.Json;

namespace QSS.Http
{
    /// <summary>
    /// The Response Payload class
    /// </summary>
    /// <typeparam name="T">The generic type parameter.</typeparam>
    public class ResponsePayload<T> where T : class
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        [JsonProperty(PropertyName = "data", NullValueHandling = NullValueHandling.Ignore)]
        public T Data { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        [JsonProperty(PropertyName = "errorCode")]
        public int ErrorCode { get; set; }

        public Exception Exception { get; set; }
    }
}
