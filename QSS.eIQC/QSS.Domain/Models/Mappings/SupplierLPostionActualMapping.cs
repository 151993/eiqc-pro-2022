/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map SupplierLPositionActual entity model with Database table and bootstrap
    /// </summary>
    public class SupplierLPositionActualMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<SupplierLPositionActual, int>
    {
        /// <summary>
        /// Binds Database column SupplierLPositionActualId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierLPositionActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierLPositionActualId");

            builder.Property(p => p.ActualText)
                .HasMaxLength(256);
            builder.Property(p => p.ActualValue)
                .HasMaxLength(256);

            builder.HasOne(d => d.SupplierLPosition)
                .WithMany(d => d.SupplierLPositionActuals)
                .HasForeignKey(d => d.SupplierLPositionId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SupplierLPositionActual_SupplierLPositionId");
        }
    }
}
