using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class PartInspectionCertificationAttachmentMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<PartInspectionCertificationAttachment, int>
    {
        public override void Configure(EntityTypeBuilder<PartInspectionCertificationAttachment> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("PartInspectionCertificationAttachmentId");

            builder
                .HasOne(d => d.SAPPartInspectionPlan)
              .WithMany(d => d.PartInspectionCertificationAttachments)
              .HasForeignKey(d => d.SAPPartInspectionPlanId)
              .OnDelete(DeleteBehavior.Cascade)
              .HasConstraintName("FK_PartInspectionCertificationAttachment_SAPPartInspectionPlanId");

            builder
                 .HasOne(d => d.Attachment)
               .WithMany(d => d.PartInspectionCertificationAttachments)
               .HasForeignKey(d => d.AttachmentId)
               .OnDelete(DeleteBehavior.NoAction)
               .HasConstraintName("FK_Attachment_AttachmentId");
        }
    }
}
