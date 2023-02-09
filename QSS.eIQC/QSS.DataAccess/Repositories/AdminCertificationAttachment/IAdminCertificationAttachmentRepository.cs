using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for User 
    /// </summary>
    public interface IAdminCertificationAttachmentRepository
    {
        Task<AdminCertificationAttachment> AddAsync(AdminCertificationAttachment adminCertificationAttachment, string adminCertificationName, string changeReason);

        Task UpdateAsync(AdminCertificationAttachment adminCertificationAttachment, string adminCertificationName, string changeReason);

        Task RemoveByIdAsync(int id, string adminCertificationName, string changeReason);

        void AddRange(AdminCertification adminCertification, IEnumerable<Attachment> attachments);

        void RemoveRange(int adminCertificationId, IEnumerable<int> attachmentIds);

        void AddAdminCertificationAttachments(AdminCertification adminCertification, IEnumerable<Attachment> attachments, string changeReason);

    }
}
