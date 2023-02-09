using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// 
    /// </summary>
    public class SAPPartInspectionPlanAdminCertificationMapping : EntityTypeConfigurationWithUpdateUserAudit<SAPPartInspectionPlanAdminCertification, int>
    {
        /// <summary>
        /// Binds Database column SAPPartInspectionPlanSamplingPlan with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SAPPartInspectionPlanAdminCertification> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SAPPartInspectionPlanAdminCertificationId");

            builder.HasOne(d => d.SAPPartInspectionPlan)
                .WithMany(p => p.SAPPartInspectionPlanAdminCertifications)
                .HasForeignKey(d => d.SAPPartInspectionPlanId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SP_SAPPartInspectionPlanId");

            builder.HasOne(d => d.AdminCertification)
                .WithMany(d => d.SAPPartInspectionPlanAdminCertifications)
                .HasForeignKey(d => d.AdminCertificationId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_SP_AdminCertificationId");

        }
    }
}
