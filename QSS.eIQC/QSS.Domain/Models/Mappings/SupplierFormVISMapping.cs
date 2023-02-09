/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormVIS entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormVISMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormVIS,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormVISId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormVIS> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormVISId");

			builder.Property(p => p.AcceptanceQTY)
				.IsRequired();
			builder.Property(p => p.TotalFailedQTY)
				.IsRequired();

            builder.HasOne(d => d.SupplierForm)
.WithMany(p => p.SupplierFormVIS)
.HasForeignKey(d => d.SupplierFormId)
.OnDelete(DeleteBehavior.Restrict)
.HasConstraintName("FK_SupplierFormVIS_SupplierFormId");
        }
    }
}
