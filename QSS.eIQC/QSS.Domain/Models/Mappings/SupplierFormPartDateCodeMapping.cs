/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormPartDateCode entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormPartDateCodeMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormPartDateCode, int>
    {
		/// <summary>
        /// Binds Database column SupplierFormPartDateCodeId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormPartDateCode> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormPartDateCodeId");

			builder.Property(p => p.Requirement)
				.IsRequired()
				.HasMaxLength(255);
			builder.Property(p => p.SupplierDC)
				.IsRequired()
				.HasMaxLength(255);
			builder.Property(p => p.MFGDate)
				.IsRequired()
				.HasMaxLength(100);
			builder.Property(p => p.Result)
				.IsRequired()
				.HasMaxLength(255);

            builder.HasOne(d => d.SupplierForm)
       .WithMany(p => p.SupplierFormPartDateCode)
       .HasForeignKey(d => d.SupplierFormId)
       .OnDelete(DeleteBehavior.Restrict)
       .HasConstraintName("FK_SupplierFormPartDateCode_SupplierFormId");
        }
    }
}
