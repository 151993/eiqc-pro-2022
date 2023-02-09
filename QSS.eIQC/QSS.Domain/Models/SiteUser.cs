/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SiteUser entity model to map database SiteUser table 
    /// </summary>
    public class SiteUser : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public int SiteId { get; set; }
        public int UserId { get; set; }

        public virtual Site Site { get; set; }
        public virtual User User { get; set; }

    }
}
