/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Handlers.Commands.CertificateTypeParameterCommand;
using QSS.eIQC.Handlers.Commands.DefectTypeCommand;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands
{
    /// <summary>
    /// Representation model for PartResultOrientedParameter entity
    /// </summary>
    public class SupplierSapBasedParameterModel : BaseStausModel<int>
    {
        public int SupplierSapBasedParameterId { get; set; }

        public int SupplierMeasurementSubmissionId { get; set; }

        public int CertificateTypeParameterId { get; set; }

        public int MatchId { get; set; }

        public string SapRequest { get; set; }

        public string PhysicalInspection { get; set; }

        public List<int> AddedDefectTypeIds { get; set; }

        public virtual SupplierMeasurementSubmissionModel SupplierMeasurementSubmission { get; set; }

        public virtual CertificateTypeParameterModel CertificateTypeParameter { get; set; }

        public virtual IEnumerable<DefectTypeModel> DefectTypes { get; set; }

    }
}
