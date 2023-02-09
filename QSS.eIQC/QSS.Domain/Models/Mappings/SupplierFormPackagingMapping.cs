/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormPackaging entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormPackagingMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormPackaging, int>
    {
		/// <summary>
        /// Binds Database column SupplierFormPackagingId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormPackaging> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormPackagingId");

			builder.Property(p => p.ResultDesc)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(p => p.Result)
				.IsRequired();

            builder.HasOne(d => d.SupplierForm)
        .WithMany(p => p.SupplierFormPackaging)
        .HasForeignKey(d => d.SupplierFormId)
        .OnDelete(DeleteBehavior.Restrict)
        .HasConstraintName("FK_SupplierFormPackaging_SupplierFormId");
        }
    }
}
