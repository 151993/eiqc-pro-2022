using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Domain.EnumModels.Mappings
{
    public class PermissionTypeMapping : EntityTypeConfigurationEnum<PermissionTypeModel, PermissionType, int>
    {
        public override void Configure(EntityTypeBuilder<PermissionTypeModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("PermissionTypeId");
        }
    }
}
