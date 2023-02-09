using QSS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class AuditLogMapping : EntityTypeConfigurationWithUpdateUserAudit<AuditLog, long>
    {
        public override void Configure(EntityTypeBuilder<AuditLog> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("AuditLogId");

            builder.Property(p => p.AuditData)
                .HasConversion(
                     v => JsonConvert.SerializeObject(v),
                     v => JsonConvert.DeserializeObject<AuditData>(v));
        }
    }
}
