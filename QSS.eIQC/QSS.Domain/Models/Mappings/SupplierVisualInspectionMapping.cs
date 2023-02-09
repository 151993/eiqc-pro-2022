/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map PartBowTwistParameter entity model with Database table and bootstrap
    /// </summary>
    public class SupplierVisualInspectionMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierVisualInspection, int>
    {
        /// <summary>
        /// Binds Database column PartBowTwistParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierVisualInspection> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierVisualInspectionId");


            builder.HasOne(d => d.SupplierMeasurementSubmission)
           .WithMany(p => p.SupplierVisualInspections)
           .HasForeignKey(d => d.SupplierMeasurementSubmissionId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_SupplierVisualInspection_SupplierMeasurementSubmissionId");

           builder.HasOne(d => d.PartCountParameter)
          .WithMany(p => p.SupplierVisualInspections)
          .HasForeignKey(d => d.PartCountParameterId)
          .OnDelete(DeleteBehavior.Cascade)
          .HasConstraintName("FK_SupplierVisualInspection_PartCountParameterId");

          builder.HasOne(d => d.ParameterManagement)
         .WithMany(p => p.SupplierVisualInspections)
         .HasForeignKey(d => d.ParameterManagementId)
         .OnDelete(DeleteBehavior.Restrict)
         .HasConstraintName("FK_SupplierVisualInspection_ParameterManagementId");

            builder.HasOne(d => d.InspectionToolsType)
     .WithMany(p => p.SupplierVisualInspections)
     .HasForeignKey(d => d.InspectionToolsTypeId)
     .IsRequired(false)
     .OnDelete(DeleteBehavior.Restrict)
     .HasConstraintName("FK_SupplierVisualInspection_InspectionToolsTypeId");


        }
    }
}
