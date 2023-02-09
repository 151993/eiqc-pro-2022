using System;
using System.ComponentModel.DataAnnotations.Schema;
using QSS.eIQC.Domain.Enums;
using QSS.Models;

namespace QSS.eIQC.Domain
{
    public abstract class PersistentObjectWithUpdateAuditLogStatus<T> : PersistentObjectWithUpdateAuditLog<T>, IStatusEntity where T : IComparable
    {
        [AuditLog]
        [Column("StatusTypeId")]
        public StatusType Status { get; set; }
    }
}
