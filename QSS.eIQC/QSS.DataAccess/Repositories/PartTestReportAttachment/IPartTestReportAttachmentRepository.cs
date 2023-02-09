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
    public interface IPartTestReportAttachmentRepository
    {
        Task<PartTestReportAttachment> AddAsync(PartTestReportAttachment partTestReportAttachment, string name, string changeReason);

        Task<PartTestReportAttachment> UpdateAsync(PartTestReportAttachment partTestReportAttachment, string name, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string name, string changeReason);

        void AddRange(PartTestReportParameter partTestReportParameter, IEnumerable<Attachment> attachments);

        void RemoveRange(int testReportId, IEnumerable<int> attachmentIds);

        Task<PartTestReportParameter> AddPartTestReportAttachments(PartTestReportParameter partTestReportParameter, IEnumerable<Attachment> attachments, string changeReason);

    }
}
