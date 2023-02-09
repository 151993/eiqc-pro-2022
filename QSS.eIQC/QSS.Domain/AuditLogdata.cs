using System.Collections.Generic;

namespace QSS.eIQC.Domain
{
    public class AuditLogData
    {
        public virtual List<AuditLogModifiedField> ModifiedFields { get; set; }
    }
}
