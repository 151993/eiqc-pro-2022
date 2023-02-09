using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class PartInspectionDrawingAttachmentMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<PartInspectionDrawingAttachment, int>
    {
        public override void Configure(EntityTypeBuilder<PartInspectionDrawingAttachment> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("PartInspectionDrawingAttachmentId");

            builder.Property(p => p.PartInspectionDrawingId).IsRequired(false);


            builder
              .HasOne(d => d.PartInspectionDrawing)
            .WithMany(d => d.PartInspectionDrawingAttachments)
            .HasForeignKey(d => d.PartInspectionDrawingId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("FK_PartInspectionDrawing_PartInspectionDrawingId");


            builder
                 .HasOne(d => d.Attachment)
               .WithMany(d => d.PartInspectionDrawingAttachments)
               .HasForeignKey(d => d.AttachmentId)
               .OnDelete(DeleteBehavior.NoAction)
               .HasConstraintName("FK_Attachment_AttachmentId");

        }
    }
}
