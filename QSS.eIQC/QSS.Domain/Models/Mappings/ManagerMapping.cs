using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class ManagerMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<Manager, int>
    {
        public override void Configure(EntityTypeBuilder<Manager> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("ManagerId");
            
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();

        }
    }
}
