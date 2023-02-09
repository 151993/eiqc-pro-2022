/* Auto Generated Code By AutoCodeGen Jabil © 2019 */



namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// DCCConfiguration entity model to map database DCCConfiguration table 
    /// </summary>
    public class DCCConfiguration : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public DCCConfiguration()
        {
        }

        [AuditLog]
        [Unique]
        public string SiteNo { get; set; }

        [AuditLog]
        public string DeptCode { get; set; }

        [AuditLog]
        public string DocLevel { get; set; }

        [Unique]
        public int SiteId { get; set; }

        [AuditLog(DisplayName = "Site", ValueField = "Name", MappingField = "SiteId")]
        public virtual Site Site { get; set; }

    }
}
