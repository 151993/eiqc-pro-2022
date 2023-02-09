/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormBowTwistActual entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormBowTwistActualMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormBowTwistActual,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormBowTwistActualId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormBowTwistActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormBowTwistActualId");

			builder.Property(p => p.No)
				.IsRequired();
            builder.HasOne(d => d.SupplierForm)
               .WithMany(p => p.SupplierFormBowTwistActual)
               .HasForeignKey(d => d.SupplierFormId)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_SupplierFormBowTwistActual_SupplierFormId");
        }
    }
}
