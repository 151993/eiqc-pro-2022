using Microsoft.Extensions.Configuration;
using QSS.Common.Utilities.Extensions;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.Infrastructure.Core.QSSGatewayAPI.Model;
using QSS.Infrastructure.Core.Services.QSSGatewayAPI;
using QSS.eIQC.Infrastucture.Core.Helper;
using System.Linq;

namespace QSS.eIQC.Handlers.Helper
{
    /// <summary>
    /// Email Notification Helper
    /// </summary>
    public class EmailNotificationHelper : IEmailNotificationHelper
    {

        /// <summary>
        /// Store ApplicationConfigurationContext, <see cref="ApplicationConfigurationContext"/>
        /// </summary>
        private readonly IQSSContext _context;

        /// <summary>
        /// Store QSSCommonAPIClient, <see cref="QSSCommonAPIClient"/>
        /// </summary>
        private IQSSGatewayAPIClient _qssClient;

        private IConfiguration _configuration;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IApplicationConfigurationContext on runtime, <see cref="IApplicationConfigurationContext"/></param>
        /// <param name="qssClient">Injected instance of IQSSCommonAPIClient on runtime, <see cref="IQSSCommonAPIClient"/></param>
        public EmailNotificationHelper(IQSSContext context, IQSSGatewayAPIClient qssClient, IConfiguration configuration)
        {
            _context = context;
            _qssClient = qssClient;
            _configuration = configuration;
        }

        /// <summary>
        /// Send Email
        /// </summary>
        /// <param name="obj">Required class object to parse</param>
        /// <param name="emailTemplate">Template enum to parse</param>
        /// <param name="emailModel">Email Model</param>
        public void SendEmail(object obj, EmailTemplateEnum emailTemplate, EmailModel emailModel)
        {
            var template = _context.EmailTemplate.FirstOrDefault(x => x.Id == (int)emailTemplate);
            if (template != null)
            {
                var emailObj = ParseEmailHelper.BuildEmailObject(obj, template.Body);
                emailModel.EmailBody = ParseEmailHelper.ParseTemplate(emailObj, template.Body);
                emailModel.Subject = ParseEmailHelper.ParseTemplate(emailObj, template.Subject);
            }

            if (emailModel.EmailBody.Contains(EmailTemplateBaseEnum.DNS.GetDescription()))
            {
                emailModel.EmailBody = emailModel.EmailBody.Replace(EmailTemplateBaseEnum.DNS.GetDescription(), _configuration.GetSection("EmailTemplate").GetSection("DNS").Value);
            }

            if (string.IsNullOrEmpty(emailModel.From))
            {
                emailModel.From = _configuration.GetSection("EmailTemplate").GetSection("From").Value;
            }

            _qssClient.SendEmail(emailModel);
        }
    }
}
