/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map Group entity model with Database table and bootstrap
    /// </summary>
    public class GroupMapping : EntityTypeConfigurationWithUpdateUserAudit<Group,int>
    {
		/// <summary>
        /// Binds Database column GroupId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<Group> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("GroupId");

			builder.Property(p => p.WareHouse)
				.HasMaxLength(250);
			builder.Property(p => p.UserName)
				.HasMaxLength(250);


        }
    }
}
