using QSS.Models;

namespace QSS.eIQC.Domain
{
    public interface IAuditLogEntity
    {
        AuditLog AuditLog { get; set; }
    }
}
