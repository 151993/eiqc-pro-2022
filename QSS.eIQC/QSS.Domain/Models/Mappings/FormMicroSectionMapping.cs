/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormMicroSection entity model with Database table and bootstrap
    /// </summary>
    public class FormMicroSectionMapping : EntityTypeConfigurationWithUpdateUserAudit<FormMicroSection,int>
    {
		/// <summary>
        /// Binds Database column FormMicroSectionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormMicroSection> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormMicroSectionId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.UOM)
				.HasMaxLength(10);
			builder.Property(p => p.SampleSize)
				.HasMaxLength(20);


            builder.HasOne(d => d.Form)
  .WithMany(p => p.FormMicroSection)
  .HasForeignKey(d => d.FormId)
  .OnDelete(DeleteBehavior.Restrict)
  .HasConstraintName("FK_FormMicroSection_FormId");
        }
    }
}
