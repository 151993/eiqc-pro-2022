/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormResultOrientedParameter entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormResultOrientedParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormResultOrientedParameter,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormResultOrientedParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormResultOrientedParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormResultOrientedParameterId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(250);
			builder.Property(p => p.ResultExpected)
				.IsRequired();
			builder.Property(p => p.ResultActual)
				.IsRequired();
			builder.Property(p => p.TestCondition)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.InspectionDetails)
				.IsRequired()
				.HasMaxLength(255);

            builder.HasOne(d => d.SupplierForm)
     .WithMany(p => p.SupplierFormResultOrientedParameter)
     .HasForeignKey(d => d.SupplierFormId)
     .OnDelete(DeleteBehavior.Restrict)
     .HasConstraintName("FK_SupplierFormResultOrientedParameter_SupplierFormId");
        }
    }
}
