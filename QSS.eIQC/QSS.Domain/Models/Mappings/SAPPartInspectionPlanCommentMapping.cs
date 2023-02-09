/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SAPPartInspectionPlan entity model with Database table and bootstrap
    /// </summary>
    public class SAPPartInspectionPlanCommentMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<SAPPartInspectionPlanComment, int>
    {
		/// <summary>
        /// Binds Database column SAPPartInspectionPlanId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SAPPartInspectionPlanComment> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SAPPartInspectionPlanCommentId");

        }
    }
}
