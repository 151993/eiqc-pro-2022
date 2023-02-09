using System;

namespace QSS.Http
{
    /// <summary>
    /// The Response Status
    /// </summary>
    [Flags]
    public enum ResponseStatus
    {
        /// <summary>
        /// The success
        /// </summary>
        Success = 1,

        /// <summary>
        /// The failed
        /// </summary>
        Failed = 2,

        /// <summary>
        /// The not found
        /// </summary>
        NotFound = 3,

        /// <summary>
        /// The bad request
        /// </summary>
        BadRequest = 4,

        /// <summary>
        /// The invalid action
        /// </summary>
        InvalidAction = 5
    }
}
