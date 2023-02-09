/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map DispositionType entity model with Database table and bootstrap
    /// </summary>
    public class DispositionTypeMapping : EntityTypeConfigurationWithUpdateUserAudit<DispositionType,int>
    {
		/// <summary>
        /// Binds Database column DispositionTypeId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<DispositionType> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("DispositionTypeId");

			builder.Property(p => p.Description)
				.HasMaxLength(250);


        }
    }
}
