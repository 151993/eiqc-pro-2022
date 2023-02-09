using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Domain.Models
{
    public class WorkCellJabilUser : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public int WorkCellUserId { get; set; }

        public int UserId { get; set; }

        public virtual WorkCellUser WorkCellUser { get; set; }

        public virtual User User { get; set; }
    }
}
