/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierSamplingPlan entity model with Database table and bootstrap
    /// </summary>
    public class SupplierSamplingPlanMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<SupplierSamplingPlan,int>
    {
		/// <summary>
        /// Binds Database column SupplierSamplingPlanId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierSamplingPlan> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierSamplingPlanId");

			builder.Property(p => p.FailedQuantity)
				.IsRequired();


        }
    }
}
