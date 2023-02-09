/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PartResultOrientedParameter entity model to map database PartResultOrientedParameter table 
    /// </summary>
    public class SupplierSapBasedParameter : PersistentObjectWithUpdate<int>
    {
        public SupplierSapBasedParameter()
        {
            SupplierSapBasedParameterDefectTypes = new HashSet<SupplierSapBasedParameterDefectType>();
        }

        public int SupplierMeasurementSubmissionId { get; set; }

        public int CertificateTypeParameterId { get; set; }

        public int MatchId { get; set; }

        public string SapRequest { get; set; }

        public string PhysicalInspection { get; set; }

        public virtual SupplierMeasurementSubmission SupplierMeasurementSubmission { get; set; }

        public virtual CertificateTypeParameter CertificateTypeParameter { get; set; }

        public virtual ICollection<SupplierSapBasedParameterDefectType> SupplierSapBasedParameterDefectTypes { get; set; }



    }
}
