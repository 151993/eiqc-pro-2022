using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Domain.EnumModels.Mappings
{
    public class StatusTypeMapping : EntityTypeConfigurationEnum<StatusTypeModel, StatusType,int>
    {
        public override void Configure(EntityTypeBuilder<StatusTypeModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("StatusTypeId");
           
        }
    }
}
