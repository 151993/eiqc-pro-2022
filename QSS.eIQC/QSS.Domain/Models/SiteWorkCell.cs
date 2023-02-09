

namespace QSS.eIQC.Domain.Models
{
    public class SiteWorkCell : PersistentObjectWithUpdate<int>
    {
        public int SiteId { get; set; }
        public int WorkCellId { get; set; }

        public virtual Site Site { get; set; }
        public virtual WorkCell WorkCell { get; set; }
    }
}
