/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormBowTwistActual entity model with Database table and bootstrap
    /// </summary>
    public class FormBowTwistActualMapping : EntityTypeConfigurationWithUpdateUserAudit<FormBowTwistActual,int>
    {
		/// <summary>
        /// Binds Database column FormBowTwistActualId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormBowTwistActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormBowTwistActualId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(250);
			builder.Property(p => p.SAPParameterExpected)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(p => p.SAPParameterActual)
				.IsRequired()
				.HasMaxLength(50);

            builder.HasOne(d => d.Form)
          .WithMany(p => p.FormBowTwistActual)
          .HasForeignKey(d => d.FormId)
          .OnDelete(DeleteBehavior.Restrict)
          .HasConstraintName("FK_FormBowTwistActual_FormId");


        }
    }
}
