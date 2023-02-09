using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Domain.EnumModels.Mappings
{

    public class CommodityCategoryTypeMapping : EntityTypeConfigurationEnum<CommodityCategoryTypeModel, CommodityCategoryType, int>
    {
        public override void Configure(EntityTypeBuilder<CommodityCategoryTypeModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("CommodityCategoryTypeId");

            builder.Property(d => d.IsEnabled).HasDefaultValue(StatusType.Active);


        }
    }
}
