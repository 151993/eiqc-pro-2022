/* Auto Generated Code By AutoCodeGen Jabil © 2019 */



namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// SupplierMicroSectionActual entity model to map database SupplierMicroSectionActual table 
    /// </summary>
    public class SupplierFunctionAttributeActual : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public SupplierFunctionAttributeActual()
        {
        }
        public virtual SupplierFunctionAttribute SupplierFunctionAttribute { get; set; }
        public int SupplierFunctionAttributeId { get; set; }
        public string ActualTextName { get; set; }
        public string ActualTextValue { get; set; }
    }
}
