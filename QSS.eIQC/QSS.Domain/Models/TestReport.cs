/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// TestReport entity model to map database TestReport table 
    /// </summary>
    public class TestReport : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public TestReport()
        {
            TestReportCommodities = new HashSet<TestReportCommodity>();
        }

        [AuditLog]
        [Unique]
        public string Name { get; set; }

        [AuditLog]
        public string Description { get; set; }

        [AuditLog(DisplayName = "Commodity", ValueField = "Commodity.Name")]
        public virtual ICollection<TestReportCommodity> TestReportCommodities { get; set; }
    }
}
