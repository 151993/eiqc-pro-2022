using System.ComponentModel;

namespace QSS.eIQC.Domain.Enums
{
    public enum StatusType : byte 
    {
        [Description("Active")]
        Active = 1,

        [Description("Inactive")]
        Inactive = 2
    }
}
