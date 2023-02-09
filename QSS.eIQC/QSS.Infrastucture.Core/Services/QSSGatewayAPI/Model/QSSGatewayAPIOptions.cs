namespace QSS.Infrastructure.Core.QSSGatewayAPI.Model
{
    /// <summary>
    /// The QSSGatewayAPI Service Options Class
    /// </summary>
    public class QSSGatewayAPIOptions
    {

        /// <summary>
        /// The Base URL
        /// </summary>
        public string BaseUrl { get; set; }

        /// <summary>
        /// The Token URL
        /// </summary>
        public string TokenUrl { get; set; }

        /// <summary>
        /// The Email URL
        /// </summary>
        public string EmailUrl { get; set; }

        /// <summary>
        /// The ActiveDirectory URL
        /// </summary>
        public string ActiveDirectoryUrl { get; set; }

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

        /// <summary>
        /// SendEmail API method
        /// </summary>
        public string SendEmail { get; set; }

        /// <summary>
        /// ClientID
        /// </summary>
        public string ClientID { get; set; }

        /// <summary>
        /// ClientSecret
        /// </summary>
        public string ClientSecret { get; set; }

        public string Vendor { get; set; }

        public string DivisionUrl { get; set; }

        public string SiteUrl { get; set; }


        public int DBTimeOutDurationInSeconds { get; set; }
        public bool SetDBTimeOut { get; set; }

        public int BatchSize { get; set; }

    }
}
