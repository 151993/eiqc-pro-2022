using System;
using System.ComponentModel.DataAnnotations.Schema;
using QSS.Models;
using QSS.Common.Utilities.EntityFramework;

namespace QSS.eIQC.Domain
{
    public abstract class PersistentObjectWithUpdateAuditLog<T> : PersistentObjectWithUpdate<T>, IAuditedEntity, IAuditLogEntity where T : IComparable
    {
        [NotMapped]
        public AuditLog AuditLog { get; set; }
    }
   
  

}
