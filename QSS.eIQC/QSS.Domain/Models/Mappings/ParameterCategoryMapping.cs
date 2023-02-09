/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map ParameterCategory entity model with Database table and bootstrap
    /// </summary>
    public class ParameterCategoryMapping : EntityTypeConfigurationWithUpdateUserAudit<ParameterCategory,int>
    {
		/// <summary>
        /// Binds Database column ParameterCategoryId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<ParameterCategory> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("ParameterCategoryId");

			builder.Property(p => p.Description)
				.HasMaxLength(250);


        }
    }
}
