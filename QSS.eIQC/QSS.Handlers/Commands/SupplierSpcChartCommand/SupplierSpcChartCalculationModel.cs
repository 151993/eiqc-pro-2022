/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using System;
using System.ComponentModel.DataAnnotations;

namespace QSS.eIQC.Handlers.Commands.SupplierSpcChartCommand
{
    /// <summary>
    /// Representation model for PartMicrosection entity
    /// </summary>
    public class SupplierSpcChartModel 
    {
        [Key]
        public int? ParameterId { get; set; }

        public int SupplierMeasurementSubmissionId { get; set; }

        public double? FinalTextValue { get; set; }

        public int? SAPPartInspectionPlanId { get; set; }

        public int? ChartTypeId { get; set; }

        public string ActualTextName { get; set; }

        public double? ActualTextValue { get; set; }

        public string SMSNo { get; set; }
      
        public string SMSState { get; set; }

        public string SMSNoState { get; set; }

        public int? SMSSize { get; set; }

        public double? RangeAverageFor25 { get; set; }

        public int? ActualValueIndex { get; set; }

        public int? TabId { get; set; }

        public double? UpperTolerance { get; set; }

        public double? LowerTolerance { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public int? Index { get; set; }

    }
}
