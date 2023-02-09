/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormLPositionActual entity model with Database table and bootstrap
    /// </summary>
    public class FormLPositionActualMapping : EntityTypeConfigurationWithUpdateUserAudit<FormLPositionActual,int>
    {
		/// <summary>
        /// Binds Database column FormLPositionActualId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormLPositionActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormLPositionActualId");

			builder.Property(p => p.LineNo)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.No)
				.IsRequired();
			builder.Property(p => p.Result)
				.HasMaxLength(200);
			builder.Property(p => p.InstrumentID)
				.HasMaxLength(200);
			builder.Property(p => p.InstrumentID2)
				.HasMaxLength(200);
			builder.Property(p => p.InstrumentID1)
				.HasMaxLength(200);
			builder.Property(p => p.InstrumentID2)
				.HasMaxLength(200);
			builder.Property(p => p.InstrumentID3)
				.HasMaxLength(200);

			builder.HasOne(d => d.Form)
   .WithMany(p => p.FormLPositionActual)
   .HasForeignKey(d => d.FormId)
   .OnDelete(DeleteBehavior.Restrict)
   .HasConstraintName("FK_FormLPositionActual_FormId");
		}
    }
}
