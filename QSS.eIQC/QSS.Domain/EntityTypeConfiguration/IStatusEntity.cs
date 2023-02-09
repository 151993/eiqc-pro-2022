using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Domain
{
    public interface IStatusEntity
    {
        StatusType Status { get; set; }
    }
}
