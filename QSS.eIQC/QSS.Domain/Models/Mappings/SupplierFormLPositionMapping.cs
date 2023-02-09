/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormLPosition entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormLPositionMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormLPosition,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormLPositionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormLPosition> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormLPositionId");

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
			.WithMany(p => p.SupplierFormLPosition)
			.HasForeignKey(d => d.SupplierFormId)
			.OnDelete(DeleteBehavior.Restrict)
			.HasConstraintName("FK_SupplierFormLPosition_SupplierFormId");
		}
    }
}
