using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class AdminCertificationAttachmentMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<AdminCertificationAttachment, int>
    {
        public override void Configure(EntityTypeBuilder<AdminCertificationAttachment> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("AdminCertificationAttachmentId");

            builder
                 .HasOne(d => d.AdminCertification)
               .WithMany(d => d.AdminCertificationAttachments)
               .HasForeignKey(d => d.AdminCertificateId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_AdminCertification_AdminCertificateId");

            builder
                 .HasOne(d => d.Attachment)
               .WithMany(d => d.AdminCertificationAttachments)
               .HasForeignKey(d => d.AttachmentId)
               .OnDelete(DeleteBehavior.NoAction)
               .HasConstraintName("FK_Attachment_AttachmentId");
        }
    }
}
