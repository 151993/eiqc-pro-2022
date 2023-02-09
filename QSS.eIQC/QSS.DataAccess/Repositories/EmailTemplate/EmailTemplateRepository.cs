using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository for EmailTemplate, provides Add, Update and Delete operations
    /// </summary>
    public class EmailTemplateRepository : BaseRepository<EmailTemplate, int>, IEmailTemplateRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"><see cref="ApplicationConfigurationContext"/></param>
        public EmailTemplateRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
        }

        /// <summary>
        /// Updates existing EmailTemplate with new values
        /// </summary>
        /// <param name="emailTemplate">Updated entity of Department, <see cref="EmailTemplate"/></param>
        /// <returns>Saved entity of EmailTemplate, <see cref="EmailTemplate"/></returns>
        public async Task UpdateAsync(EmailTemplate emailTemplate, string changeReason)
        {
            await UpdateAsync(emailTemplate, Constants.AuditLog.Title.EditEmailTemplate(emailTemplate.Name), changeReason);
        }
    }
}
