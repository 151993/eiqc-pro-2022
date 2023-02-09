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
    public class AdminCertificationAttachmentRepository : BaseRepository<AdminCertificationAttachment, int>, IAdminCertificationAttachmentRepository
    {

        public AdminCertificationAttachmentRepository(QSSContext context) :
       base(context, AuditLogType.Configuration)
        { }

        public async Task<AdminCertificationAttachment> AddAsync(AdminCertificationAttachment adminCertificationAttachment, string adminCertificationName, string changeReason)
        {
            return await AddAsync(adminCertificationAttachment, Constants.AuditLog.Title.AddAdminCertification(adminCertificationName), changeReason);
        }

        public async Task UpdateAsync(AdminCertificationAttachment adminCertificationAttachment, string adminCertificationName, string changeReason)
        {
            await UpdateAsync(adminCertificationAttachment, Constants.AuditLog.Title.EditAdminCertification(adminCertificationName), changeReason);
        }

        public void AddRange(AdminCertification adminCertification, IEnumerable<Attachment> attachments)
        {
            foreach (var attachment in attachments)
            {
                adminCertification.AdminCertificationAttachments.Add(new AdminCertificationAttachment
                {
                    AdminCertification = adminCertification,
                    Attachment = attachment,
                    Status = StatusType.Active
                });
            }
        }

        public void AddRange(AdminCertification adminCertification, IEnumerable<AdminCertificationAttachment> attachments)
        {
            foreach (var attachment in attachments)
            {
                adminCertification.AdminCertificationAttachments.Add(new AdminCertificationAttachment
                {
                    AdminCertification = adminCertification,
                    Attachment = attachment.Attachment,
                    Status = StatusType.Active
                });
            }
        }

        public void AddAdminCertificationAttachments(AdminCertification adminCertification,
            IEnumerable<Attachment> attachments, string changeReason)
        {
            // If attachment is new then add it
            var attachmentsToAdd = attachments.Where(a => a.Id <= 0).ToList();
            this.AddRange(adminCertification, attachmentsToAdd);

            if (adminCertification.Id > 0)
            {
                // If attachment is not present in the incoming list then remove it
                var adminCertificationAttachments = this.Find(ca => ca.AdminCertificateId == adminCertification.Id).ToList();
                var attachmentsToRemove = adminCertificationAttachments.Where(ca => !attachments.Any(a => a.Id == ca.AttachmentId));
                this.RemoveRange(attachmentsToRemove);
            }
        }

        public void RemoveRange(int adminCertificateId, IEnumerable<int> attachmentIds)
        {
            if (attachmentIds != null)
            {
                var attachmentsToRemove = this.Find(eca => eca.AdminCertificateId == adminCertificateId
                    && attachmentIds.Contains(eca.AttachmentId));
                if (attachmentsToRemove != null && attachmentsToRemove.Count()>0)
                {
                    this.RemoveRange(attachmentsToRemove);
                }
            }
        }


        public async Task RemoveByIdAsync(int id, string adminCertificateName, string changeReason)
        {
            var adminCertificate = await ValidateExistsAndGetAsync(id);

            SetAuditLog(adminCertificate, Constants.AuditLog.Title.DeleteAdminCertification(adminCertificateName), changeReason);

            Remove(adminCertificate);
        }
    }
}
