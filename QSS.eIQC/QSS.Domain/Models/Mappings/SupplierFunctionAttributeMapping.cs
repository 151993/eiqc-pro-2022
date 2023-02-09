/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map PartResultOrientedParameter entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFunctionAttributeMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFunctionAttribute, int>
    {
		/// <summary>
        /// Binds Database column PartResultOrientedParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFunctionAttribute> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SupplierFunctionAttributeId");

            builder.HasOne(d => d.SupplierMeasurementSubmission)
           .WithMany(p => p.SupplierFunctionAttributes)
           .HasForeignKey(d => d.SupplierMeasurementSubmissionId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_SupplierFunctionAttribute_SupplierMeasurementSubmissionId");

            builder.HasOne(d => d.ParameterManagement)
          .WithMany(p => p.SupplierFunctionAttributes)
          .HasForeignKey(d => d.ParameterManagementId)
          .OnDelete(DeleteBehavior.Restrict)
          .HasConstraintName("FK_SupplierFunctionAttribute_ParameterManagementId");


        }
    }
}
