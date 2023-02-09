using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Domain.EnumModels.Mappings
{

    public class ChartTypeMapping : EntityTypeConfigurationEnum<ChartTypeModel, ChartType, int>
    {
        public override void Configure(EntityTypeBuilder<ChartTypeModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("ChartTypeId");

            builder.Property(d => d.IsEnabled).HasDefaultValue(StatusType.Active);


        }
    }
}
