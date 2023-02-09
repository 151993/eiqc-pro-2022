/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormResultOrientedParameter entity model with Database table and bootstrap
    /// </summary>
    public class FormResultOrientedParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<FormResultOrientedParameter,int>
    {
		/// <summary>
        /// Binds Database column FormResultOrientedParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormResultOrientedParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormResultOrientedParameterId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.ResultExpected)
				.IsRequired();
			builder.Property(p => p.TestCondition)
				.HasMaxLength(200);
			builder.Property(p => p.InspectionDetails)
				.HasMaxLength(255);




            builder.HasOne(d => d.Form)
.WithMany(p => p.FormResultOrientedParameter)
.HasForeignKey(d => d.FormId)
.OnDelete(DeleteBehavior.Restrict)
.HasConstraintName("FK_FormResultOrientedParameter_FormId");

        }
    }
}
