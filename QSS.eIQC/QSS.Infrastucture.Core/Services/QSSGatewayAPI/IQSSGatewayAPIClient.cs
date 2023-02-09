using QSS.Infrastructure.Core.QSSGatewayAPI.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.OData.Client;
using SAPHana.Model;

namespace QSS.Infrastructure.Core.Services.QSSGatewayAPI
{
    /// <summary>
    /// Interface for QSSGatewayAPIClient
    /// </summary>
    public interface IQSSGatewayAPIClient
    {
        /// <summary>
        /// Search Active Directory by SamAccount or Name
        /// </summary>
        /// <param name="input">SamAccount or Name</param>
        /// <returns></returns>
        Task<ADUserResponse> SearchBySamAccountOrName(string input);

        /// <summary>
        /// Send Email
        /// </summary>
        /// <param name="emailModel">Email Model</param>
        void SendEmail(EmailModel emailModel);
        /// <summary>
        /// Get Division
        /// </summary>
        /// <param name="dateTime">Date time</param>
        Task<IList<TM1DivisionModel>> GetDivision(DateTimeOffset dateTime);

        /// <summary>
        /// Get Site
        /// </summary>
        /// <param name="dateTime">Date time</param>
        Task<IList<TM1SiteModel>> GetSite(DateTimeOffset dateTime);

        ///// <summary>
        ///// GetParts from SAP
        ///// </summary>
        ///// <returns></returns>
        DataServiceQuery<SitePartModel> GetParts();
        /// <summary>
        /// Search Active Directory by Email
        /// </summary>
        /// <param name="email">Email</param>
        /// <returns></returns>
        Task<ADUserResponse> SearchByEmail(string email);

    }
}
