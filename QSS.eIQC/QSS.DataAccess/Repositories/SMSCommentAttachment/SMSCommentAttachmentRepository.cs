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
    public class SMSCommentAttachmentRepository : BaseRepository<SMSCommentAttachment, int>, ISMSCommentAttachmentRepository
    {

        public SMSCommentAttachmentRepository(QSSContext context) :
       base(context, AuditLogType.Configuration)
        { }

        public async Task<SMSCommentAttachment> AddAsync(SMSCommentAttachment smsCommentAttachment, string supplierMeasurementSubmissionName, string changeReason)
        {
            return await AddAsync(smsCommentAttachment, Constants.AuditLog.Title.AddAdminCertification(supplierMeasurementSubmissionName), changeReason);
        }

        public async Task UpdateAsync(SMSCommentAttachment smsCommentAttachment, string supplierMeasurementSubmissionName, string changeReason)
        {
            await UpdateAsync(smsCommentAttachment, Constants.AuditLog.Title.EditAdminCertification(supplierMeasurementSubmissionName), changeReason);
        }

        public void AddRange(SupplierMeasurementSubmission supplierMeasurementSubmission, IEnumerable<Attachment> attachments)
        {
            foreach (var attachment in attachments)
            {
                supplierMeasurementSubmission.SMSCommentAttachments.Add(new SMSCommentAttachment
                {
                    SupplierMeasurementSubmission = supplierMeasurementSubmission,
                    Attachment = attachment,
                    Status = StatusType.Active
                });
            }
        }

        public void AddRange(SupplierMeasurementSubmission supplierMeasurementSubmission, IEnumerable<SMSCommentAttachment> attachments)
        {
            foreach (var attachment in attachments)
            {
                supplierMeasurementSubmission.SMSCommentAttachments.Add(new SMSCommentAttachment
                {
                    SupplierMeasurementSubmission = supplierMeasurementSubmission,
                    Attachment = attachment.Attachment,
                    Status = StatusType.Active
                });
            }
        }

        public async Task<SupplierMeasurementSubmission> AddSMSCommentAttachments(SupplierMeasurementSubmission supplierMeasurementSubmission,
            IEnumerable<Attachment> attachments, string changeReason)
        {
            // If attachment is new then add it
            var attachmentsToAdd = attachments.Where(a => a.Id <= 0).ToList();
            this.AddRange(supplierMeasurementSubmission, attachmentsToAdd);

            if (supplierMeasurementSubmission.Id > 0)
            {
                // If attachment is not present in the incoming list then remove it
                var smsCommentAttachments = this.Find(ca => ca.SupplierMeasurementSubmissionId == supplierMeasurementSubmission.Id).ToList();
                var attachmentsToRemove = smsCommentAttachments.Where(ca => !attachments.Any(a => a.Id == ca.AttachmentId));
                this.RemoveRange(attachmentsToRemove);
            }
            return supplierMeasurementSubmission;
        }

        public void RemoveRange(int supplierMeasurementSubmissionId, IEnumerable<int> attachmentIds)
        {
            if (attachmentIds != null)
            {
                var attachmentsToRemove = this.Find(eca => eca.SupplierMeasurementSubmissionId == supplierMeasurementSubmissionId
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
