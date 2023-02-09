/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SAPPartInspectionPlan entity model with Database table and bootstrap
    /// </summary>
    public class SAPPartInspectionPlanMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<SAPPartInspectionPlan,int>
    {
		/// <summary>
        /// Binds Database column SAPPartInspectionPlanId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SAPPartInspectionPlan> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SAPPartInspectionPlanId");

            builder.Property(p => p.IP).HasMaxLength(100).IsRequired();

            builder.Property(p => p.SiteIP).HasMaxLength(100).IsRequired();

            builder.Property(p => p.DivisionModelNumber).HasMaxLength(50);

            builder.Property(p => p.GenWI).HasMaxLength(50);

            builder.Property(p => p.RefDoc).HasMaxLength(50);

            builder.Property(p => p.StateTypeId)
                .IsRequired();


            builder.HasOne(d => d.WorkCell)
             .WithMany(p => p.SAPPartInspectionPlans)
             .HasForeignKey(d => d.WorkCellId)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_SAPPartInspectionPlan_WorkCellId")
            .IsRequired(false);

            builder.HasOne(d => d.PartDateCode)
           .WithMany(p => p.SAPPartInspectionPlans)
           .HasForeignKey(d => d.PartDateCodeId)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_SAPPartInspectionPlan_PartDateCodeId")
           .IsRequired(false);

            builder.HasOne(d => d.ProductLifeCycleStage)
             .WithMany(p => p.SAPPartInspectionPlans)
             .HasForeignKey(d => d.ProductLifeCycleStageId)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_ProductLifeCycleStage_ProductLifeCycleStageId")
            .IsRequired(false);


            builder.HasOne(d => d.Commodity)
             .WithMany(p => p.SAPPartInspectionPlans)            
             .HasForeignKey(d => d.CommodityId)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_SAPPartInspectionPlan_CommodityId");



            builder.HasOne(d => d.SubmittedBy)
             .WithMany(p => p.SAPPartInspectionPlanSubmittedUsers)
             .HasForeignKey(d => d.SubmittedByUserId)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_SAPPartInspectionPlan_SubmittedByUserId")
             .IsRequired(false);

            builder.HasOne(d => d.AssignTo)
             .WithMany(p => p.SAPPartInspectionPlanAssignToUsers)
             .HasForeignKey(d => d.AssignToUserId)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_SAPPartInspectionPlan_AssignToUserId")
             .IsRequired(false);


            builder.HasOne(d => d.ApproveRejected)
             .WithMany(p => p.SAPPartInspectionPlanApproveRejectedUsers)
             .HasForeignKey(d => d.ApproveRejectedId)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_SAPPartInspectionPlan_ApproveRejectedId")
             .IsRequired(false);

            builder.HasOne(d => d.Supplier)
            .WithMany(p => p.SAPPartInspectionPlan)
            .HasForeignKey(d => d.SupplierId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_SAPPartInspectionPlan_SupplierId")
            .IsRequired(false);

            builder.HasOne(d => d.SupplierContact)
             .WithMany(p => p.SAPPartInspectionPlanSupplierContactUsers)
             .HasForeignKey(d => d.SupplierContactId)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_SAPPartInspectionPlan_SupplierContactId")
             .IsRequired(false);


        }
    }
}
