namespace QSS.eIQC.Domain.Configuration
{
    /// <summary>
    /// The ActiveDirectory Service Options Class
    /// </summary>
    public class ADServiceOptions
    {
        /// <summary>
        /// The Base URL
        /// </summary>
        public string BaseTokenUrl { get; set; }
        /// <summary>
        /// The Base URL
        /// </summary>
        public string BaseUrl { get; set; }
        /// <summary>
        /// SearchBySamAccountOrName API method
        /// </summary>
        public string SearchBySamAccountOrName { get; set; }
        /// <summary>
        /// SearchBySamAccountName API method
        /// </summary>
        public string SearchBySamAccountName { get; set; }
        /// <summary>
        /// SearchByName API method
        /// </summary>
        public string SearchByName { get; set; }
        /// <summary>
        /// SearchByEmail API method
        /// </summary>
        public string SearchByEmail { get; set; }

        public string ClientID { get; set; }

        public string ClientSecret { get; set; }
    }

}
