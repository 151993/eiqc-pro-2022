/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map GRS entity model with Database table and bootstrap
    /// </summary>
    public class GRSMapping : EntityTypeConfigurationWithUpdateUserAudit<GRS,int>
    {
		/// <summary>
        /// Binds Database column GRSId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<GRS> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("GRSId");

			builder.HasIndex(p => p.GRSNo)
				.HasName("UK_GRS")
				.IsUnique();

			builder.Property(p => p.GRSNo)
				.IsRequired()
				.HasMaxLength(20);
			builder.Property(p => p.PartNo)
				.IsRequired();
			
			builder.Property(p => p.MedialCode)
				.HasMaxLength(50);
			builder.Property(p => p.MPN)
				.HasMaxLength(50);
			builder.Property(p => p.MaterialName)
				.HasMaxLength(100);
			builder.Property(p => p.MFG)
				.HasMaxLength(50);
			builder.Property(p => p.LotNo)
				.HasMaxLength(50);
			builder.Property(p => p.InspectorName)
				.HasMaxLength(8000);
			builder.Property(p => p.InspectionResult)
				.HasMaxLength(8000);
			builder.Property(p => p.PO)
				.HasMaxLength(255);
			builder.Property(p => p.VendorCode)
				.HasMaxLength(255);
			builder.Property(p => p.MatlGroup)
				.HasMaxLength(255);
			builder.Property(p => p.VendorName1)
				.HasMaxLength(255);
			builder.Property(p => p.SkipIQC)
				.HasMaxLength(255);

			builder.HasOne(d => d.Part)
		.WithMany(p => p.GRS)
		.HasPrincipalKey(d=>d.PartNo)
		.HasForeignKey(d => d.PartNo)
		.OnDelete(DeleteBehavior.Restrict)
		.HasConstraintName("FK_GRS_PartNo");
		}
    }
}
