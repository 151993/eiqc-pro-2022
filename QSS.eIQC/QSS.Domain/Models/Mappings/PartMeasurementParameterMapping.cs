/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map PartMeasurementParameter entity model with Database table and bootstrap
    /// </summary>
    public class PartMeasurementParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<PartMeasurementParameter, int>
    {
        /// <summary>
        /// Binds Database column PartMeasurementParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<PartMeasurementParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("PartMeasurementParameterId");

            builder.HasOne(d => d.SAPPartInspectionPlan)
           .WithMany(p => p.PartMeasurementParameters)
           .HasForeignKey(d => d.SAPPartInspectionPlanId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_PartMeasurementParameter_SAPPartInspectionPlanId");

            builder.HasOne(d => d.ParameterManagement)
           .WithMany(p => p.PartMeasurementParameters)
           .HasForeignKey(d => d.ParameterManagementId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartMeasurementParameter_ParameterManagementId");

            builder.HasOne(d => d.InstrumentType)
           .WithMany(p => p.PartMeasurementParameters)
           .HasForeignKey(d => d.InstrumentTypeId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartMeasurementParameter_InstrumentTypeId");

            builder.HasOne(d => d.UOM)
           .WithMany(p => p.PartMeasurementParameters)
           .HasForeignKey(d => d.UOMId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartMeasurementParameter_UOMId");

            builder.HasOne(d => d.DataType)
           .WithMany(p => p.PartMeasurementParameters)
           .HasForeignKey(d => d.DataTypeId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartMeasurementParameter_DataTypeId");

            builder.HasOne(d => d.ChartType)
           .WithMany(p => p.PartMeasurementParameters)
           .HasForeignKey(d => d.ChartTypeId)
           .IsRequired(false)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartMeasurementParameters_ChartTypeId");

        }
    }
}
