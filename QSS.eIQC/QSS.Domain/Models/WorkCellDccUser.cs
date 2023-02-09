

namespace QSS.eIQC.Domain.Models
{
    public class WorkCellDccUser : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public int WorkCellUserId { get; set; }

        public int UserId { get; set; }

        public virtual WorkCellUser WorkCellUser { get; set; }

        public virtual User User { get; set; }
    }
}
