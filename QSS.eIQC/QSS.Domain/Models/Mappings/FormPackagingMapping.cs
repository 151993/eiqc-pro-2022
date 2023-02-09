/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormPackaging entity model with Database table and bootstrap
    /// </summary>
    public class FormPackagingMapping : EntityTypeConfigurationWithUpdateUserAudit<FormPackaging,int>
    {
		/// <summary>
        /// Binds Database column FormPackagingId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormPackaging> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormPackagingId");

			builder.Property(p => p.ResultDesc)
				.HasMaxLength(50);

            builder.HasOne(d => d.Form)
.WithMany(p => p.FormPackaging)
.HasForeignKey(d => d.FormId)
.OnDelete(DeleteBehavior.Restrict)
.HasConstraintName("FK_FormPackaging_FormId");
        }
    }
}
