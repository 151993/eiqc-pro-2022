/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map ReceiveGoodsInfoManual entity model with Database table and bootstrap
    /// </summary>
    public class ReceiveGoodsInfoManualMapping : EntityTypeConfigurationWithUpdateUserAudit<ReceiveGoodsInfoManual,int>
    {
		/// <summary>
        /// Binds Database column ReceiveGoodsInfoManualId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<ReceiveGoodsInfoManual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("ReceiveGoodsInfoManualId");

			builder.Property(p => p.Plant)
				.HasMaxLength(250);
			builder.Property(p => p.MatlGroup)
				.HasMaxLength(250);
			builder.Property(p => p.Material)
				.HasMaxLength(250);
			builder.Property(p => p.ReceivedDateTime)
				.IsRequired();
			builder.Property(p => p.ReceivedDateTime).HasDefaultValueSql("((CURRENT_TIMESTAMP))");

			builder.Property(p => p.MocDoc)
				.HasMaxLength(250);
			builder.Property(p => p.StorLoc)
				.HasMaxLength(250);
			builder.Property(p => p.Batch)
				.HasMaxLength(250);
			builder.Property(p => p.Vendor)
				.HasMaxLength(250);
			builder.Property(p => p.User)
				.HasMaxLength(250);
			builder.Property(p => p.SpecStock)
				.HasMaxLength(250);
			builder.Property(p => p.Reference)
				.HasMaxLength(250);


        }
    }
}
