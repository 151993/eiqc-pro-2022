using System.ComponentModel;

namespace QSS.eIQC.Domain.Enums
{
    public enum EmailTemplateEnum : byte
    {
        [Description("User added")]
        User_Added = 1,
    }

    public enum EmailTemplateBaseEnum
    {
        [Description("#{DNS}#")]
        DNS,
    }
}