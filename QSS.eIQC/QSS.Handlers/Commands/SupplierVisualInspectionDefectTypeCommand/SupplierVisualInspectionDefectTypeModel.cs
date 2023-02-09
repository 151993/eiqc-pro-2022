using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierVisualInspectionDefectTypeCommand
{
    /// <summary>
    /// Representation model for SupplierVisualInspectionDefectType entity
    /// </summary>
    public class SupplierVisualInspectionDefectTypeModel : BaseStausModel<int>
    {
        /// <summary>
        ///  SupplierVisualInspectionDefectType
        /// </summary>
        public int SupplierVisualInspectionId { get; set; }

        public int DefectQty { get; set; }

        public int DefectTypeId { get; set; }
        public string DefectTypeName { get; set; }
        
    }
}
