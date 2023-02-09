using QSS.eIQC.Domain;
using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace QSS.Models
{
    public class AuditLog : PersistentObjectWithUpdate<long>
    {
        [Column("AuditLogTypeId")]
        public AuditLogType AuditLogType { get; set; }
        public string Title { get; set; }
        public string ChangeReason { get; set; }
        public virtual AuditData AuditData { get; set; }
    }
}
