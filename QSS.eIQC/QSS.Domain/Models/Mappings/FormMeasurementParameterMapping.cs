/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormMeasurementParameter entity model with Database table and bootstrap
    /// </summary>
    public class FormMeasurementParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<FormMeasurementParameter,int>
    {
		/// <summary>
        /// Binds Database column FormMeasurementParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormMeasurementParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormMeasurementParameterId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.UOM)
				.IsRequired()
				.HasMaxLength(10);
			builder.Property(p => p.UpperLimit)
				.IsRequired();
			builder.Property(p => p.LowerLimit)
				.IsRequired();
			builder.Property(p => p.SampleSize)
				.HasMaxLength(20);

			builder.HasOne(d => d.Form)
  .WithMany(p => p.FormMeasurementParameter)
  .HasForeignKey(d => d.FormId)
  .OnDelete(DeleteBehavior.Restrict)
  .HasConstraintName("FK_FormMeasurementParameter_FormId");
		}
    }
}
