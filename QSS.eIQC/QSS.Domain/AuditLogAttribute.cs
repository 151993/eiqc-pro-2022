using System;

namespace QSS.eIQC.Domain
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AuditLogAttribute : Attribute
    {
        public AuditLogAttribute()
        {

        }

        public AuditLogAttribute(string displayName)
        {
            DisplayName = displayName;
        }

        public string DisplayName { get; set; }
        public string MappingField { get; set; }
        public string ValueField { get; set; }
    }
}
