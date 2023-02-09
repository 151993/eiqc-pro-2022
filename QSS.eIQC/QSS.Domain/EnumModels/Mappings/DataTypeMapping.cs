using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.eIQC.Domain.Enums;
namespace QSS.eIQC.Domain.EnumModels.Mappings
{
    public class DataTypeMapping : EntityTypeConfigurationEnum<DataTypeModel, DataType, int>
    {
        public override void Configure(EntityTypeBuilder<DataTypeModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("DataTypeId");

            builder.Property(d => d.IsEnabled).HasDefaultValue(StatusType.Active);
        }
    }
}
