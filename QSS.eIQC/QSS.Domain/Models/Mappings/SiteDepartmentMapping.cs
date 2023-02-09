using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class SiteDepartmentMapping : EntityTypeConfigurationWithUpdateUserAudit<SiteDepartment, int>
    {
        /// <summary>
        /// Binds Database column SiteDepartmentId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SiteDepartment> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SiteDepartmentId");
        }
    }
}
