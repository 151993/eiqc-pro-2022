/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand;
using QSS.eIQC.Handlers.Commands.PartLPositionToleranceCommand;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand;
using QSS.eIQC.Handlers.Commands.PartDimensionCommand;
using QSS.eIQC.Handlers.Commands.UOMCommand;
using QSS.eIQC.Handlers.Commands.InstrumentCommand;
using QSS.eIQC.Handlers.Commands.InstrumentTypeCommand;
using QSS.eIQC.Handlers.Commands.SupplierLPositionActualCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierLPositionCommand
{
    /// <summary>
    /// Representation model for SupplierLPosition entity
    /// </summary>
    public class SupplierLPositionModel : BaseStausModel<int>
    {


        /// <summary>
        /// Get or set SupplierLPositionId property
        /// </summary>        
        public int SupplierLPositionId { get; set; }

        /// <summary>
        /// Get or set SupplierMeasurementSubmission property
        /// </summary>        
        public SupplierMeasurementSubmissionModel SupplierMeasurementSubmission { get; set; }



        /// <summary>
        /// Get or set SupplierMeasurementSubmissionId property
        /// </summary>        
        public int SupplierMeasurementSubmissionId { get; set; }

        /// <summary>
        /// Get or set PartLPositionTolerance property
        /// </summary>        
        public PartLPositionToleranceModel PartLPositionTolerance { get; set; }



        /// <summary>
        /// Get or set PartLPositionToleranceId property
        /// </summary>        
        public int? PartLPositionToleranceId { get; set; }

        /// <summary>
        /// Get or set ParameterManagement property
        /// </summary>        
        public ParameterManagementModel ParameterManagement { get; set; }



        /// <summary>
        /// Get or set ParameterManagementId property
        /// </summary>        
        public int? ParameterManagementId { get; set; }

        /// <summary>
        /// Get or set PartDimension property
        /// </summary>        
        public PartDimensionModel PartDimension { get; set; }



        /// <summary>
        /// Get or set PartDimensionId property
        /// </summary>        
        public int? PartDimensionId { get; set; }

        /// <summary>
        /// Get or set DimensionDefault property
        /// </summary>        
        //public DimensionDefaultModel DimensionDefault { get; set; }

        public virtual IEnumerable<SupplierLPositionActualModel> SupplierLPositionActuals { get; set; }

        /// <summary>
        /// Get or set DimensionDefaultId property
        /// </summary>        
        public int? DimensionDefaultId { get; set; }

        /// <summary>
        /// Get or set AssociatedDimensionDefault property
        /// </summary>        
       // public DimensionDefaultModel AssociatedDimensionDefault { get; set; }



        /// <summary>
        /// Get or set AssociatedDimensionDefaultId property
        /// </summary>        
        public int? AssociatedDimensionNumberId { get; set; }

        /// <summary>
        /// Get or set UOM property
        /// </summary>        
        public UOMModel UOM { get; set; }



        /// <summary>
        /// Get or set UOMId property
        /// </summary>        
        public int? UOMId { get; set; }

        /// <summary>
        /// Get or set Instrument property
        /// </summary>        
        public InstrumentModel Instrument { get; set; }



        /// <summary>
        /// Get or set InstrumentId property
        /// </summary>        
        public int? InstrumentId { get; set; }

        /// <summary>
        /// Get or set InstrumentType property
        /// </summary>        
        public InstrumentTypeModel InstrumentType { get; set; }



        /// <summary>
        /// Get or set InstrumentTypeId property
        /// </summary>        
        public int? InstrumentTypeId { get; set; }



        /// <summary>
        /// Get or set StatusTypeId property
        /// </summary>        
        public int StatusTypeId { get; set; }

    }
}
