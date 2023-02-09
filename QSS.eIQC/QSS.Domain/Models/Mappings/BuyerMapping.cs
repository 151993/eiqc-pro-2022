/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map Buyer entity model with Database table and bootstrap
    /// </summary>
    public class BuyerMapping : EntityTypeConfigurationWithUpdateUserAudit<Buyer,int>
    {
		/// <summary>
        /// Binds Database column BuyerId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<Buyer> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("BuyerId");

			builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
			builder.Property(p => p.BuyerCode).IsRequired().HasMaxLength(100);
			builder.Property(p => p.BuyerMail).IsRequired().HasMaxLength(50);

        }
    }
}
