/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormBowTwistParameter entity model with Database table and bootstrap
    /// </summary>
    public class FormBowTwistParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<FormBowTwistParameter,int>
    {
		/// <summary>
        /// Binds Database column FormBowTwistParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormBowTwistParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormBowTwistParameterId");

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

            builder.HasOne(d => d.Form)
         .WithMany(p => p.FormBowTwistParameter)
         .HasForeignKey(d => d.FormId)
         .OnDelete(DeleteBehavior.Restrict)
         .HasConstraintName("FK_FormBowTwistParameter_FormId");
        }
    }
}
