/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormBowTwistParameter entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormBowTwistParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormBowTwistParameter,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormBowTwistParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormBowTwistParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormBowTwistParameterId");

			builder.Property(p => p.Spec)
				.HasMaxLength(255);
			builder.Property(p => p.Length)
				.HasMaxLength(53);
			builder.Property(p => p.Width)
				.HasMaxLength(53);
			builder.Property(p => p.Unit)
				.HasMaxLength(10);
			builder.Property(p => p.UpperLimit)
				.HasMaxLength(50);

            builder.HasOne(d => d.SupplierForm)
              .WithMany(p => p.SupplierFormBowTwistParameter)
              .HasForeignKey(d => d.SupplierFormId)
              .OnDelete(DeleteBehavior.Restrict)
              .HasConstraintName("FK_SupplierFormBowTwistParameter_SupplierFormId");


        }
    }
}
