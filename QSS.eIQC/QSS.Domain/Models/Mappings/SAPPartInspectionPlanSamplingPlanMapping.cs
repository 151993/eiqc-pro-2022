using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// 
    /// </summary>
    public class SAPPartInspectionPlanSamplingPlanMapping : EntityTypeConfigurationWithUpdateUserAudit<SAPPartInspectionPlanSamplingPlan, int>
    {
        /// <summary>
        /// Binds Database column SAPPartInspectionPlanSamplingPlan with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SAPPartInspectionPlanSamplingPlan> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SAPPartInspectionPlanSamplingPlanId");

            builder.HasOne(d => d.SAPPartInspectionPlan)
                .WithMany(p => p.SAPPartInspectionPlanSamplingPlans)
                .HasForeignKey(d => d.SAPPartInspectionPlanId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SAPPartInspectionPlanSamplingPlan_SAPPartInspectionPlanSamplingPlanId");
        }
    }
}
