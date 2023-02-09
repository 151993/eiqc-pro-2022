using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Domain.EnumModels.Mappings
{
    public class DefectSectionMapping : EntityTypeConfigurationEnum<DefectSectionModel, DefectSection, int>
    {
        public override void Configure(EntityTypeBuilder<DefectSectionModel> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("DefectSectionId");

            builder.Property(d => d.IsEnabled).HasDefaultValue(StatusType.Active);

        }
    }
}
