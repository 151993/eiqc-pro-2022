using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using QSS.eIQC.Domain.Models;
using QSS.Common.Utilities.EntityFramework;


namespace QSS.eIQC.Domain
{
    public abstract class PersistentObjectWithUpdate<T> : PersistentObject<T>, IUserAuditEntity where T : IComparable
    {
        public DateTimeOffset Created { get; set; }
        public int CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public virtual User CreatedByUser { get; set; }
        [ConcurrencyCheck]
        public DateTimeOffset LastUpdated { get; set; }
        public int LastUpdatedBy { get; set; }
        [ForeignKey("LastUpdatedBy")]
        public virtual User LastUpdatedByUser { get; set; }
    }
}
