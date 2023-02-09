using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class SiteDivisionMapping : EntityTypeConfigurationWithUpdateUserAudit<SiteDivision, int>
    {
        /// <summary>
        /// Binds Database column UserRoleId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SiteDivision> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SiteDivisionId");

            builder.HasOne(d => d.Site)
                .WithMany(d => d.SiteDivisions)
                .HasForeignKey(d => d.SiteId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SiteDivision_SiteId");

            builder.HasOne(d => d.Division)
                .WithMany(d => d.SiteDivisions)
                .HasForeignKey(d => d.DivisionId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_SiteDivision_DivisionId");
        }
    }
}
