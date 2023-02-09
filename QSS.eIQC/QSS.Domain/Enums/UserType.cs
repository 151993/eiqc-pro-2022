using System.ComponentModel;

namespace QSS.eIQC.Domain.Enums
{
    public enum UserType
    {
        [Description("Supplier")]
        Supplier = 1,

        [Description("Customer")]
        Customer = 2,

        [Description("User")]
        User = 3
    }
}
