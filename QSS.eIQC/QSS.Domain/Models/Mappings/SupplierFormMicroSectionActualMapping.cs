/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormMicroSectionActual entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormMicroSectionActualMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormMicroSectionActual,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormMicroSectionActualId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormMicroSectionActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormMicroSectionActualId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.No)
				.IsRequired();
			builder.Property(p => p.ValueActual)
				.IsRequired();
            builder.HasOne(d => d.SupplierForm)
          .WithMany(p => p.SupplierFormMicroSectionActual)
          .HasForeignKey(d => d.SupplierFormId)
          .OnDelete(DeleteBehavior.Restrict)
          .HasConstraintName("FK_SupplierFormMicroSectionActual_SupplierFormId");

        }
    }
}
