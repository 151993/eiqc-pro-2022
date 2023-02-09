/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierMPosition entity model with Database table and bootstrap
    /// </summary>
    public class SupplierMPositionMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<SupplierMPosition,int>
    {
		/// <summary>
        /// Binds Database column SupplierMPositionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierMPosition> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierMPositionId");

            //builder.Property(p => p.SupplierMeasurementSubmissionId).IsRequired(false);
            builder.Property(p => p.PartMPositionToleranceId).IsRequired(false);
            builder.Property(p => p.ParameterManagementId).IsRequired(false);
            builder.Property(p => p.PartDimensionId).IsRequired(false);
            builder.Property(p => p.DimensionDefaultId).IsRequired(false);
            builder.Property(p => p.AssociatedDimensionNumberId).IsRequired(false);
            builder.Property(p => p.UOMId).IsRequired(false);
            builder.Property(p => p.InstrumentId).IsRequired(false);
            builder.Property(p => p.InstrumentTypeId).IsRequired(false);
        }
    }
}
