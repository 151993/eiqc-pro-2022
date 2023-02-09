using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class CommodityPartNumberSiteMapping : IEntityTypeConfiguration<CommodityPartNumberSite>
    {
        public void Configure(EntityTypeBuilder<CommodityPartNumberSite> builder)
        {
            // base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("CommodityPartNumberSiteId");
            builder.Property(p => p.CommodityId).IsRequired();
            builder.Property(p => p.PartNumber).HasMaxLength(100).IsRequired();
            builder.Property(p => p.SiteNo).HasMaxLength(50).IsRequired();

            builder.HasOne(d => d.Commodity)
              .WithMany(p => p.CommodityPartNumberSites)
              .HasForeignKey(d => d.CommodityId)
              .IsRequired(false)
              .OnDelete(DeleteBehavior.Restrict)
              .HasConstraintName("FK_Commodity_CommodityPartNumberSiteId");

        }
    }
}
