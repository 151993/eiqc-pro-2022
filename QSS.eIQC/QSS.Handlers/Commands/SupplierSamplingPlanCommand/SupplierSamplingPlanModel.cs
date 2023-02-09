
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanSamplingPlanCommand;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierSamplingPlanCommand
{
    /// <summary>
    /// Representation model for SupplierSamplingPlan entity
    /// </summary>
    public class SupplierSamplingPlanModel : BaseStausModel<int>
    {

        /// <summary>
        /// Get or set SupplierSamplingPlanId property
        /// </summary>        
        public int SupplierSamplingPlanId { get; set; }

        /// <summary>
        /// Get or set SMSId property
        /// </summary>        
        public int SMSId { get; set; }

        /// <summary>
        /// Get or set PartInspectionSamplingPlanId property
        /// </summary>        
        public int PartInspectionSamplingPlanId { get; set; }

        /// <summary>
        /// Get or set SMS property
        /// </summary>        
        public SupplierMeasurementSubmissionModel SMS { get; set; }

        /// <summary>
        /// Get or set PartInspectionSamplingPlan property
        /// </summary>        
        public SAPPartInspectionPlanSamplingPlanModel PartInspectionSamplingPlan { get; set; }

        /// <summary>
        /// Get or set SampleSize property
        /// </summary>        
        public int SampleSize { get; set; }
        /// <summary>
        /// Get or set FailedQuantity property
        /// </summary>        
        public int FailedQuantity { get; set; }

    }
}
