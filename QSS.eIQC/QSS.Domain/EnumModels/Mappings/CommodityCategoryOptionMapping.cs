using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Domain.EnumModels.Mappings
{

    public class CommodityCategoryOptionMapping : EntityTypeConfigurationEnum<CommodityCategoryOptionModel, CommodityCategoryOption, int>
    {
        public override void Configure(EntityTypeBuilder<CommodityCategoryOptionModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("CommodityCategoryOptionId");

            builder.Property(d => d.IsEnabled).HasDefaultValue(StatusType.Active);


        }
    }
}
