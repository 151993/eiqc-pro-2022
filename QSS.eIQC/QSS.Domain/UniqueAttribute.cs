using System;

namespace QSS.eIQC.Domain
{
    [AttributeUsage(AttributeTargets.Property)]
    public class UniqueAttribute : Attribute
    {
        public string DisplayName { get; set; }

        public UniqueAttribute()
        {

        }

        public UniqueAttribute(string displayName)
        {
            DisplayName = displayName;
        }        
        
    }
}
