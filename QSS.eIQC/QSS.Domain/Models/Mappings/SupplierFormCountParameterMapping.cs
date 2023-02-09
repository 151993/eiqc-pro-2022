/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormCountParameter entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormCountParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormCountParameter,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormCountParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormCountParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormCountParameterId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(200);
			builder.Property(p => p.Remark)
				.HasMaxLength(200);
			builder.Property(p => p.InspectionDetails)
				.HasMaxLength(255);

            builder.HasOne(d => d.SupplierForm)
              .WithMany(p => p.SupplierFormCountParameter)
              .HasForeignKey(d => d.SupplierFormId)
              .OnDelete(DeleteBehavior.Restrict)
              .HasConstraintName("FK_SupplierFormCountParameter_SupplierFormId");

        }
    }
}
