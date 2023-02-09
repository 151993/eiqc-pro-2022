using QSS.eIQC.Domain.Models;
using QSS.Common.Utilities.EntityFramework;
namespace QSS.eIQC.Domain
{
    public interface IUserAuditEntity : IAuditedEntity
    {
        User CreatedByUser { get; set; }
        User LastUpdatedByUser { get; set; }
    }
}
