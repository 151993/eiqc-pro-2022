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
    public interface IPartInspectionCertificationAttachmentRepository
    {
        Task<PartInspectionCertificationAttachment> AddAsync(PartInspectionCertificationAttachment partInspectionCertificationAttachment, string sapPartInspectionPlanName, string changeReason);

        Task UpdateAsync(PartInspectionCertificationAttachment partInspectionCertificationAttachment, string sapPartInspectionPlanName, string changeReason);

        Task RemoveByIdAsync(int id, string sapPartInspectionPlanName, string changeReason);

        void AddRange(SAPPartInspectionPlan sapPartInspectionPlan, IEnumerable<Attachment> attachments);

        void RemoveRange(int sapPartInspectionPlanId, IEnumerable<int> attachmentIds);

        Task<SAPPartInspectionPlan> AddPartInspectionCertificationAttachments(SAPPartInspectionPlan sapPartInspectionPlan, IEnumerable<Attachment> attachments, string changeReason);

    }
}
