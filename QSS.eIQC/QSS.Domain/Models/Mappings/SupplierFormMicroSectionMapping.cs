/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormMicroSection entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormMicroSectionMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormMicroSection,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormMicroSectionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormMicroSection> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormMicroSectionId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.InstrumentID)
				.HasMaxLength(20);
			builder.Property(p => p.ITCode)
				.HasMaxLength(20);
			builder.Property(p => p.UOM)
				.HasMaxLength(10);
			builder.Property(p => p.SampleSize)
				.HasMaxLength(20);

            builder.HasOne(d => d.SupplierForm)
          .WithMany(p => p.SupplierFormMicroSection)
          .HasForeignKey(d => d.SupplierFormId)
          .OnDelete(DeleteBehavior.Restrict)
          .HasConstraintName("FK_SupplierFormMicroSection_SupplierFormId");
        }
    }
}
