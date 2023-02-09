using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class WorkCellSiteMapping : EntityTypeConfigurationWithUpdateUserAudit<WorkCellSite, int>
    {
        /// <summary>
        /// Binds Database column SiteWorkCellId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<WorkCellSite> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("WorkCellSiteId");

            builder.HasOne(d => d.WorkCell)
               .WithMany(d => d.WorkCellSites)
               .HasForeignKey(d => d.WorkCellId)
               .OnDelete(DeleteBehavior.Cascade)
               .HasConstraintName("FK_WorkCellSite_WorkCellId");

            builder.HasOne(d => d.Site)
                .WithMany(d => d.WorkCellSites)
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_WorkCellSite_SiteId");
        }
    }
}
