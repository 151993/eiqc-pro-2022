using QSS.eIQC.Domain;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers
{
    public class AuditLogDataModel
    {
        public virtual List<AuditLogModifiedField> ModifiedFields { get; set; }
    }
}
