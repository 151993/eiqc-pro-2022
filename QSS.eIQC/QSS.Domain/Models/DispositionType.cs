

namespace QSS.eIQC.Domain.Models
{
    public class DispositionType : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        [AuditLog]
        public string Description { get; set; }
    }
}
