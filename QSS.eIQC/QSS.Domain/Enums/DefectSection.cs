using System.ComponentModel;

namespace QSS.eIQC.Domain.Enums
{
    public enum DefectSection : byte
    {
        [Description("Visual Inspection")]
        Visual_Inspection = 1,

        [Description("Test Report")]
        Test_Report = 2,

        [Description("Function Attribute")]
        Function_Attribute = 3,

        [Description("Function Variable")]
        Function_Variable = 4,

        [Description("Dimension Measurement")]
        Dimension_Measurement = 5,

        [Description("Bow-Twist")]
        Bow_Twist = 6,

        [Description("Date Code")]
        Date_Code = 7,

        [Description("Spec with MMC")]
        Spec_with_MMC = 8,

        [Description("Spec with LMC")]
        Spec_with_LMC = 9,

        [Description("Microsection")]
        Microsection = 10,

        [Description("SAP BASED")]
        SAP_BASED = 11,



    }
}
