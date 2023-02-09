using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class CommodityMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<Commodity, int>
    {
        public override void Configure(EntityTypeBuilder<Commodity> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("CommodityId");
            builder.Property(p => p.SAPCommodityId).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Description).HasMaxLength(150).IsRequired();
            builder.Property(p => p.AppearanceInspectionItem).HasMaxLength(256);
            builder.Property(p => p.FunctionTestItem).HasMaxLength(256);
            builder.Property(p => p.CommodityValidFrom).IsRequired();
            builder.Property(p => p.CommodityValidTo).IsRequired();

            builder.HasOne(d => d.CommodityCategory)
              .WithMany(p => p.Commodities)
              .HasForeignKey(d => d.CommodityCategoryId)
              .IsRequired(false)
              .OnDelete(DeleteBehavior.Restrict)
              .HasConstraintName("FK_Commodity_CommodityCategoryId");

            builder.HasOne(d => d.CommodityCategoryOption)
             .WithMany(p => p.Commodities)
             .HasForeignKey(d => d.CommodityCategoryOptionId)
             .IsRequired(false)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_Commodity_CommodityCategoryOptionId");
        }
    }
}
