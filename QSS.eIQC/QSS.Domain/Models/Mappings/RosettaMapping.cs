/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map Rosetta entity model with Database table and bootstrap
    /// </summary>
    public class RosettaMapping : EntityTypeConfigurationWithUpdateUserAudit<Rosetta,int>
    {
		/// <summary>
        /// Binds Database column RosettaId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<Rosetta> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("RosettaId");

			builder.Property(p => p.EN_US)
				.HasMaxLength(250);
			builder.Property(p => p.ZH_CN)
				.HasMaxLength(150);


        }
    }
}
