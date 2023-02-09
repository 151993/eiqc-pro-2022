/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map PartCountParameter entity model with Database table and bootstrap
    /// </summary>
    public class PartCountParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<PartCountParameter,int>
    {
		/// <summary>
        /// Binds Database column PartCountParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<PartCountParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("PartCountParameterId");

            builder.HasOne(d => d.SAPPartInspectionPlan)
          .WithMany(p => p.PartCountParameters)
          .HasForeignKey(d => d.SAPPartInspectionPlanId)
          .IsRequired(false)
          .OnDelete(DeleteBehavior.Cascade)
          .HasConstraintName("FK_PartCountParameter_SAPPartInspectionPlanId");

            builder.HasOne(d => d.ParameterManagement)
          .WithMany(p => p.PartCountParameters)
          .HasForeignKey(d => d.ParameterManagementId)
          .IsRequired(false)
          .OnDelete(DeleteBehavior.Restrict)
          .HasConstraintName("FK_PartCountParameter_ParameterManagementId");

            builder.HasOne(d => d.InspectionToolsType)
         .WithMany(p => p.PartCountParameters)
         .HasForeignKey(d => d.InspectionToolsTypeId)
         .IsRequired(false)
         .OnDelete(DeleteBehavior.Restrict)
         .HasConstraintName("FK_PartCountParameter_InspectionToolsTypeId");
        }
    }
}
