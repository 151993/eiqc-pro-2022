/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map PartBowTwistParameter entity model with Database table and bootstrap
    /// </summary>
    public class SupplierBowTwistMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierBowTwist, int>
    {
        /// <summary>
        /// Binds Database column PartBowTwistParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierBowTwist> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierBowTwistId");

            builder
              .HasOne(d => d.SupplierMeasurementSubmission)
             .WithMany(d => d.SupplierBowTwists)
             .HasForeignKey(d => d.SupplierMeasurementSubmissionId)
             .OnDelete(DeleteBehavior.Cascade)
             .HasConstraintName("FK_SupplierBowTwist_SupplierMeasurementSubmissionId");

            builder
            .HasOne(d => d.PartInspectionBowTwistParameter)
            .WithMany(d => d.SupplierBowTwists)
            .HasForeignKey(d => d.PartBowTwistParameterId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_SupplierBowTwist_PartBowTwistParameterId");

        }
    }
}
