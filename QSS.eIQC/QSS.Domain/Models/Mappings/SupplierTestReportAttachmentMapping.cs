using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class SupplierTestReportAttachmentMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<SupplierTestReportAttachment, int>
    {
        public override void Configure(EntityTypeBuilder<SupplierTestReportAttachment> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SupplierTestReportAttachmentId");

            builder
                .HasOne(d => d.SupplierTestReport)
              .WithMany(d => d.SupplierTestReportAttachments)
              .HasForeignKey(d => d.SupplierTestReportId)
              .OnDelete(DeleteBehavior.Cascade)
              .HasConstraintName("FK_SupplierTestReport_SupplierTestReportId");

            builder
                 .HasOne(d => d.Attachment)
               .WithMany(d => d.SupplierTestReportAttachments)
               .HasForeignKey(d => d.AttachmentId)
               .OnDelete(DeleteBehavior.NoAction)
               .HasConstraintName("FK_Attachment_AttachmentId");
        }
    }
}
