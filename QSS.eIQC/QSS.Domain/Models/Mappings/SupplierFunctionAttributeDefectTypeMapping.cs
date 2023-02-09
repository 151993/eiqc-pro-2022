using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class SupplierFunctionAttributeDefectTypeMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFunctionAttributeDefectType, int>
    {
        /// <summary>
        /// Binds Database column UserRoleId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFunctionAttributeDefectType> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SupplierFunctionAttributeDefectTypeId");

            builder.HasOne(d => d.SupplierFunctionAttribute)
                .WithMany(d => d.SupplierFunctionAttributeDefectTypes)
                .HasForeignKey(d => d.SupplierFunctionAttributeId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SupplierFunctionAttributeDefectType_SupplierFunctionAttributeId");

            builder.HasOne(d => d.DefectType)
                .WithMany(d => d.SupplierFunctionAttributeDefectTypes)
                .HasForeignKey(d => d.DefectTypeId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_SupplierFunctionAttributeDefectType_DefectTypeId");
        }
    }
}
