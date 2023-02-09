using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map EmailTemplate entity model with Database table and bootstrap
    /// </summary>
    public class EmailTemplateMapping : EntityTypeConfigurationWithUpdateUserAudit<EmailTemplate, int>
    {
        /// <summary>
        /// Binds Database column EmailTemplateId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<EmailTemplate> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("EmailTemplateId");

            builder.Property(p => p.Name).HasMaxLength(50);

            builder.Property(p => p.Subject).HasMaxLength(200);

        }
    }
}
