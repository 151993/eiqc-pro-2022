using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map RoleId entity model with Database table and bootstrap
    /// </summary>
    public class RoleMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<Role, int>
    {
        /// <summary>
        /// Binds Database column RoleId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("RoleId");

            builder.Property(p => p.Name).HasMaxLength(60).IsRequired();
        }
    }
}
