
using QSS.eIQC.Domain.EnumModels;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// ParameterTypeCode entity model to map database ParameterTypeCode table 
    /// </summary>
    public class ParameterTypePcCode : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public ParameterTypePcCode()
        {
        }

        public int ParameterTypeCodeId { get; set; }       

        public virtual ParameterTypeCode ParameterTypeCode { get; set; }        

        public int PCCodeId { get; set; }

        public virtual PCCode PCCode { get; set; }


   }
}
