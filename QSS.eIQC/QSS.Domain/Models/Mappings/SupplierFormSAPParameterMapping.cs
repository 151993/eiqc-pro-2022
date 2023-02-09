/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierFormSAPParameter entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFormSAPParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFormSAPParameter,int>
    {
		/// <summary>
        /// Binds Database column SupplierFormSAPParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFormSAPParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierFormSAPParameterId");

			builder.Property(p => p.ParameterName)
				.IsRequired()
				.HasMaxLength(250);
			builder.Property(p => p.SAPParameterExpected)
				.IsRequired()
				.HasMaxLength(50);
			builder.Property(p => p.SAPParameterActual)
				.IsRequired()
				.HasMaxLength(50);

            builder.HasOne(d => d.SupplierForm)
   .WithMany(p => p.SupplierFormSAPParameter)
   .HasForeignKey(d => d.SupplierFormId)
   .OnDelete(DeleteBehavior.Restrict)
   .HasConstraintName("FK_SupplierFormSAPParameter_SupplierFormId");
        }
    }
}
