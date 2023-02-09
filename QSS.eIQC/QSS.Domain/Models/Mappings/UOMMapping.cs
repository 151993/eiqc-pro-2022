/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map UOM entity model with Database table and bootstrap
    /// </summary>
    public class UOMMapping : EntityTypeConfigurationWithUpdateUserAudit<UOM,int>
    {
		/// <summary>
        /// Binds Database column UOMId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<UOM> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("UOMId");

            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();

            builder.Property(p => p.Description)
				.HasMaxLength(250);


        }
    }
}
