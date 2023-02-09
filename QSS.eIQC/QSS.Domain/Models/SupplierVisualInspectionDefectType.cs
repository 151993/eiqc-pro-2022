

namespace QSS.eIQC.Domain.Models
{
    public class SupplierVisualInspectionDefectType : PersistentObjectWithUpdate<int>
    {
        public int SupplierVisualInspectionId { get; set; }

        public int DefectQty { get; set; }

        public int DefectTypeId { get; set; }

        public virtual DefectType DefectType { get; set; }

        public virtual SupplierVisualInspection SupplierVisualInspection { get; set; }




    }
}
