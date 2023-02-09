/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map CommodityCategory entity model with Database table and bootstrap
    /// </summary>
    public class CommodityCategoryMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<CommodityCategory,int>
    {
		/// <summary>
        /// Binds Database column CommodityCategoryId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<CommodityCategory> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("CommodityCategoryId");

			builder.Property(p => p.Name)
				.IsRequired()
				.HasMaxLength(50);

            builder.HasOne(d => d.CommodityCategoryType)
            .WithMany(p => p.CommodityCategorys)
            .HasForeignKey(d => d.CommodityCategoryTypeId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_CommodityCategory_CommodityCategoryTypeId");

            builder.HasOne(d => d.CommodityCategoryOption)
           .WithMany(p => p.CommodityCategorys)
           .HasForeignKey(d => d.CommodityCategoryOptionId)
           .IsRequired(false)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_CommodityCategory_CommodityCategoryOptionId");
        }
    }
}
