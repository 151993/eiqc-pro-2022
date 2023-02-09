/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map Part entity model with Database table and bootstrap
    /// </summary>
    public class PartMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<Part,int>
    {
		/// <summary>
        /// Binds Database column PartId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<Part> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("PartId");

			builder.HasIndex(p => p.PartNo)
				.HasName("UK_Part_PartNo")
				.IsUnique();



        }
    }
}
