/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormTestReport entity model with Database table and bootstrap
    /// </summary>
    public class FormTestReportMapping : EntityTypeConfigurationWithUpdateUserAudit<FormTestReport,int>
    {
		/// <summary>
        /// Binds Database column FormTestReportId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormTestReport> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormTestReportId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.ResultExpected)
				.IsRequired();
			builder.Property(p => p.TestCondition)
				.HasMaxLength(200);

            builder.HasOne(d => d.Form)
.WithMany(p => p.FormTestReport)
.HasForeignKey(d => d.FormId)
.OnDelete(DeleteBehavior.Restrict)
.HasConstraintName("FK_FormTestReport_FormId");
        }
    }
}
