/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map PartDimension entity model with Database table and bootstrap
    /// </summary>
    public class PartDimensionMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<PartDimension,int>
    {
		/// <summary>
        /// Binds Database column PartDimensionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<PartDimension> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("PartDimensionId");

			builder.Property(p => p.Name)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(p => p.Description)
				.HasMaxLength(250);


        }
    }
}
