using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Domain.EnumModels.Mappings
{

    public class ProductLifeCycleStageMapping : EntityTypeConfigurationEnum<ProductLifeCycleStageModel, ProductLifeCycleStage, int>
    {
        public override void Configure(EntityTypeBuilder<ProductLifeCycleStageModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("ProductLifeCycleStageId");

            builder.Property(d => d.IsEnabled).HasDefaultValue(StatusType.Active);


        }
    }
}
