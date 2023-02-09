/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormMicroSectionActual entity model with Database table and bootstrap
    /// </summary>
    public class FormMicroSectionActualMapping : EntityTypeConfigurationWithUpdateUserAudit<FormMicroSectionActual,int>
    {
		/// <summary>
        /// Binds Database column FormMicroSectionActualId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormMicroSectionActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormMicroSectionActualId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.No)
				.IsRequired();

            builder.HasOne(d => d.Form)
  .WithMany(p => p.FormMicroSectionActual)
  .HasForeignKey(d => d.FormId)
  .OnDelete(DeleteBehavior.Restrict)
  .HasConstraintName("FK_FormMicroSectionActual_FormId");
        }
    }
}
