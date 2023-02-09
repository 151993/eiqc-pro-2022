using QSS.eIQC.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
	/// <summary>
	/// Repository Interface for SystemConfiguration 
	/// </summary>
	public interface IAttachmentRepository
    {
	    /// <summary>
	    /// Get queryable object of Attachment
	    /// </summary>
	    /// <returns></returns>
	    IQueryable<Attachment> GetQueryable();

		Task<Attachment> AddAsync(Attachment attachment, string changeReason);

		List<Attachment> AddRange(List<Attachment> attachments);

		Task UpdateAsync(Attachment attachment, string changeReason);

		Task RemoveByIdAsync(int id, string changeReason);
	}
}
