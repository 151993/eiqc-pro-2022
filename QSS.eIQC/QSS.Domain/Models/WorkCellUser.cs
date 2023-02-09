/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// MaterialGroupUser entity model to map database MaterialGroupUser table 
    /// </summary>
    public class WorkCellUser : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public WorkCellUser()
        {
            WorkCellJabilUsers = new HashSet<WorkCellJabilUser>();
            WorkCellDccUsers = new HashSet<WorkCellDccUser>();
        }

        public bool? IsDccApproval { get; set; }

        public int WorkCellId { get; set; }

        public int SiteId { get; set; }
        
        [AuditLog(DisplayName = "WorkCell", ValueField = "Name", MappingField = "WorkCellId")]
        public virtual WorkCell WorkCell { get; set; }

        [AuditLog(DisplayName = "Site", ValueField = "Name", MappingField = "SiteId")]
        public virtual Site Site { get; set; }
 
        public virtual ICollection<WorkCellJabilUser> WorkCellJabilUsers { get; set; }

        public virtual ICollection<WorkCellDccUser> WorkCellDccUsers { get; set; }
    }
}
