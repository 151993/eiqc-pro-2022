using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Domain.Models
{
    public class MaterialGroup : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        [AuditLog]        
        public string SiteName { get; set; }

        [AuditLog]
        [Unique]
        public string MaterialGroupName { get; set; }

        public bool Deleted { get; set; }

    }
}