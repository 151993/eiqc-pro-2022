/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿
using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// Customer entity model to map database Customer table 
    /// </summary>
    public class Customer : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Customer()
        {
            UserCustomers = new HashSet<UserCustomer>();
        }
        [AuditLog]
        [Unique]
        public string Name { get; set; }
        [AuditLog]
        public string CAFPath { get; set; }
        [AuditLog]
        public string DCCSavePath { get; set; }
        [AuditLog]
        public string CAFTempPath { get; set; }
        [AuditLog]
        public string BackupSavePath { get; set; }
        public virtual ICollection<UserCustomer> UserCustomers { get; set; }

    }
}
