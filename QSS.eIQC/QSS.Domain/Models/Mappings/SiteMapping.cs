/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map Site entity model with Database table and bootstrap
    /// </summary>
    public class SiteMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<Site,int>
    {
		/// <summary>
        /// Binds Database column SiteId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<Site> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SiteId");

            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();

            builder.Property(p => p.Description).HasMaxLength(250);

            builder.HasOne(d => d.Location)
              .WithMany(p => p.Site)
              .HasForeignKey(d => d.LocationId)
              .IsRequired(false)
              .OnDelete(DeleteBehavior.Restrict)
              .HasConstraintName("FK_Site_LocationId");
        }
    }
}
