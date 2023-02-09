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
    public class SupplierTestReportAttachmentRepository : BaseRepository<SupplierTestReportAttachment, int>, ISupplierTestReportAttachmentRepository
    {

        public SupplierTestReportAttachmentRepository(QSSContext context) :
       base(context, AuditLogType.Configuration)
        { }

        public async Task<SupplierTestReportAttachment> AddAsync(SupplierTestReportAttachment supplierTestReportAttachment, string supplierMeasurementSubmissionName, string changeReason)
        {
            return await AddAsync(supplierTestReportAttachment, Constants.AuditLog.Title.AddSupplierMeasurementSubmission(supplierMeasurementSubmissionName), changeReason);
        }

        public async Task UpdateAsync(SupplierTestReportAttachment supplierTestReportAttachment, string supplierMeasurementSubmissionName, string changeReason)
        {
            await UpdateAsync(supplierTestReportAttachment, Constants.AuditLog.Title.EditSupplierMeasurementSubmission(supplierMeasurementSubmissionName), changeReason);
        }

        public void AddRange(SupplierTestReport supplierTestReport, IEnumerable<Attachment> attachments)
        {
            foreach (var attachment in attachments)
            {
                supplierTestReport.SupplierTestReportAttachments.Add(new SupplierTestReportAttachment
                {
                    SupplierTestReport = supplierTestReport,
                    Attachment = attachment,
                    Status = StatusType.Active
                });
            }
        }

        public void AddRange(SupplierTestReport supplierTestReport, IEnumerable<SupplierTestReportAttachment> attachments)
        {
            foreach (var attachment in attachments)
            {
                supplierTestReport.SupplierTestReportAttachments.Add(new SupplierTestReportAttachment
                {
                    SupplierTestReport = supplierTestReport,
                    Attachment = attachment.Attachment,
                    Status = StatusType.Active
                });
            }
        }

        public async Task<SupplierTestReport> AddSupplierTestReportAttachments(SupplierTestReport supplierTestReport,
            IEnumerable<Attachment> attachments, string changeReason)
        {
            // If attachment is new then add it
            var attachmentsToAdd = attachments.Where(a => a.Id <= 0).ToList();
            this.AddRange(supplierTestReport, attachmentsToAdd);

            if (supplierTestReport.Id > 0)
            {
                // If attachment is not present in the incoming list then remove it
                var supplierMeasurementSubmissionAttachments = this.Find(ca => ca.SupplierTestReportId == supplierTestReport.Id).ToList();
                var attachmentsToRemove = supplierMeasurementSubmissionAttachments.Where(ca => !attachments.Any(a => a.Id == ca.AttachmentId));
                this.RemoveRange(attachmentsToRemove);
            }

            return supplierTestReport;
        }

        public void RemoveRange(int supplierTestReportId, IEnumerable<int> attachmentIds)
        {
            if (attachmentIds != null)
            {
                var attachmentsToRemove = this.Find(eca => eca.SupplierTestReportId == supplierTestReportId
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

            SetAuditLog(adminCertificate, Constants.AuditLog.Title.DeleteSupplierMeasurementSubmission(adminCertificateName), changeReason);

            Remove(adminCertificate);
        }
    }
}
