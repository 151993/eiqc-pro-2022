/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormMPosition entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormMPositionMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormMPosition,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormMPositionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormMPosition> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormMPositionId");

			builder.Property(p => p.LineNo)
				.IsRequired()
				.HasMaxLength(20);
			builder.Property(p => p.ITCode)
				.IsRequired()
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
			builder.Property(p => p.ITCode1)
				.HasMaxLength(255);
			builder.Property(p => p.ITCode2)
				.HasMaxLength(255);
			builder.Property(p => p.ITCode3)
				.HasMaxLength(255);

			builder.HasOne(d => d.SupplierForm)
		.WithMany(p => p.SupplierFormMPosition)
		.HasForeignKey(d => d.SupplierFormId)
		.OnDelete(DeleteBehavior.Restrict)
		.HasConstraintName("FK_SupplierFormMPosition_SupplierFormId");
		}
    }
}
