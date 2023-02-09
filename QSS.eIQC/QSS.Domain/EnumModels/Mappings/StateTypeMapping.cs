using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Domain.EnumModels.Mappings
{
    public class StateTypeMapping : EntityTypeConfigurationEnum<StateTypeModel, StateType,int>
    {
        public override void Configure(EntityTypeBuilder<StateTypeModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("StateTypeId");

            builder.Property(d => d.IsEnabled).HasDefaultValue(StatusType.Active);
        }
    }
}
