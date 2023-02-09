/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map DCCConfiguration entity model with Database table and bootstrap
    /// </summary>
    public class DCCConfigurationMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<DCCConfiguration,int>
    {
		/// <summary>
        /// Binds Database column DCCConfigurationId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<DCCConfiguration> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("DCCConfigurationId");

			builder.Property(p => p.SiteNo)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(p => p.DeptCode)
				.HasMaxLength(50);
			builder.Property(p => p.DocLevel)
				.HasMaxLength(50);

            builder.HasOne(d => d.Site)
              .WithMany(p => p.DCCConfigurations)
              .HasForeignKey(d => d.SiteId)
              .OnDelete(DeleteBehavior.Restrict)
              .HasConstraintName("FK_DCCConfiguration_DCCConfigurationId");
        }
    }
}
