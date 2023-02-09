/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormSpecialParameter entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormSpecialParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormSpecialParameter,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormSpecialParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormSpecialParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormSpecialParameterId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(250);
			builder.Property(p => p.ResultDesc)
				.IsRequired()
				.HasMaxLength(250);
			builder.Property(p => p.Result)
				.IsRequired();

            builder.HasOne(d => d.SupplierForm)
 .WithMany(p => p.SupplierFormSpecialParameter)
 .HasForeignKey(d => d.SupplierFormId)
 .OnDelete(DeleteBehavior.Restrict)
 .HasConstraintName("FK_SupplierFormSpecialParameter_SupplierFormId");
        }
    }
}
