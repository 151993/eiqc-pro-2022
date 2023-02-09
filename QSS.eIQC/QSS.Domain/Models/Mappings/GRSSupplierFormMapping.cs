/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map GRSSupplierForm entity model with Database table and bootstrap
    /// </summary>
    public class GRSSupplierFormMapping : EntityTypeConfigurationWithUpdateUserAudit<GRSSupplierForm,int>
    {
		/// <summary>
        /// Binds Database column GRSSupplierFormId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<GRSSupplierForm> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("GRSSupplierFormId");

			builder.Property(p => p.GRSNo)
				.HasMaxLength(255);
			builder.Property(p => p.SubmitUser)
				.HasMaxLength(255);
            builder.HasOne(d => d.SupplierForm)
      .WithMany(p => p.GRSSupplierForm)
      .HasForeignKey(d => d.SupplierFormId)
      .OnDelete(DeleteBehavior.Restrict)
      .HasConstraintName("FK_GRSSupplierForm_SupplierFormId");

        }
    }
}
