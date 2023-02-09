/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map PartBowTwistParameter entity model with Database table and bootstrap
    /// </summary>
    public class PartInspectionBowTwistParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<PartInspectionBowTwistParameter, int>
    {
        /// <summary>
        /// Binds Database column PartBowTwistParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<PartInspectionBowTwistParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("PartBowTwistParameterId");

            builder.Property(p => p.Spec)
                .HasMaxLength(50);
            builder.Property(p => p.Length)
                .HasMaxLength(50);
            builder.Property(p => p.Width)
                .HasMaxLength(50);
            builder.Property(p => p.Unit)
                .HasMaxLength(50);
            builder.Property(p => p.UpperLimit)
                .HasMaxLength(50);

            builder
              .HasOne(d => d.SAPPartInspectionPlan)
             .WithMany(d => d.PartInspectionBowTwistParameters)
             .HasForeignKey(d => d.SAPPartInspectionPlanId)
             .OnDelete(DeleteBehavior.Cascade)
             .HasConstraintName("FK_PIBowTwist_SAPPartInspectionPlanId");

            builder
            .HasOne(d => d.BowTwistFormula)
            .WithMany(d => d.PartInspectionBowTwistParameters)
            .HasForeignKey(d => d.BowTwistFormulaId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_PIBowTwist_BowTwistFormulaId");

        }
    }
}
