using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class SiteWorkCellMapping : EntityTypeConfigurationWithUpdateUserAudit<SiteWorkCell, int>
    {
        /// <summary>
        /// Binds Database column SiteWorkCellId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SiteWorkCell> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SiteWorkCellId");
        }
    }
}
