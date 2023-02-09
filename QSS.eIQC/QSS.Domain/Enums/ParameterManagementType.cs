using System.ComponentModel;
namespace QSS.eIQC.Domain.Enums
{
    public enum ParameterManagementType : byte
    {
        [Description("Visual Inspection")]
        VisualInspection = 1,

        [Description("Function-Attribute")]
        FunctionAttribute = 2,

        [Description("Dimensional Measurements")]
        DimensionalMeasurements = 3,

        [Description("Text-Prepared")]
        TextPrepared = 4,

        [Description("Function-Variable")]
        FunctionVariable = 5,

        [Description("MicroSection")]
        MicroSection = 6,

        [Description("Bow & Twist")]
        BowAndTwist = 7,

        [Description("Date Code")]
        DateCode = 8,

        [Description("Spec With MMC")]
        SpecWithMMC = 9,

        [Description("Spec With LMC")]
        SpecWithLMC = 10,
    }
}
