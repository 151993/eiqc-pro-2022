/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormLPosition entity model with Database table and bootstrap
    /// </summary>
    public class FormLPositionMapping : EntityTypeConfigurationWithUpdateUserAudit<FormLPosition,int>
    {
		/// <summary>
        /// Binds Database column FormLPositionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormLPosition> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormLPositionId");

			builder.Property(p => p.LineNo)
				.IsRequired()
				.HasMaxLength(20);
			builder.Property(p => p.ITCode)
				.IsRequired()
				.HasMaxLength(20);
			builder.Property(p => p.UOM)
				.IsRequired()
				.HasMaxLength(10);
			builder.Property(p => p.UpperLimit)
				.IsRequired();
			builder.Property(p => p.LowerLimit)
				.IsRequired();
			builder.Property(p => p.SampleSize)
				.HasMaxLength(20);
			builder.Property(p => p.ITCode1)
				.HasMaxLength(255);
			builder.Property(p => p.ITCode2)
				.HasMaxLength(255);
			builder.Property(p => p.ITCode3)
				.HasMaxLength(255);

			builder.HasOne(d => d.Form)
   .WithMany(p => p.FormLPosition)
   .HasForeignKey(d => d.FormId)
   .OnDelete(DeleteBehavior.Restrict)
   .HasConstraintName("FK_FormLPosition_FormId");

		}
    }
}
