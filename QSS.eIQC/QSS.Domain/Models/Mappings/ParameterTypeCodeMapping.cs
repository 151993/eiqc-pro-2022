/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map ParameterTypeCode entity model with Database table and bootstrap
    /// </summary>
    public class ParameterTypeCodeMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<ParameterTypeCode, int>
    {
		/// <summary>
        /// Binds Database column ParameterTypeCodeId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<ParameterTypeCode> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("ParameterTypeCodeId");

            builder.Property(p => p.Name)
                .HasMaxLength(50);

            builder.Property(p => p.Description)
				.HasMaxLength(255);


        }
    }
}
