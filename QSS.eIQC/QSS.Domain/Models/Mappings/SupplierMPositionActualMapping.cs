/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierMPositionActual entity model with Database table and bootstrap
    /// </summary>
    public class SupplierMPositionActualMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<SupplierMPositionActual,int>
    {
		/// <summary>
        /// Binds Database column SupplierMPositionActualId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierMPositionActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierMPositionActualId");

			builder.Property(p => p.ActualText)
				.HasMaxLength(256);
			builder.Property(p => p.ActualValue)
				.HasMaxLength(256);


        }
    }
}
