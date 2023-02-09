namespace QSS.Http
{
    /// <summary>
    /// The Error Code
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// The null reference
        /// </summary>
        NullReference = 5000,

        /// <summary>
        /// The null service endpoint
        /// </summary>
        NullServiceEndpoint = 5001,

        /// <summary>
        /// The internal server error
        /// </summary>
        InternalServerError = 1000,

        /// <summary>
        /// The input values not good
        /// </summary>
        InputValuesNotGood = 4000,

        /// <summary>
        /// The not found
        /// </summary>
        NotFound = 4056,

        /// <summary>
        /// The bad request
        /// </summary>
        BadRequest = 1231,

        /// <summary>
        /// The invalid action
        /// </summary>
        InvalidAction = 3423,

        /// <summary>
        /// The maximum bake cycle reached
        /// </summary>
        MaximumBakeCycleReached = 4566,

        /// <summary>
        /// The minimum bake time
        /// </summary>
        MinimumBakeTime = 3456,

        /// <summary>
        /// The maximum bake time reached
        /// </summary>
        MaximumBakeTimeReached = 1006,

        /// <summary>
        /// The key already exists
        /// </summary>
        KeyAlreadyExists = 3007,

        /// <summary>
        /// Unable to delete as violates ForeignKey rule
        /// </summary>
        UnableToDelete = 2000,

    }
}
