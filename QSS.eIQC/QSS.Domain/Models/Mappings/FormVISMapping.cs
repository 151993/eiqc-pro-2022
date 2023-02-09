/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map FormVIS entity model with Database table and bootstrap
    /// </summary>
    public class FormVISMapping : EntityTypeConfigurationWithUpdateUserAudit<FormVIS,int>
    {
		/// <summary>
        /// Binds Database column FormVISId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<FormVIS> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("FormVISId");

            builder.HasOne(d => d.Form)
.WithMany(p => p.FormVIS)
.HasForeignKey(d => d.FormId)
.OnDelete(DeleteBehavior.Restrict)
.HasConstraintName("FK_FormVIS_FormId");

        }
    }
}
