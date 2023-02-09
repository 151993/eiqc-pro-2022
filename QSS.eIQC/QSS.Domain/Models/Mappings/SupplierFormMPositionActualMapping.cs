/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormMPositionActual entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormMPositionActualMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormMPositionActual,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormMPositionActualId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormMPositionActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormMPositionActualId");

			builder.Property(p => p.LineNo)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.No)
				.IsRequired();
			builder.Property(p => p.Result)
				.HasMaxLength(200);
			builder.Property(p => p.InstrumentID)
				.HasMaxLength(200);
			builder.Property(p => p.InstrumentID2)
				.HasMaxLength(200);
			builder.Property(p => p.InstrumentID1)
				.HasMaxLength(200);
			builder.Property(p => p.InstrumentID2)
				.HasMaxLength(200);
			builder.Property(p => p.InstrumentID3)
				.HasMaxLength(200);
			builder.HasOne(d => d.SupplierForm)
		.WithMany(p => p.SupplierFormMPositionActual)
		.HasForeignKey(d => d.SupplierFormId)
		.OnDelete(DeleteBehavior.Restrict)
		.HasConstraintName("FK_SupplierFormMPositionActual_SupplierFormId");

		}
    }
}
