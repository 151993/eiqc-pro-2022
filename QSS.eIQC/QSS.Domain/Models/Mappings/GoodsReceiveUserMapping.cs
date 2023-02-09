/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map GoodsReceiveUser entity model with Database table and bootstrap
    /// </summary>
    public class GoodsReceiveUserMapping : EntityTypeConfigurationWithUpdateUserAudit<GoodsReceiveUser,int>
    {
		/// <summary>
        /// Binds Database column GoodsReceiveUserId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<GoodsReceiveUser> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("GoodsReceiveUserId");

			builder.Property(p => p.WareHouse)
				.HasMaxLength(250);
			builder.Property(p => p.SAPUser)
				.HasMaxLength(250);
			builder.Property(p => p.UserName)
				.HasMaxLength(250);
			builder.Property(p => p.SupervisorMail)
				.HasMaxLength(250);
			builder.Property(p => p.LeaderMail)
				.HasMaxLength(250);


        }
    }
}
