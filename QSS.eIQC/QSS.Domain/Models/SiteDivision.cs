

namespace QSS.eIQC.Domain.Models
{
    public class SiteDivision : PersistentObjectWithUpdate<int>
    {
        public int? SiteId { get; set; }
        public int? DivisionId { get; set; }

        public virtual Site Site { get; set; }
        public virtual Division Division { get; set; }
    }
}
