/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map PartCAF entity model with Database table and bootstrap
    /// </summary>
    public class PartCAFMapping : EntityTypeConfigurationWithUpdateUserAudit<PartCAF,int>
    {
		/// <summary>
        /// Binds Database column PartCAFId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<PartCAF> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("PartCAFId");

			builder.Property(p => p.PartNo)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(p => p.Hyperlink)
				.HasMaxLength(250);


        }
    }
}
