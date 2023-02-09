using System.ComponentModel.DataAnnotations;

namespace QSS.eIQC.Handlers.Commands.SupplierSpcChartCommand
{
    public class SupplierSpcChartResultSummary
    {
        [Key]
        public int TabId { get; set; }

        public int RuleId { get; set; }

        public string TabType { get; set; }

        public bool MavericLotDetected { get; set; }

        public bool TabResult { get; set; }

        public double? UCL { get; set; }

        public double? LCL { get; set; }

        public double? Average { get; set; }

        public double? Cpk { get; set; }

        public int FailIndicator { get; set; }

        public int DataCountToDetectMavericLot { get; set; }

        public int ChartTypeId { get; set; }
    }
}
