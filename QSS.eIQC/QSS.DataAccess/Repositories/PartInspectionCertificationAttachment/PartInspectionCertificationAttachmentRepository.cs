using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Infrastucture.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository for CommodityAttachment, provides Add, Update and Delete operations
    /// </summary>
    public class PartInspectionCertificationAttachmentRepository : BaseRepository<PartInspectionCertificationAttachment, int>, IPartInspectionCertificationAttachmentRepository
    {

        public PartInspectionCertificationAttachmentRepository(QSSContext context) :
       base(context, AuditLogType.Configuration)
        { }

        public async Task<PartInspectionCertificationAttachment> AddAsync(PartInspectionCertificationAttachment partInspectionCertificationAttachment, string sapPartInspectionPlanName, string changeReason)
        {
            return await AddAsync(partInspectionCertificationAttachment, Constants.AuditLog.Title.AddAdminCertification(sapPartInspectionPlanName), changeReason);
        }

        public async Task UpdateAsync(PartInspectionCertificationAttachment partInspectionCertificationAttachment, string sapPartInspectionPlanName, string changeReason)
        {
            await UpdateAsync(partInspectionCertificationAttachment, Constants.AuditLog.Title.EditAdminCertification(sapPartInspectionPlanName), changeReason);
        }

        public void AddRange(SAPPartInspectionPlan sapPartInspectionPlan, IEnumerable<Attachment> attachments)
        {
            foreach (var attachment in attachments)
            {
                sapPartInspectionPlan.PartInspectionCertificationAttachments.Add(new PartInspectionCertificationAttachment
                {
                    SAPPartInspectionPlan = sapPartInspectionPlan,
                    Attachment = attachment,
                    Status = StatusType.Active
                });
            }
        }

        public void AddRange(SAPPartInspectionPlan sapPartInspectionPlan, IEnumerable<PartInspectionCertificationAttachment> attachments)
        {
            foreach (var attachment in attachments)
            {
                sapPartInspectionPlan.PartInspectionCertificationAttachments.Add(new PartInspectionCertificationAttachment
                {
                    SAPPartInspectionPlan = sapPartInspectionPlan,
                    Attachment = attachment.Attachment,
                    Status = StatusType.Active
                });
            }
        }

        public async Task<SAPPartInspectionPlan> AddPartInspectionCertificationAttachments(SAPPartInspectionPlan sapPartInspectionPlan,
            IEnumerable<Attachment> attachments, string changeReason)
        {
            // If attachment is new then add it
            var attachmentsToAdd = attachments.Where(a => a.Id <= 0).ToList();
            this.AddRange(sapPartInspectionPlan, attachmentsToAdd);

            if (sapPartInspectionPlan.Id > 0)
            {
                // If attachment is not present in the incoming list then remove it
                var partInspectionCertificationAttachments = this.Find(ca => ca.SAPPartInspectionPlanId == sapPartInspectionPlan.Id).ToList();
                var attachmentsToRemove = partInspectionCertificationAttachments.Where(ca => !attachments.Any(a => a.Id == ca.AttachmentId));
                this.RemoveRange(attachmentsToRemove);
            }
            return sapPartInspectionPlan;
        }

        public void RemoveRange(int sapPartInspectionPlanId, IEnumerable<int> attachmentIds)
        {
            if (attachmentIds != null)
            {
                var attachmentsToRemove = this.Find(eca => eca.SAPPartInspectionPlanId == sapPartInspectionPlanId
                    && attachmentIds.Contains(eca.AttachmentId));
                if (attachmentsToRemove != null && attachmentsToRemove.Count()>0)
                {
                    this.RemoveRange(attachmentsToRemove);
                }
            }
        }


        public async Task RemoveByIdAsync(int id, string name, string changeReason)
        {
            var adminCertificate = await ValidateExistsAndGetAsync(id);

            SetAuditLog(adminCertificate, Constants.AuditLog.Title.DeleteAdminCertification(name), changeReason);

            Remove(adminCertificate);
        }
    }
}
