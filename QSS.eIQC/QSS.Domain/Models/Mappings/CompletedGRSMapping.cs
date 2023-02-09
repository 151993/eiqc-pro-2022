/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map CompletedGRS entity model with Database table and bootstrap
    /// </summary>
    public class CompletedGRSMapping : EntityTypeConfigurationWithUpdateUserAudit<CompletedGRS,int>
    {
		/// <summary>
        /// Binds Database column CompletedGRSId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<CompletedGRS> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("CompletedGRSId");

			builder.Property(p => p.PartNo).HasMaxLength(255);
			builder.Property(p => p.UDCode).HasMaxLength(255);
			builder.Property(p => p.GRSNo).HasMaxLength(255);


        }
    }
}
