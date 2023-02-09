/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map SAPPartInspectionPlan entity model with Database table and bootstrap
    /// </summary>
    public class SupplierMeasurementSubmissionMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<SupplierMeasurementSubmission, int>
    {
		/// <summary>
        /// Binds Database column SAPPartInspectionPlanId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierMeasurementSubmission> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SupplierMeasurementSubmissionId");

            builder.Property(p => p.IP).HasMaxLength(100).IsRequired();

            builder.Property(p => p.ResultDescription).HasMaxLength(1000);

            builder.Property(p => p.SMSNo).HasMaxLength(100).IsRequired();

            builder.Property(p => p.StateTypeId);

            builder.HasOne(d => d.WorkCell)
             .WithMany(p => p.SupplierMeasurementSubmissions)
             .HasForeignKey(d => d.WorkCellId)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_SupplierMeasurementSubmission_WorkCellId")
            .IsRequired(false);

            builder.HasOne(d => d.Supplier)
            .WithMany(p => p.SupplierMeasurementSubmission)
            .HasForeignKey(d => d.SupplierId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_SupplierMeasurementSubmission_SupplierId")
            .IsRequired(false);

            builder.HasOne(d => d.SAPPartInspectionPlan)
             .WithMany(p => p.SupplierMeasurementSubmissions)
             .HasForeignKey(d => d.SAPPartInspectionPlanId)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_SupplierMeasurementSubmission_SAPPartInspectionPlanId")
            .IsRequired(false);

            builder.HasOne(d => d.SubmittedBy)
             .WithMany(p => p.SupplierMeasurementSubmissionSubmittedUsers)
             .HasForeignKey(d => d.SubmittedByUserId)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_SupplierMeasurementSubmission_SubmittedByUserId")
             .IsRequired(false);


            builder.HasOne(d => d.ApproveRejected)
             .WithMany(p => p.SupplierMeasurementSubmissionApproveRejectedUsers)
             .HasForeignKey(d => d.ApproveRejectedId)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_SupplierMeasurementSubmission_ApproveRejectedId")
             .IsRequired(false);

            builder.HasOne(d => d.SupplierContact)
            .WithMany(p => p.SupplierMeasurementSubmissionSupplierContactUsers)
            .HasForeignKey(d => d.SupplierContactId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_SupplierMeasurementSubmission_SupplierContactId")
            .IsRequired(false);
            
            builder.HasOne(d => d.Inspector)
            .WithMany(p => p.SupplierMeasurementSubmissionInspectors)
            .HasForeignKey(d => d.InspectorId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_SupplierMeasurementSubmission_InspectorId")
            .IsRequired(false);


        }
    }
}
