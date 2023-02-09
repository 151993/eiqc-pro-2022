/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map GRSSAPResult entity model with Database table and bootstrap
    /// </summary>
    public class GRSSAPResultMapping : EntityTypeConfigurationWithUpdateUserAudit<GRSSAPResult,int>
    {
		/// <summary>
        /// Binds Database column GRSSAPResultId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<GRSSAPResult> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("GRSSAPResultId");

			builder.Property(p => p.GRSNO)
				.HasMaxLength(250);
			builder.Property(p => p.ISOK)
				.HasMaxLength(250);
			builder.Property(p => p.Error)
				.HasMaxLength(250);
			builder.Property(p => p.NTID)
				.HasMaxLength(250);
			builder.Property(p => p.PayLoad)
				.HasMaxLength(250);


        }
    }
}
