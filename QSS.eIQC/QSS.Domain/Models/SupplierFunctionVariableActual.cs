/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// PartMicrosection entity model to map database PartMicrosection table 
    /// </summary>
    public class SupplierFunctionVariableActual : PersistentObjectWithUpdate<int>
    {
        public SupplierFunctionVariableActual()
        {
        }
        public int SupplierFunctionVariableId { get; set; }

        public virtual SupplierFunctionVariable SupplierFunctionVariable { get; set; }

        public string ActualTextName { get; set; }

        public string ActualTextValue { get; set; }

    }
}
