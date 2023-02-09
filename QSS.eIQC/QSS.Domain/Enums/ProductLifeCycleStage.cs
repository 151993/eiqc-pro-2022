

using System.ComponentModel;

namespace QSS.eIQC.Domain.Enums
{
    public enum ProductLifeCycleStage
    {
        [Description("Prototype")]
        Prototype = 1,

        [Description("NPI")]
        NPI = 2,

        [Description("Product Part Qualification")]
        Product_Part_Qualification = 3,

        [Description("Production Ramp Up")]
        Production_Ramp_Up = 4,

        [Description("Mass Production")]
        Mass_Production = 5,

        [Description("Product_Phase_Out")]
        Product_Phase_Out = 6,

        [Description("Other")]
        Other = 7
    }
}
