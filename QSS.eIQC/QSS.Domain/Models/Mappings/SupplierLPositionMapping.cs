/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map SupplierLPosition entity model with Database table and bootstrap
    /// </summary>
    public class SupplierLPositionMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<SupplierLPosition, int>
    {
        /// <summary>
        /// Binds Database column SupplierLPositionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierLPosition> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierLPositionId");

            //builder.Property(p => p.SupplierMeasurementSubmissionId).IsRequired(false);
            builder.Property(p => p.PartLPositionToleranceId).IsRequired(false);
            builder.Property(p => p.ParameterManagementId).IsRequired(false);
            builder.Property(p => p.PartDimensionId).IsRequired(false);
            builder.Property(p => p.DimensionDefaultId).IsRequired(false);
            builder.Property(p => p.AssociatedDimensionNumberId).IsRequired(false);
            builder.Property(p => p.UOMId).IsRequired(false);
            builder.Property(p => p.InstrumentId).IsRequired(false);
            builder.Property(p => p.InstrumentTypeId).IsRequired(false);
            

            builder
              .HasOne(d => d.SupplierMeasurementSubmission)
             .WithMany(d => d.SupplierLPositions)
             .HasForeignKey(d => d.SupplierMeasurementSubmissionId)
             .OnDelete(DeleteBehavior.Cascade)
             .HasConstraintName("FK_SupplierLPosition_SupplierMeasurementSubmissionId");
        }
    }
}
