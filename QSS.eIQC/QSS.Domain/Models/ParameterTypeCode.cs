
using QSS.eIQC.Domain.EnumModels;
using System.Collections.Generic;
using System.ComponentModel;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// ParameterTypeCode entity model to map database ParameterTypeCode table 
    /// </summary>
    public class ParameterTypeCode : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public ParameterTypeCode()
        {
            ParameterTypePcCodes = new HashSet<ParameterTypePcCode>();
        }

        public virtual ParameterManagementTypeModel ParameterManagementType { get; set; }

        [DisplayName("Parameter Type")]
        [AuditLog]
        public int ParameterManagementTypeId { get; set; }

        [AuditLog]
        [Unique]
        public string Name { get; set; }

        [AuditLog]
        public string Description { get; set; }

        public virtual ICollection<ParameterTypePcCode> ParameterTypePcCodes { get; set; }
    }
}
