using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{

    /// <summary>
    /// Repository for PartInspectionDrawingAttachment, provides Add, Update and Delete operations
    /// </summary>
    public class PartInspectionDrawingAttachmentRepository : BaseRepository<PartInspectionDrawingAttachment, int>, IPartInspectionDrawingAttachmentRepository
    {

        public PartInspectionDrawingAttachmentRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        { }

        public async Task<PartInspectionDrawingAttachment> AddAsync(PartInspectionDrawingAttachment PartInspectionDrawingAttachment, string SAPPartInspetionPlanName, string changeReason)
        {
            return await AddAsync(PartInspectionDrawingAttachment, Constants.AuditLog.Title.AddSAPPartInspectionPlan(SAPPartInspetionPlanName), changeReason);
        }

        public async Task<PartInspectionDrawingAttachment> UpdateAsync(PartInspectionDrawingAttachment PartInspectionDrawingAttachment, string SAPPartInspetionPlanName, string changeReason)
        {
           return  await UpdateAsync(PartInspectionDrawingAttachment, Constants.AuditLog.Title.EditSAPPartInspectionPlan(SAPPartInspetionPlanName), changeReason);
        }

        public void AddRange(PartInspectionDrawing partInspectionDrawing, IEnumerable<Attachment> attachments)
        {
            foreach (var attachment in attachments)
            {
                partInspectionDrawing.PartInspectionDrawingAttachments.Add(new PartInspectionDrawingAttachment
                {
                    PartInspectionDrawing = partInspectionDrawing,
                    Attachment = attachment,
                    Status = StatusType.Active
                });
            }
        }

        public void AddRange(PartInspectionDrawing partInspectionDrawing, IEnumerable<PartInspectionDrawingAttachment> attachments)
        {
            foreach (var attachment in attachments)
            {
                partInspectionDrawing.PartInspectionDrawingAttachments.Add(new PartInspectionDrawingAttachment
                {
                    PartInspectionDrawing = partInspectionDrawing,
                    Attachment = attachment.Attachment,
                    Status = StatusType.Active
                });
            }
        }

        public async Task<PartInspectionDrawing> AddPartInspectionDrawingAttachments(PartInspectionDrawing partInspectionDrawing, IEnumerable<Attachment> attachments, string changeReason)
        {
            // If attachment is new then add it
            var attachmentsToAdd = attachments.Where(a => a.Id <= 0).ToList();
            this.AddRange(partInspectionDrawing, attachmentsToAdd);

            if (partInspectionDrawing.Id > 0)
            {
                // If attachment is not present in the incoming list then remove it
                var PartInspectionDrawingAttachments = this.Find(ca => ca.PartInspectionDrawingId == partInspectionDrawing.Id).ToList();
                var attachmentsToRemove = PartInspectionDrawingAttachments.Where(ca => !attachments.Any(a => a.Id == ca.AttachmentId));
                this.RemoveRange(attachmentsToRemove);
            }
            return partInspectionDrawing;
        }

        public void RemoveRange(int partInspectionDrawingId, IEnumerable<int> attachmentIds)
        {
            if (attachmentIds != null)
            {
                var attachmentsToRemove = this.Find(eca => eca.PartInspectionDrawingId == partInspectionDrawingId
                    && attachmentIds.Contains(eca.AttachmentId));
                if (attachmentsToRemove != null && attachmentsToRemove.Count() > 0)
                {
                    this.RemoveRange(attachmentsToRemove);
                }
            }
        }


        public async Task<bool> RemoveByIdAsync(int id, string adminCertificateName, string changeReason)
        {
            var sapPartInspectionPlan = await ValidateExistsAndGetAsync(id);

            SetAuditLog(sapPartInspectionPlan, Constants.AuditLog.Title.DeleteSAPPartInspectionPlan(adminCertificateName), changeReason);

            return Remove(sapPartInspectionPlan);
        }
    }
}
