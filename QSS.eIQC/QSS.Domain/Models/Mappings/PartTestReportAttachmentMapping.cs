using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class PartTestReportAttachmentMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<PartTestReportAttachment, int>
    {
        public override void Configure(EntityTypeBuilder<PartTestReportAttachment> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("PartTestReportAttachmentId");

            builder
                .HasOne(d => d.PartTestReportParameter)
              .WithMany(d => d.PartTestReportAttachments)
              .HasForeignKey(d => d.PartTestReportParameterId)
              .OnDelete(DeleteBehavior.Cascade)
              .HasConstraintName("FK_PartTestReport_PartTestReportParameterId");

            builder
                 .HasOne(d => d.Attachment)
               .WithMany(d => d.PartTestReportAttachments)
               .HasForeignKey(d => d.AttachmentId)
               .OnDelete(DeleteBehavior.NoAction)
               .HasConstraintName("FK_Attachment_AttachmentId");
        }
    }
}
