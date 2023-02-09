/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormStatus entity model with Database table and bootstrap
    /// </summary>
    public class FormStatusMapping : EntityTypeConfigurationWithUpdateUserAudit<FormStatus,int>
    {
		/// <summary>
        /// Binds Database column FormStatusId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormStatus> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormStatusId");

			builder.Property(p => p.StatusID)
				.IsRequired()
				.HasMaxLength(20);
			builder.Property(p => p.UserName)
				.IsRequired()
				.HasMaxLength(20);
			builder.Property(p => p.LastTime)
				.IsRequired();

            builder.HasOne(d => d.Form)
.WithMany(p => p.FormStatus)
.HasForeignKey(d => d.FormId)
.OnDelete(DeleteBehavior.Restrict)
.HasConstraintName("FK_FormStatus_FormId");
        }
    }
}
