/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map DimensionDefault entity model with Database table and bootstrap
    /// </summary>
    public class DimensionDefaultMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<DimensionDefault,int>
    {
		/// <summary>
        /// Binds Database column DimensionDefaultId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<DimensionDefault> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("DimensionDefaultId");

			builder.Property(p => p.DimensionName)
				.HasMaxLength(256);


        }
    }
}
