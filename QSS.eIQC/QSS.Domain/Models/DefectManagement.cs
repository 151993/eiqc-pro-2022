

using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    /// <summary>
    /// CertificateType entity model to map database CertificateType table 
    /// </summary>
    public class DefectManagement : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public DefectManagement()
        {
            DefectTypes = new HashSet<DefectType>();
           
        }
        [Unique(DisplayName ="Defect Section")]
        public int DefectSectionId { get; set; }

        [AuditLog(DisplayName = "DefectSection", ValueField = "Name", MappingField = "DefectSectionId")]
        public virtual DefectSectionModel DefectSection { get; set; }

        [AuditLog(DisplayName = "DefectTypes", ValueField = "DefectTypeName", MappingField = "DefectTypeName")]
        public virtual ICollection<DefectType> DefectTypes { get; set; }


    }
}
