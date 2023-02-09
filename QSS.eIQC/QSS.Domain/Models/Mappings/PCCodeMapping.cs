/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map PCCode entity model with Database table and bootstrap
    /// </summary>
    public class PCCodeMapping : EntityTypeConfigurationWithUpdateUserAudit<PCCode,int>
    {
		/// <summary>
        /// Binds Database column PCCodeId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<PCCode> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("PCCodeId");

            builder.HasIndex(p => p.Code)
                .HasName("UK_PCCode_Code")
                .IsUnique();

            builder.Property(p => p.Description)
                .HasMaxLength(255);


        }
    }
}
