using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class UserRoleMapping : EntityTypeConfigurationWithUpdateUserAudit<UserRole, int>
    {
        /// <summary>
        /// Binds Database column UserRoleId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<UserRole> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("UserRoleId");

            builder.HasOne(d => d.User)
                .WithMany(d => d.Roles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_UserRole_UserId");

            builder.HasOne(d => d.Role)
                .WithMany(d => d.UserRole)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_UserRole_RoleId");
        }
    }
}
