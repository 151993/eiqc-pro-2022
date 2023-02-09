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
    public interface IPartInspectionSpecAttachmentRepository
    {
        Task<PartInspectionSpecAttachment> AddAsync(PartInspectionSpecAttachment partInspectionSpecAttachment, string name, string changeReason);

        Task<PartInspectionSpecAttachment> UpdateAsync(PartInspectionSpecAttachment partInspectionSpecAttachment, string name, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string name, string changeReason);

        void AddRange(PartInspectionSpecification partInspectionSpecification, IEnumerable<Attachment> attachments);

        void RemoveRange(int partInspectionSpecificationId, IEnumerable<int> attachmentIds);

        Task<PartInspectionSpecification> AddPartInspectionSpecAttachments(PartInspectionSpecification partInspectionSpecification, IEnumerable<Attachment> attachments, string changeReason);

    }
}
