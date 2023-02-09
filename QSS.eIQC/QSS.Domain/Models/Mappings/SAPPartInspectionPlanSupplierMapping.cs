using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// 
    /// </summary>
    public class SAPPartInspectionPlanSupplierMapping : EntityTypeConfigurationWithUpdateUserAudit<SAPPartInspectionPlanSupplier, int>
    {
        /// <summary>
        /// Binds Database column RolePermissionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SAPPartInspectionPlanSupplier> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SAPPartInspectionPlanSupplierId");

            builder.HasOne(d => d.SAPPartInspectionPlan)
                .WithMany(p => p.SAPPartInspectionPlanSuppliers)
                .HasForeignKey(d => d.SAPPartInspectionPlanId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SAPPartInspectionPlan_SAPPartInspectionPlanSupplierId");
        }
    }
}
