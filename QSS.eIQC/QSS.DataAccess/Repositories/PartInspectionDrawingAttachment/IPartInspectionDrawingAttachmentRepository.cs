using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for  PartInspectionDrawing
    /// </summary>
    public interface IPartInspectionDrawingAttachmentRepository
    {
        Task<PartInspectionDrawingAttachment> AddAsync(PartInspectionDrawingAttachment partInspectionDrawingAttachment, string name, string changeReason);

        Task<PartInspectionDrawingAttachment> UpdateAsync(PartInspectionDrawingAttachment partInspectionDrawingAttachment, string name, string changeReason);

        Task<bool> RemoveByIdAsync(int id, string name, string changeReason);

        void AddRange(PartInspectionDrawing partInspectionDrawing, IEnumerable<Attachment> attachments);

        void RemoveRange(int sapPartInspectionPlanId, IEnumerable<int> attachmentIds);

        Task<PartInspectionDrawing> AddPartInspectionDrawingAttachments(PartInspectionDrawing partInspectionDrawing, IEnumerable<Attachment> attachments, string changeReason);

    }
}
