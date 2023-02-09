using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    /// <summary>
    /// Repository Interface for User 
    /// </summary>
    public interface ISupplierTestReportAttachmentRepository
    {
        Task<SupplierTestReportAttachment> AddAsync(SupplierTestReportAttachment supplierTestReportAttachment, string supplierMeasurementSubmissionName, string changeReason);

        Task UpdateAsync(SupplierTestReportAttachment supplierTestReportAttachment, string supplierMeasurementSubmissionName, string changeReason);

        Task RemoveByIdAsync(int id, string supplierMeasurementSubmissionName, string changeReason);

        void AddRange(SupplierTestReport supplierTestReport, IEnumerable<Attachment> attachments);

        void RemoveRange(int supplierTestReportId, IEnumerable<int> attachmentIds);

        Task<SupplierTestReport> AddSupplierTestReportAttachments(SupplierTestReport supplierTestReport, IEnumerable<Attachment> attachments, string changeReason);

    }
}
