/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map PartMicrosection entity model with Database table and bootstrap
    /// </summary>
    public class SupplierDimensionMeasurementMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierDimensionMeasurement, int>
    {
        /// <summary>
        /// Binds Database column PartMicrosectionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierDimensionMeasurement> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SupplierDimensionMeasurementId");

            builder.HasOne(d => d.SupplierMeasurementSubmission)
           .WithMany(p => p.SupplierDimensionMeasurements)
           .HasForeignKey(d => d.SupplierMeasurementSubmissionId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_SupplierDimensionMeasurement_SupplierMeasurementSubmissionId");

            builder.HasOne(d => d.ParameterManagement)
           .WithMany(p => p.SupplierDimensionMeasurements)
           .HasForeignKey(d => d.ParameterManagementId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_SupplierDimensionMeasurement_ParameterManagementId");

            builder.HasOne(d => d.InstrumentType)
           .WithMany(p => p.SupplierDimensionMeasurements)
           .HasForeignKey(d => d.InstrumentTypeId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_SupplierDimensionMeasurement_InstrumentTypeId");

           builder.HasOne(d => d.Instrument)
          .WithMany(p => p.SupplierDimensionMeasurements)
          .HasForeignKey(d => d.InstrumentId)
          .OnDelete(DeleteBehavior.Restrict)
          .HasConstraintName("FK_SupplierDimensionMeasurement_InstrumentId").IsRequired(false); 

            builder.HasOne(d => d.UOM)
           .WithMany(p => p.SupplierDimensionMeasurements)
           .HasForeignKey(d => d.UOMId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_SupplierDimensionMeasurement_UOMId");

            builder.HasOne(d => d.DataType)
           .WithMany(p => p.SupplierDimensionMeasurements)
           .HasForeignKey(d => d.DataTypeId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_SupplierDimensionMeasurement_DataTypeId");

            builder.HasOne(d => d.ChartType)
          .WithMany(p => p.SupplierDimensionMeasurementParameters)
          .HasForeignKey(d => d.ChartTypeId)
          .IsRequired(false)
          .OnDelete(DeleteBehavior.Restrict)
          .HasConstraintName("FK_SupplierMicrosection_ChartTypeId");



        }
    }
}
