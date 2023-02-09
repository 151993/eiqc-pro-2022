using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Domain.EnumModels.Mappings
{
    public class SMSPOStateTypeMapping : EntityTypeConfigurationEnum<SMSPOStateTypeModel, SMSPOStateType, int>
    {
        public override void Configure(EntityTypeBuilder<SMSPOStateTypeModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SMSPOStateTypeId");

            builder.Property(d => d.IsEnabled).HasDefaultValue(StatusType.Active);

        }
    }
}
