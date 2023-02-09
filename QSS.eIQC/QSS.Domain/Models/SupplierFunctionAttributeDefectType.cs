

namespace QSS.eIQC.Domain.Models
{
    public class SupplierFunctionAttributeDefectType : PersistentObjectWithUpdate<int>
    {
        public int SupplierFunctionAttributeId { get; set; }

        public int DefectTypeId { get; set; }

        public virtual SupplierFunctionAttribute SupplierFunctionAttribute { get; set; }

        public virtual DefectType DefectType { get; set; }
    }
}
