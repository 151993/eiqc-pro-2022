using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.eIQC.Domain.Enums;
namespace QSS.eIQC.Domain.EnumModels.Mappings
{
    public class RoleEnumMapping : EntityTypeConfigurationEnum<RoleEnumModel, RoleEnum, int>
    {
        public override void Configure(EntityTypeBuilder<RoleEnumModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("RoleEnumId");

            builder.Property(d => d.IsEnabled).HasDefaultValue(StatusType.Active);
        }
    }
}
