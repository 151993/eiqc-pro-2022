using QSS.eIQC.Domain.Enums;
using QSS.Infrastructure.Core.QSSGatewayAPI.Model;

namespace QSS.eIQC.Handlers.Helper
{
    public interface IEmailNotificationHelper
    {
        void SendEmail(object obj, EmailTemplateEnum emailTemplate, EmailModel emailModel);
    }
}
