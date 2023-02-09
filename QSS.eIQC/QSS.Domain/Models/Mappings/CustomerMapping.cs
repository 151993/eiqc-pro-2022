/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map Customer entity model with Database table and bootstrap
    /// </summary>
    public class CustomerMapping : EntityTypeConfigurationWithUpdateUserAudit<Customer,int>
    {
		/// <summary>
        /// Binds Database column CustomerId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("CustomerId");

			builder.Property(p => p.Name)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(p => p.CAFPath)
				.HasMaxLength(250);
			builder.Property(p => p.DCCSavePath)
				.HasMaxLength(250);
			builder.Property(p => p.CAFTempPath)
				.HasMaxLength(250);
			builder.Property(p => p.BackupSavePath)
				.HasMaxLength(250);


        }
    }
}
