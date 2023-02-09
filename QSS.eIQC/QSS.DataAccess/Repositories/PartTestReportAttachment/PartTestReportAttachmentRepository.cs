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
    public class PartTestReportAttachmentRepository : BaseRepository<PartTestReportAttachment, int>, IPartTestReportAttachmentRepository
    {

        public PartTestReportAttachmentRepository(QSSContext context) :base(context, AuditLogType.Configuration)
        { }

        public async Task<PartTestReportAttachment> AddAsync(PartTestReportAttachment partTestReportAttachment, string testReportName, string changeReason)
        {
            return await AddAsync(partTestReportAttachment, Constants.AuditLog.Title.AddTestReport(testReportName), changeReason);
        }

        public async Task<PartTestReportAttachment> UpdateAsync(PartTestReportAttachment partTestReportAttachment, string testReportName, string changeReason)
        {
            return await UpdateAsync(partTestReportAttachment, Constants.AuditLog.Title.EditTestReport(testReportName), changeReason);
        }

        public void AddRange(PartTestReportParameter partTestReportParameter, IEnumerable<Attachment> attachments)
        {
            foreach (var attachment in attachments)
            {
                partTestReportParameter.PartTestReportAttachments.Add(new PartTestReportAttachment
                {                    
                    PartTestReportParameter = partTestReportParameter,
                    Attachment = attachment,
                    Status = StatusType.Active
                });
            }
        }

        public void AddRange(PartTestReportParameter partTestReportParameter, IEnumerable<PartTestReportAttachment> attachments)
        {
            foreach (var attachment in attachments)
            {
                partTestReportParameter.PartTestReportAttachments.Add(new PartTestReportAttachment
                {
                    PartTestReportParameter = partTestReportParameter,
                    Attachment = attachment.Attachment,
                    Status = StatusType.Active
                });
            }
        }

        public async Task<PartTestReportParameter> AddPartTestReportAttachments(PartTestReportParameter partTestReportParameter,
            IEnumerable<Attachment> attachments, string changeReason)
        {
            // If attachment is new then add it
            var attachmentsToAdd = attachments.Where(a => a.Id <= 0).ToList();
            this.AddRange(partTestReportParameter, attachmentsToAdd);

            if (partTestReportParameter.Id > 0)
            {
                // If attachment is not present in the incoming list then remove it
                var partTestReportAttachments = this.Find(ca => ca.PartTestReportParameterId == partTestReportParameter.Id).ToList();
                var attachmentsToRemove = partTestReportAttachments.Where(ca => !attachments.Any(a => a.Id == ca.AttachmentId));
                this.RemoveRange(attachmentsToRemove);
            }
            return partTestReportParameter;
        }

        public void RemoveRange(int testReportId, IEnumerable<int> attachmentIds)
        {
            if (attachmentIds != null)
            {
                var attachmentsToRemove = this.Find(eca => eca.PartTestReportParameterId == testReportId
                    && attachmentIds.Contains(eca.AttachmentId));
                if (attachmentsToRemove != null && attachmentsToRemove.Count() > 0)
                {
                    this.RemoveRange(attachmentsToRemove);
                }
            }
        }


        public async Task<bool> RemoveByIdAsync(int id, string name, string changeReason)
        {
            var testReport = await ValidateExistsAndGetAsync(id);

            SetAuditLog(testReport, Constants.AuditLog.Title.DeleteTestReport(name), changeReason);

            return Remove(testReport);
        }
    }
}
