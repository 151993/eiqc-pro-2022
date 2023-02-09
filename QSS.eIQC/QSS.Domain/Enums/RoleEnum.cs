using System.ComponentModel;

namespace QSS.eIQC.Domain.Enums
{
    public enum RoleEnum
    {
        [Description("Global Admin")]
        Global_Admin = 1,

        [Description("Site SME")]
        Site_SME = 2,

        [Description("Jabil SQE")]
        Jabil_SQE = 3,

        [Description("Jabil IQC")]
        Jabil_IQC = 4,

        [Description("DCC")]
        DCC_User = 5,

        [Description("Supplier")]
        Supplier = 6,

        [Description("Jabil Default User")]
        Jabil_Default_User = 7,

        [Description("Customer")]
        Customer = 8,

    }
}
