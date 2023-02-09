/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// Buyer entity model to map database Buyer table 
    /// </summary>
    public class Buyer : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        [AuditLog]
        [Unique]
        public string Name { get; set; }
        [AuditLog]
        public string BuyerCode { get; set; }

        [AuditLog]
        public string BuyerMail { get; set; }

        [AuditLog]
        public bool IsValid { get; set; }
    }
}
