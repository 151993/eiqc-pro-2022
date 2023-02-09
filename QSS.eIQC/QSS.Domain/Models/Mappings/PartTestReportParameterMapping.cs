/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map PartTestReportParameter entity model with Database table and bootstrap
    /// </summary>
    public class PartTestReportParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<PartTestReportParameter,int>
    {
		/// <summary>
        /// Binds Database column PartTestReportParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<PartTestReportParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("PartTestReportParameterId");

        }
    }
}
