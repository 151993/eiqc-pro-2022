/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map SiteUser entity model with Database table and bootstrap
    /// </summary>
    public class SiteUserMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<SiteUser, int>
    {
        /// <summary>
        /// Binds Database column SiteUserId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SiteUser> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("SiteUserId");

            builder.HasOne(d => d.Site)
                .WithMany(d => d.SiteUsers)
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SiteUser_SiteId");

            builder.HasOne(d => d.User)
                .WithMany(d => d.SiteUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_SiteUser_UserId");
        }
    }
}
