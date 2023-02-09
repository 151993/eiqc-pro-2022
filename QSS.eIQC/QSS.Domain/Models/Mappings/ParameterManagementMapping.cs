/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map ParameterManagement entity model with Database table and bootstrap
    /// </summary>
    public class ParameterManagementMapping : EntityTypeConfigurationWithUpdateUserAudit<ParameterManagement, int>
    {
		/// <summary>
        /// Binds Database column ParameterManagementId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<ParameterManagement> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("ParameterManagementId");

			builder.Property(p => p.Name)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(p => p.Description)
				.HasMaxLength(150);
            builder.Property(p => p.ParameterTypeCodeId)
                .IsRequired();

        }
    }
}
