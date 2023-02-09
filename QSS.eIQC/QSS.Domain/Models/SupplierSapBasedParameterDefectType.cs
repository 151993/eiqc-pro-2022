

namespace QSS.eIQC.Domain.Models
{
    public class SupplierSapBasedParameterDefectType : PersistentObjectWithUpdate<int>
    {
        public int SupplierSapBasedParameterId { get; set; }

        public int DefectTypeId { get; set; }

        public virtual SupplierSapBasedParameter SupplierSapBasedParameter { get; set; }

        public virtual DefectType DefectType { get; set; }
    }
}
