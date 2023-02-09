
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class InspectionToolsTypePcCodeMapping : EntityTypeConfigurationWithUpdateUserAudit<InspectionToolsTypePcCode, int>
    {
        /// <summary>
        /// Binds Database column InspectionToolsTypePcCode with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<InspectionToolsTypePcCode> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("InspectionToolsTypePcCodeId");

            builder.HasOne(d => d.InspectionToolsType)
                .WithMany(d => d.InspectionToolsTypePcCodes)
                .HasForeignKey(d => d.InspectionToolsTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_InspectionToolsTypePcCode_InspectionToolsTypeId");

            builder.HasOne(d => d.PCCode)
                .WithMany(d => d.InspectionToolsTypePcCodes)
                .HasForeignKey(d => d.PCCodeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_InspectionToolsTypePcCode_PCCodeId");
        }
    }
}
