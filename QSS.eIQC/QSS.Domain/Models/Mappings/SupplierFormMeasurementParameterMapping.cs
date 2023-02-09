/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormMeasurementParameter entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormMeasurementParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormMeasurementParameter,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormMeasurementParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormMeasurementParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormMeasurementParameterId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.InstrumentID)
				.HasMaxLength(20);
			builder.Property(p => p.UOM)
				.IsRequired()
				.HasMaxLength(10);
			builder.Property(p => p.UpperLimit)
				.IsRequired();
			builder.Property(p => p.LowerLimit)
				.IsRequired();
			builder.Property(p => p.SampleSize)
				.HasMaxLength(20);

            builder.HasOne(d => d.SupplierForm)
           .WithMany(p => p.SupplierFormMeasurementParameter)
           .HasForeignKey(d => d.SupplierFormId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_SupplierFormMeasurementParameter_SupplierFormId");
        }
    }
}
