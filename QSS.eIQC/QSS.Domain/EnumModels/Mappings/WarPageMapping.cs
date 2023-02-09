using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.eIQC.Domain.Enums;
namespace QSS.eIQC.Domain.EnumModels.Mappings
{
    public class WarPageMapping : EntityTypeConfigurationEnum<WarPageModel, WarPage, int>
    {
        public override void Configure(EntityTypeBuilder<WarPageModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("WarPageId");

            builder.Property(d => d.IsEnabled).HasDefaultValue(StatusType.Active);
        }
    }
}
