using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.eIQC.Domain.Enums;
namespace QSS.eIQC.Domain.EnumModels.Mappings
{
    public class UserTypeMapping : EntityTypeConfigurationEnum<UserTypeModel, UserType, int>
    {
        public override void Configure(EntityTypeBuilder<UserTypeModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("UserTypeId");

            builder.Property(d => d.IsEnabled).HasDefaultValue(StatusType.Active);
        }
    }
}
