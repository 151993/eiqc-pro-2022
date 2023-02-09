

namespace QSS.eIQC.Domain.Models
{
    public class TestReportCommodity : PersistentObjectWithUpdate<int>
    {
        public int TestReportId { get; set; }
        public int CommodityId { get; set; }

        public virtual TestReport TestReport { get; set; }
        public virtual Commodity Commodity { get; set; }
    }
}
