using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Domain.EnumModels.Mappings
{
    public class AuditLogTypeMapping : EntityTypeConfigurationEnum<AuditLogTypeModel, AuditLogType, int>
    {
        public override void Configure(EntityTypeBuilder<AuditLogTypeModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("AuditLogTypeId");
        }
    }
}
