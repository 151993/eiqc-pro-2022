using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class DepartmentMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<Department, int>
    {
        public override void Configure(EntityTypeBuilder<Department> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("DepartmentId");

            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();

            builder.Property(p => p.Description).HasMaxLength(250);
        }
    }
}
