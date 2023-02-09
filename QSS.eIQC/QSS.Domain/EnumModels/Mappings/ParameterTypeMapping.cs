using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Domain.EnumModels.Mappings
{
    public class ParameterTypeMapping : EntityTypeConfigurationEnum<ParameterManagementTypeModel, ParameterManagementType, int>
    {
        public override void Configure(EntityTypeBuilder<ParameterManagementTypeModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("ParameterManagementTypeId");

            builder.Property(d => d.IsEnabled).HasDefaultValue(StatusType.Active);
        }
    }
}
