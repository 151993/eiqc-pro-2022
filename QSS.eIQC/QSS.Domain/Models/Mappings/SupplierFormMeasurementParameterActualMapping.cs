/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormMeasurementParameterActual entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormMeasurementParameterActualMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormMeasurementParameterActual,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormMeasurementParameterActualId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormMeasurementParameterActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormMeasurementParameterActualId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(200);

            builder.HasOne(d => d.SupplierForm)
            .WithMany(p => p.SupplierFormMeasurementParameterActual)
            .HasForeignKey(d => d.SupplierFormId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_SupplierFormMeasurementParameterActual_SupplierFormId");
        }
    }
}
