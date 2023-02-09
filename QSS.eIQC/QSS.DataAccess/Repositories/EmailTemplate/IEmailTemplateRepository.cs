using QSS.eIQC.Domain.Models;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for EmailTemplate 
    /// </summary>
    public interface IEmailTemplateRepository 
    {
        Task UpdateAsync(EmailTemplate emailTemplate, string changeReason);
    }
}
