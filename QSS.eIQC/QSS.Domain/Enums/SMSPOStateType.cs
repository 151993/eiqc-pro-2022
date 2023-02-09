using System.ComponentModel;

namespace QSS.eIQC.Domain.Enums
{
    public enum SMSPOStateType : byte
    {
        [Description("Pending")]
        Pending = 1,

        [Description("Complete")]
        Complete = 2,

    }
}
