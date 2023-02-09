/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormPartDateCode entity model with Database table and bootstrap
    /// </summary>
    public class FormPartDateCodeMapping : EntityTypeConfigurationWithUpdateUserAudit<FormPartDateCode,int>
    {
		/// <summary>
        /// Binds Database column FormPartDateCodeId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormPartDateCode> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormPartDateCodeId");

			builder.Property(p => p.Requirement)
				.HasMaxLength(255);
			builder.Property(p => p.SupplierDC)
				.HasMaxLength(255);
			builder.Property(p => p.MFGDate)
				.HasMaxLength(100);
			builder.Property(p => p.Result)
				.HasMaxLength(255);

            builder.HasOne(d => d.Form)
.WithMany(p => p.FormPartDateCode)
.HasForeignKey(d => d.FormId)
.OnDelete(DeleteBehavior.Restrict)
.HasConstraintName("FK_FormPartDateCode_FormId");
        }
    }
}
