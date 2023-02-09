using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// 
    /// </summary>
    public class RolePermissionMapping : EntityTypeConfigurationWithUpdateUserAudit<RolePermission, int>
    {
        /// <summary>
        /// Binds Database column RolePermissionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("RolePermissionId");

            builder.HasOne(d => d.Role)
                .WithMany(p => p.Permissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_RolePermission_RoleId");
        }
    }
}
