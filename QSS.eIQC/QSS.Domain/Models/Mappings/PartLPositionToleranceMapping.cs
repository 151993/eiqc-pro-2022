/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map PartLPositionTolerance entity model with Database table and bootstrap
    /// </summary>
    public class PartLPositionToleranceMapping : EntityTypeConfigurationWithUpdateUserAudit<PartLPositionTolerance, int>
    {
        /// <summary>
        /// Binds Database column PartLPositionToleranceId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<PartLPositionTolerance> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("PartLPositionToleranceId");

            builder.HasOne(d => d.SAPPartInspectionPlan)
          .WithMany(p => p.PartLPositionTolerances)
          .HasForeignKey(d => d.SAPPartInspectionPlanId)
          .OnDelete(DeleteBehavior.Cascade)
          .HasConstraintName("FK_PartLPositionTolerance_SAPPartInspectionPlanId");

            builder.HasOne(d => d.PartDimension)
           .WithMany(p => p.PartLPositionTolerances)
           .HasForeignKey(d => d.PartDimensionId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_PartLPositionTolerance_PartDimensionId");

            builder.HasOne(d => d.ParameterManagement)
           .WithMany(p => p.PartLPositionTolerances)
           .HasForeignKey(d => d.ParameterManagementId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_PartLPositionTolerance_ParameterManagementId");

            builder.HasOne(d => d.InstrumentType)
           .WithMany(p => p.PartLPositionTolerances)
           .HasForeignKey(d => d.InstrumentTypeId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_PartLPositionTolerance_InstrumentTypeId");

            builder.HasOne(d => d.UOM)
           .WithMany(p => p.PartLPositionTolerances)
           .HasForeignKey(d => d.UOMId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_PartLPositionTolerance_UOMId");


        }
    }
}
