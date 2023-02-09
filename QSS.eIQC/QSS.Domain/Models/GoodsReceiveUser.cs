/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using QSS.eIQC.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// GoodsReceiveUser entity model to map database GoodsReceiveUser table 
    /// </summary>
    public class GoodsReceiveUser : PersistentObjectWithUpdateAuditLogStatus<int>
    {

        [AuditLog]
        public string WareHouse { get; set; }
        [AuditLog]
        public string SAPUser { get; set; }
        [AuditLog]
        public string UserName { get; set; }
        [AuditLog]
        public string SupervisorMail { get; set; }
        [AuditLog]
        public string LeaderMail { get; set; }
    }
}
