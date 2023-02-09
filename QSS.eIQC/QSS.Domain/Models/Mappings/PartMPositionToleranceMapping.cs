/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map PartMPositionTolerance entity model with Database table and bootstrap
    /// </summary>
    public class PartMPositionToleranceMapping : EntityTypeConfigurationWithUpdateUserAudit<PartMPositionTolerance, int>
    {
        /// <summary>
        /// Binds Database column PartMPositionToleranceId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<PartMPositionTolerance> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("PartMPositionToleranceId");

            builder.HasOne(d => d.SAPPartInspectionPlan)
           .WithMany(p => p.PartMPositionTolerances)
           .HasForeignKey(d => d.SAPPartInspectionPlanId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_PartMPositionTolerance_SAPPartInspectionPlanId");

            builder.HasOne(d => d.PartDimension)
           .WithMany(p => p.PartMPositionTolerances)
           .HasForeignKey(d => d.PartDimensionId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_PartMPositionTolerance_PartDimensionId");

            builder.HasOne(d => d.ParameterManagement)
           .WithMany(p => p.PartMPositionTolerances)
           .HasForeignKey(d => d.ParameterManagementId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_PartMPositionTolerance_ParameterManagementId");

            builder.HasOne(d => d.InstrumentType)
           .WithMany(p => p.PartMPositionTolerances)
           .HasForeignKey(d => d.InstrumentTypeId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_PartMPositionTolerance_InstrumentTypeId");

            builder.HasOne(d => d.UOM)
           .WithMany(p => p.PartMPositionTolerances)
           .HasForeignKey(d => d.UOMId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_PartMPositionTolerance_UOMId");


        }
    }
}
