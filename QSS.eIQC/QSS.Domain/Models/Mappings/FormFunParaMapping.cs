/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormFunPara entity model with Database table and bootstrap
    /// </summary>
    public class FormFunParaMapping : EntityTypeConfigurationWithUpdateUserAudit<FormFunPara,int>
    {
		/// <summary>
        /// Binds Database column FormFunParaId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormFunPara> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormFunParaId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.UOM)
				.HasMaxLength(10);
			builder.Property(p => p.SampleSize)
				.HasMaxLength(20);

            builder.HasOne(d => d.Form)
     .WithMany(p => p.FormFunPara)
     .HasForeignKey(d => d.FormId)
     .OnDelete(DeleteBehavior.Restrict)
     .HasConstraintName("FK_FormFunPara_FormId");
        }
    }
}
