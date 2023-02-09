/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map PartFunParameter entity model with Database table and bootstrap
    /// </summary>
    public class PartFunParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<PartFunParameter,int>
    {
		/// <summary>
        /// Binds Database column PartFunParameterId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<PartFunParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("PartFunParameterId");

            builder.HasOne(d => d.SAPPartInspectionPlan)
           .WithMany(p => p.PartFunParameters)
           .HasForeignKey(d => d.SAPPartInspectionPlanId)
           .OnDelete(DeleteBehavior.Cascade)
           .HasConstraintName("FK_PartFunParameter_SAPPartInspectionPlanId");

            builder.HasOne(d => d.ParameterManagement)
           .WithMany(p => p.PartFunParameters)
           .HasForeignKey(d => d.ParameterManagementId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartFunParameter_ParameterManagementId");

            builder.HasOne(d => d.InstrumentType)
           .WithMany(p => p.PartFunParameters)
           .HasForeignKey(d => d.InstrumentTypeId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartFunParameter_InstrumentTypeId");

            builder.HasOne(d => d.UOM)
           .WithMany(p => p.PartFunParameters)
           .HasForeignKey(d => d.UOMId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartFunParameter_UOMId");

            builder.HasOne(d => d.DataType)
           .WithMany(p => p.PartFunParameters)
           .HasForeignKey(d => d.DataTypeId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartFunParameter_DataTypeId");
            
            builder.HasOne(d => d.ChartType)
           .WithMany(p => p.PartFunParameters)
           .HasForeignKey(d => d.ChartTypeId)
           .IsRequired(false)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_PartFunParameter_ChartTypeId");

        }
    }
}
