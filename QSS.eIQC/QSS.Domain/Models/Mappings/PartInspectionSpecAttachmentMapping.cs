
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class PartInspectionSpecAttachmentMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<PartInspectionSpecAttachment, int>
    {
        public override void Configure(EntityTypeBuilder<PartInspectionSpecAttachment> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("PartInspectionSpecAttachmentId");

            builder.Property(p => p.PartInspectionSpecificationId).IsRequired(false);

            builder
               .HasOne(d => d.PartInspectionSpecification)
               .WithMany(d => d.PartInspectionSpecAttachments)
               .HasForeignKey(d => d.PartInspectionSpecificationId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_PartInspectionSpecification_PartInspectionSpecificationId");


            builder
                 .HasOne(d => d.Attachment)
               .WithMany(d => d.PartInspectionSpecAttachments)
               .HasForeignKey(d => d.AttachmentId)
               .OnDelete(DeleteBehavior.NoAction)
               .HasConstraintName("FK_Attachment_AttachmentId");

           
        }
    }
}
