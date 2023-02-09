/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map ParameterType entity model with Database table and bootstrap
    /// </summary>
    public class ParameterTypeMapping : EntityTypeConfigurationWithUpdateUserAudit<ParameterType,int>
    {
		/// <summary>
        /// Binds Database column ParameterTypeId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<ParameterType> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("ParameterTypeId");

			builder.Property(p => p.Code)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(p => p.Description)
				.HasMaxLength(250);
			builder.Property(p => p.ComparationMethodDescription)
				.HasMaxLength(250);


        }
    }
}
