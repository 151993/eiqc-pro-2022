/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map Inspection entity model with Database table and bootstrap
    /// </summary>
    public class InspectionMapping : EntityTypeConfigurationWithUpdateUserAudit<Inspection,int>
    {
		/// <summary>
        /// Binds Database column InspectionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<Inspection> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("InspectionId");

			builder.Property(p => p.Inspector)
				.HasMaxLength(20);
			builder.Property(p => p.InspectionResult)
				.HasMaxLength(50);
			builder.Property(p => p.ReportFullName)
				.HasMaxLength(250);

            builder.HasOne(d => d.Form)
        .WithMany(p => p.Inspection)
        .HasForeignKey(d => d.FormId)
        .OnDelete(DeleteBehavior.Restrict)
        .HasConstraintName("FK_Inspection_FormId");
        }
    }
}
