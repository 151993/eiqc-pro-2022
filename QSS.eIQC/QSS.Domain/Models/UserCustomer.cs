/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// UserCustomer entity model to map database UserCustomer table 
    /// </summary>
    public class UserCustomer : PersistentObjectWithUpdateAuditLogStatus<int>
    {

        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public virtual User User { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
