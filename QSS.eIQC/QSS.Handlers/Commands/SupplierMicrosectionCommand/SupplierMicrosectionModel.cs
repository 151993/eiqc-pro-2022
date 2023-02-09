/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Handlers.Commands.InstrumentCommand;
using QSS.eIQC.Handlers.Commands.InstrumentTypeCommand;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand;
using QSS.eIQC.Handlers.Commands.UOMCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierMicrosectionCommand
{
    /// <summary>
    /// Representation model for PartMicrosection entity
    /// </summary>
    public class SupplierMicrosectionModel : BaseStausModel<int>
    {
        public int SupplierMicrosectionId { get; set; }

        public double? NormalValue { get; set; }

        public double? UpperTolerance { get; set; }

        public double? LowerTolerance { get; set; }

        public int? Accuracy { get; set; }

        public int SupplierMeasurementSubmissionId { get; set; }

        public int ParameterManagementId { get; set; }

        public int UOMId { get; set; }

        public int InstrumentTypeId { get; set; }

        public int? InstrumentId { get; set; }

        public int DataTypeId { get; set; }

        public virtual ParameterManagementModel ParameterManagement { get; set; }

        public virtual UOMModel UOM { get; set; }

        public virtual InstrumentTypeModel InstrumentType { get; set; }

        public virtual InstrumentModel Instrument { get; set; }

        public virtual DataTypeModel DataType { get; set; }

        public virtual IEnumerable<SupplierMicroSectionActualModel> SupplierMicroSectionActuals { get; set; }

        public int? ChartTypeId { get; set; }

        public virtual ChartTypeModel ChartType { get; set; }

    }
}
