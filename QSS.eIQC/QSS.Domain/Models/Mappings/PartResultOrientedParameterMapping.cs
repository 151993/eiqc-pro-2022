/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map PartResultOrientedParameter entity model with Database table and bootstrap
    /// </summary>
    public class PartResultOrientedParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<PartResultOrientedParameter,int>
    {
		/// <summary>
        /// Binds Database column PartResultOrientedParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<PartResultOrientedParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("PartResultOrientedParameterId");

            builder.HasOne(d => d.SAPPartInspectionPlan)
           .WithMany(p => p.PartResultOrientedParameters)
           .HasForeignKey(d => d.SAPPartInspectionPlanId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_PartResultOrientedParameter_SAPPartInspectionPlanId");

            builder.HasOne(d => d.ParameterManagement)
          .WithMany(p => p.PartResultOrientedParameters)
          .HasForeignKey(d => d.ParameterManagementId)
          .OnDelete(DeleteBehavior.Restrict)
          .HasConstraintName("FK_PartResultOrientedParameter_ParameterManagementId");


        }
    }
}
