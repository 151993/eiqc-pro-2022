/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormFunParaActual entity model with Database table and bootstrap
    /// </summary>
    public class FormFunParaActualMapping : EntityTypeConfigurationWithUpdateUserAudit<FormFunParaActual,int>
    {
		/// <summary>
        /// Binds Database column FormFunParaActualId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormFunParaActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormFunParaActualId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.No)
				.IsRequired();

            builder.HasOne(d => d.Form)
       .WithMany(p => p.FormFunParaActual)
       .HasForeignKey(d => d.FormId)
       .OnDelete(DeleteBehavior.Restrict)
       .HasConstraintName("FK_FormFunParaActual_FormId");
        }
    }
}
