using Microsoft.EntityFrameworkCore;
using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Repositories;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
	public class AttachmentRepository : BaseRepository<Attachment, int>, IAttachmentRepository
    {
        private readonly QSSContext _context;

        public AttachmentRepository(QSSContext context) : base(context, AuditLogType.Configuration)
        {
            _context = context;
        }

        public IQueryable<Attachment> GetQueryable()
        {
	        return _context.Attachment.AsQueryable();
        }

        public async Task<Attachment> AddAsync(Attachment attachment, string changeReason)
        {
            return await AddAsync(attachment, Constants.AuditLog.Title.AddAttachment(attachment.Name), changeReason);
        }

        public List<Attachment> AddRange(List<Attachment> attachments)
        {
	        base.AddRange(attachments);
	        return attachments;
        }

        public async Task UpdateAsync(Attachment attachment, string changeReason)
        {
            await UpdateAsync(attachment, Constants.AuditLog.Title.EditAttachment(attachment.Name), changeReason);
        }

        public async Task RemoveByIdAsync(int id, string changeReason)
        {
            var attachment = await ValidateExistsAndGetAsync(id);

            SetAuditLog(attachment, Constants.AuditLog.Title.DeleteAttachment(attachment.Name), changeReason);

            Remove(attachment);
        }
    }
}
