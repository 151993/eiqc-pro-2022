/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormCountParameter entity model with Database table and bootstrap
    /// </summary>
    public class FormCountParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<FormCountParameter,int>
    {
		/// <summary>
        /// Binds Database column FormCountParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormCountParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormCountParameterId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.Remark)
				.HasMaxLength(4000);
			builder.Property(p => p.InspectionDetails)
				.HasMaxLength(4000);

            builder.HasOne(d => d.Form)
        .WithMany(p => p.FormCountParameter)
        .HasForeignKey(d => d.FormId)
        .OnDelete(DeleteBehavior.Restrict)
        .HasConstraintName("FK_FormCountParameter_FormId");
        }
    }
}
