/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierForm entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierForm,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierForm> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormId");

			builder.Property(p => p.PONo)
				.IsRequired()
				.HasMaxLength(255);
			builder.Property(p => p.PartNo)
				.HasMaxLength(50);
			builder.Property(p => p.FileName)
				.IsRequired()
				.HasMaxLength(4000);
			builder.Property(p => p.DateCode)
				.HasMaxLength(200);
			builder.Property(p => p.ApproveUser)
				.IsRequired()
				.HasMaxLength(255);
			builder.Property(p => p.TotalQty)
				.IsRequired();
			builder.Property(p => p.SampleQty)
				.IsRequired();
			builder.Property(p => p.Inspector)
				.IsRequired()
				.HasMaxLength(255);
			builder.Property(p => p.Verify)
				.IsRequired()
				.HasMaxLength(255);
			builder.Property(p => p.ImportStatus)
				.IsRequired();
			builder.Property(p => p.ImportError)
				.IsRequired()
				.HasMaxLength(4000);
			builder.Property(p => p.MO)
				.IsRequired()
				.HasMaxLength(255);
			builder.Property(p => p.MovedPath)
				.IsRequired()
				.HasMaxLength(4000);

			

		}
    }
}
