using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Domain.EnumModels.Mappings
{
    public class SyncSAPDataTypeMapping : EntityTypeConfigurationEnum<SyncSAPDataTypeModel, SyncSAPDataType, int>
    {
        public override void Configure(EntityTypeBuilder<SyncSAPDataTypeModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SyncSAPDataTypeId");

        }
    }
}
