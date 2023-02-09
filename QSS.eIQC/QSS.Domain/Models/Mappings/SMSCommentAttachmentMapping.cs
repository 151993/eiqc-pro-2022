using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class SMSCommentAttachmentMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<SMSCommentAttachment, int>
    {
        public override void Configure(EntityTypeBuilder<SMSCommentAttachment> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SMSCommentAttachmentId");

            builder
                .HasOne(d => d.SupplierMeasurementSubmission)
              .WithMany(d => d.SMSCommentAttachments)
              .HasForeignKey(d => d.SupplierMeasurementSubmissionId)
              .OnDelete(DeleteBehavior.Cascade)
              .HasConstraintName("FK_SMSCommentAttachment_SupplierMeasurementSubmissionId");

            builder
                 .HasOne(d => d.Attachment)
               .WithMany(d => d.SMSCommentAttachments)
               .HasForeignKey(d => d.AttachmentId)
               .OnDelete(DeleteBehavior.NoAction)
               .HasConstraintName("FK_Attachment_AttachmentId");
        }
    }
}
