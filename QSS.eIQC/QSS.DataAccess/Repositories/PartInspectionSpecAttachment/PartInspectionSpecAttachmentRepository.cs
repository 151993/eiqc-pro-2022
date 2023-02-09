using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository for CommodityAttachment, provides Add, Update and Delete operations
    /// </summary>
    public class PartInspectionSpecAttachmentRepository : BaseRepository<PartInspectionSpecAttachment, int>, IPartInspectionSpecAttachmentRepository
    {

        public PartInspectionSpecAttachmentRepository(QSSContext context) :base(context, AuditLogType.Configuration)
        { }

        public async Task<PartInspectionSpecAttachment> AddAsync(PartInspectionSpecAttachment partInspectionSpecAttachment, string sapPartInspetionPlanName, string changeReason)
        {
            return await AddAsync(partInspectionSpecAttachment, Constants.AuditLog.Title.AddSAPPartInspectionPlan(sapPartInspetionPlanName), changeReason);
        }

        public async Task<PartInspectionSpecAttachment> UpdateAsync(PartInspectionSpecAttachment partInspectionSpecAttachment, string SAPPartInspetionPlanName, string changeReason)
        {
            return await UpdateAsync(partInspectionSpecAttachment, Constants.AuditLog.Title.EditSAPPartInspectionPlan(SAPPartInspetionPlanName), changeReason);
        }

        public void AddRange(PartInspectionSpecification partInspectionSpecification, IEnumerable<Attachment> attachments)
        {
            foreach (var attachment in attachments)
            {
                partInspectionSpecification.PartInspectionSpecAttachments.Add(new PartInspectionSpecAttachment
                {
                    PartInspectionSpecification = partInspectionSpecification,
                    Attachment = attachment,
                    Status = StatusType.Active
                });
            }
        }

        public void AddRange(PartInspectionSpecification partInspectionSpecification, IEnumerable<PartInspectionSpecAttachment> attachments)
        {
            foreach (var attachment in attachments)
            {
                partInspectionSpecification.PartInspectionSpecAttachments.Add(new PartInspectionSpecAttachment
                {
                    PartInspectionSpecification = partInspectionSpecification,
                    Attachment = attachment.Attachment,
                    Status = StatusType.Active
                });
            }
        }

        public async Task<PartInspectionSpecification> AddPartInspectionSpecAttachments(PartInspectionSpecification partInspectionSpecification,
            IEnumerable<Attachment> attachments, string changeReason)
        {
            // If attachment is new then add it
            var attachmentsToAdd = attachments.Where(a => a.Id <= 0).ToList();
            this.AddRange(partInspectionSpecification, attachmentsToAdd);

            if (partInspectionSpecification.Id > 0)
            {
                // If attachment is not present in the incoming list then remove it
                var partInspectionSpecAttachments = this.Find(ca => ca.PartInspectionSpecificationId == partInspectionSpecification.Id).ToList();
                var attachmentsToRemove = partInspectionSpecAttachments.Where(ca => !attachments.Any(a => a.Id == ca.AttachmentId));
                this.RemoveRange(attachmentsToRemove);
            }
            return partInspectionSpecification;
        }

        public void RemoveRange(int partInspectionSpecificationId, IEnumerable<int> attachmentIds)
        {
            if (attachmentIds != null)
            {
                var attachmentsToRemove = this.Find(eca => eca.PartInspectionSpecificationId == partInspectionSpecificationId
                    && attachmentIds.Contains(eca.AttachmentId));
                if (attachmentsToRemove != null && attachmentsToRemove.Count() > 0)
                {
                    this.RemoveRange(attachmentsToRemove);
                }
            }
        }


        public async Task<bool> RemoveByIdAsync(int id, string name, string changeReason)
        {
            var sapPartInspectionPlan = await ValidateExistsAndGetAsync(id);

            SetAuditLog(sapPartInspectionPlan, Constants.AuditLog.Title.DeleteSAPPartInspectionPlan(name), changeReason);

            return Remove(sapPartInspectionPlan);
        }
    }
}
