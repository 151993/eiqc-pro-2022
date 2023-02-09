

namespace QSS.eIQC.Domain.Models
{
    public class SiteDepartment : PersistentObjectWithUpdate<int>
    {
        public int SiteId { get; set; }
        public int DepartmentId { get; set; }

        public virtual Site Site { get; set; }
        public virtual Department Department { get; set; }
    }
}
