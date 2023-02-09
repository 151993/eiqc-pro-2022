using QSS.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.eIQC.Domain.Models
{
	/// <summary>
	/// EmailTemplate entity model to map database EmailTemplate table 
	/// </summary>
	public class EmailTemplate : PersistentObjectWithUpdate<int>, IAuditLogEntity
	{
		/// <summary>
		/// Get or set Name property
		/// </summary>
		[AuditLog]
		[Unique]
		public string Name { get; set; }
		/// <summary>
		/// Get or set Subject property
		/// </summary>
		[AuditLog]
		public string Subject { get; set; }
		/// <summary>
		/// Get or set Body property
		/// </summary>
		[AuditLog]
		public string Body { get; set; }

		[NotMapped]
		public AuditLog AuditLog { get; set; }
	}
}