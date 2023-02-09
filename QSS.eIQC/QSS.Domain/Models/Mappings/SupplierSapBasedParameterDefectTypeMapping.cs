using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class SupplierSapBasedParameterDefectTypeMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierSapBasedParameterDefectType, int>
    {
        /// <summary>
        /// Binds Database column UserRoleId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierSapBasedParameterDefectType> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SupplierSapBasedParameterDefectTypeId");

            builder.HasOne(d => d.SupplierSapBasedParameter)
                .WithMany(d => d.SupplierSapBasedParameterDefectTypes)
                .HasForeignKey(d => d.SupplierSapBasedParameterId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SupplierSapBasedParameterDefectType_SupplierSapBasedParameterId");

            builder.HasOne(d => d.DefectType)
                .WithMany(d => d.SupplierSapBasedParameterDefectTypes)
                .HasForeignKey(d => d.DefectTypeId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_SupplierSapBasedParameterDefectType_DefectTypeId");
        }
    }
}
