using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Domain.EnumModels.Mappings
{
    public class SyncTM1DataTypeMapping : EntityTypeConfigurationEnum<SyncTM1DataTypeModel, SyncTM1DataType, int>
    {
        public override void Configure(EntityTypeBuilder<SyncTM1DataTypeModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SyncTM1DataTypeId");

        }
    }
}
