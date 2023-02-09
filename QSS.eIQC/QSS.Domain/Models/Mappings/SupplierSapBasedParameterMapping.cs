/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map PartResultOrientedParameter entity model with Database table and bootstrap
    /// </summary>
    public class SupplierSapBasedParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierSapBasedParameter, int>
    {
		/// <summary>
        /// Binds Database column PartResultOrientedParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierSapBasedParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SupplierSapBasedParameterId");

            builder.HasOne(d => d.SupplierMeasurementSubmission)
           .WithMany(p => p.SupplierSapBasedParameters)
           .HasForeignKey(d => d.SupplierMeasurementSubmissionId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_SupplierSapBasedParameter_SupplierMeasurementSubmissionId");

            builder.HasOne(d => d.CertificateTypeParameter)
          .WithMany(p => p.SupplierSapBasedParameters)
          .HasForeignKey(d => d.CertificateTypeParameterId)
          .OnDelete(DeleteBehavior.Restrict)
          .HasConstraintName("FK_SupplierSapBasedParameter_CertificateTypeParameterId");


        }
    }
}
