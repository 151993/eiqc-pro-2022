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
    public interface ISMSCommentAttachmentRepository
    {
        Task<SMSCommentAttachment> AddAsync(SMSCommentAttachment smsCommentAttachment, string smsCommentName, string changeReason);

        Task UpdateAsync(SMSCommentAttachment smsCommentAttachment, string smsCommentName, string changeReason);

        Task RemoveByIdAsync(int id, string smsCommentName, string changeReason);

        void AddRange(SupplierMeasurementSubmission supplierMeasurementSubmission, IEnumerable<Attachment> attachments);

        void RemoveRange(int supplierMeasurementSubmissionId, IEnumerable<int> attachmentIds);

        Task<SupplierMeasurementSubmission> AddSMSCommentAttachments(SupplierMeasurementSubmission supplierMeasurementSubmission, IEnumerable<Attachment> attachments, string changeReason);

    }
}
