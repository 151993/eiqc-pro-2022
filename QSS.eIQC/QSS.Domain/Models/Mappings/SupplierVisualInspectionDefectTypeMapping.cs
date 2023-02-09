using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class SupplierVisualInspectionDefectTypeMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierVisualInspectionDefectType, int>
    {
        /// <summary>
        /// Binds Database column UserRoleId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierVisualInspectionDefectType> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SupplierVisualInspectionDefectTypeId");

            builder.HasOne(d => d.SupplierVisualInspection)
                .WithMany(d => d.SupplierVisualInspectionDefectTypes)
                .HasForeignKey(d => d.SupplierVisualInspectionId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SupplierVisualInspectionDefectType_SupplierVisualInspectionId");

            builder.HasOne(d => d.DefectType)
                .WithMany(d => d.SupplierVisualInspectionDefectTypes)
                .HasForeignKey(d => d.DefectTypeId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_SupplierVisualInspectionDefectType_DefectTypeId");

        }
    }
}
