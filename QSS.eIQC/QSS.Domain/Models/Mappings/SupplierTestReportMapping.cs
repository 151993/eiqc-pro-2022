/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SupplierTestReport entity model with Database table and bootstrap
    /// </summary>
    public class SupplierTestReportMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierTestReport,int>
    {
		/// <summary>
        /// Binds Database column SupplierTestReportId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierTestReport> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierTestReportId");

            builder.Property(p => p.DefectTypeId).IsRequired(false);

            builder.Property(p => p.InspectionDetails).HasMaxLength(256);
        }
    }
}
