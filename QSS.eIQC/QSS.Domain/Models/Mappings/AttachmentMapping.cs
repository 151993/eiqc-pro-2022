using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class AttachmentMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<Attachment, int>
    {
        /// <summary>
        /// Binds Database column AnswerTypeId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<Attachment> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("AttachmentId");
        }
    }
}
