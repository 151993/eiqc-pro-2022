using System.ComponentModel;

namespace QSS.eIQC.Domain.Enums
{
    public enum WarPage
    {
        [Description("Bow L")]
        Bow_L = 1,

        [Description("Bow W")]
        Bow_W = 2,

        [Description("Twist")]
        Twist = 3,

        [Description("Specific Warpage L")]
        Specific_Warpage_L = 4,

        [Description("Specific Warpage W")]
        Specific_Warpage_W = 5,

        [Description("Specific Twist")]
        Specific_Twist = 6,

    }
}
