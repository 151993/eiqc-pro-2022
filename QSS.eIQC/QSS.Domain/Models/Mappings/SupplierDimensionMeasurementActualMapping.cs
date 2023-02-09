/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map PartMicrosection entity model with Database table and bootstrap
    /// </summary>
    public class SupplierDimensionMeasurementActualMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierDimensionMeasurementActual, int>
    {
        /// <summary>
        /// Binds Database column PartMicrosectionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierDimensionMeasurementActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SupplierDimensionMeasurementActualId");

            builder.HasOne(d => d.SupplierDimensionMeasurement)
                .WithMany(d => d.SupplierDimensionMeasurementActuals)
                .HasForeignKey(d => d.SupplierDimensionMeasurementId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SupplierDimensionMeasurementAcutal_SupplierDimensionMeasurementId");


        }
    }
}
