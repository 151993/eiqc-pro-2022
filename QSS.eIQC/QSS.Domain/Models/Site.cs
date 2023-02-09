/* Auto Generated Code By AutoCodeGen Jabil © 2019 */



using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// Site entity model to map database Site table 
    /// </summary>
    public class Site : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Site()
        {
            SiteDivisions = new HashSet<SiteDivision>();
            SiteUsers = new HashSet<SiteUser>();
            DCCConfigurations = new HashSet<DCCConfiguration>();
            Users = new HashSet<User>();
            WorkCellSites = new HashSet<WorkCellSite>();
        }
        [AuditLog]
        [Unique]
        public string Name { get; set; }

        [AuditLog]
        [Unique]
        public string Code { get; set; }

        [AuditLog]
        public string Description { get; set; }

        public int? LocationId { get; set; }


        public virtual Location Location { get; set; }

        public virtual ICollection<SiteDivision> SiteDivisions { get; set; }

        public virtual ICollection<SiteUser> SiteUsers { get; set; }

        public virtual ICollection<DCCConfiguration> DCCConfigurations { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public virtual ICollection<WorkCellSite> WorkCellSites { get; set; }
    }
}
