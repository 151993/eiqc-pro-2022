/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map PartMicrosection entity model with Database table and bootstrap
    /// </summary>
    public class PartMicrosectionMapping : EntityTypeConfigurationWithUpdateUserAudit<PartMicrosection, int>
    {
        /// <summary>
        /// Binds Database column PartMicrosectionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<PartMicrosection> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("PartMicrosectionId");

            builder.HasOne(d => d.SAPPartInspectionPlan)
           .WithMany(p => p.PartMicrosectionParameters)
           .HasForeignKey(d => d.SAPPartInspectionPlanId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_PartMicrosection_SAPPartInspectionPlanId");

            builder.HasOne(d => d.ParameterManagement)
           .WithMany(p => p.PartMicrosectionParameters)
           .HasForeignKey(d => d.ParameterManagementId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartMicrosection_ParameterManagementId");

            builder.HasOne(d => d.InstrumentType)
           .WithMany(p => p.PartMicrosectionParameters)
           .HasForeignKey(d => d.InstrumentTypeId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartMicrosection_InstrumentTypeId");

            builder.HasOne(d => d.UOM)
           .WithMany(p => p.PartMicrosectionParameters)
           .HasForeignKey(d => d.UOMId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartMicrosection_UOMId");

            builder.HasOne(d => d.DataType)
           .WithMany(p => p.PartMicrosectionParameters)
           .HasForeignKey(d => d.DataTypeId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartMicrosection_DataTypeId");

            builder.HasOne(d => d.ChartType)
           .WithMany(p => p.PartMicrosectionParameters)
           .HasForeignKey(d => d.ChartTypeId)
           .IsRequired(false)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartMicrosection_ChartTypeId");


        }
    }
}
