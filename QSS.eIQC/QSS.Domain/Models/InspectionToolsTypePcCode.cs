
namespace QSS.eIQC.Domain.Models
{
    public class InspectionToolsTypePcCode : PersistentObjectWithUpdate<int>
    {
        public int InspectionToolsTypeId { get; set; }
        public int PCCodeId { get; set; }

        public virtual InspectionToolsType InspectionToolsType { get; set; }
        public virtual PCCode PCCode { get; set; }
    }
}
