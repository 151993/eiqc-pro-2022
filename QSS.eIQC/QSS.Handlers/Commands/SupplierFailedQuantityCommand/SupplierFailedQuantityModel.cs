

using System.ComponentModel.DataAnnotations;

namespace QSS.eIQC.Handlers.Commands.SupplierFailedQuantityCommand
{
    public class SupplierFailedQuantityModel 
    {
        [Key]
        public int MasterInspectionTypeId { get; set; }
        public string FieldName { get; set; }
        public int FailedQuantityCount { get; set; }
        public int TabId { get; set; }
        public bool IsFail { get; set; }
        public int FailIndicator { get; set; }
    }
}
