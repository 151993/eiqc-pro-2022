/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormSpecialParameter entity model with Database table and bootstrap
    /// </summary>
    public class FormSpecialParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<FormSpecialParameter,int>
    {
		/// <summary>
        /// Binds Database column FormSpecialParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormSpecialParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormSpecialParameterId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(250);
			builder.Property(p => p.ResultDesc)
				.HasMaxLength(250);

            builder.HasOne(d => d.Form)
.WithMany(p => p.FormSpecialParameter)
.HasForeignKey(d => d.FormId)
.OnDelete(DeleteBehavior.Restrict)
.HasConstraintName("FK_FormSpecialParameter_FormId");
        }
    }
}
