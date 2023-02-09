/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormSAPParameter entity model with Database table and bootstrap
    /// </summary>
    public class FormSAPParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<FormSAPParameter,int>
    {
		/// <summary>
        /// Binds Database column FormSAPParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormSAPParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormSAPParameterId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.SAPParameterExpected)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(p => p.SAPParameterActual)
				.HasMaxLength(50);

            builder.HasOne(d => d.Form)
.WithMany(p => p.FormSAPParameter)
.HasForeignKey(d => d.FormId)
.OnDelete(DeleteBehavior.Restrict)
.HasConstraintName("FK_FormSAPParameter_FormId");
        }
    }
}
