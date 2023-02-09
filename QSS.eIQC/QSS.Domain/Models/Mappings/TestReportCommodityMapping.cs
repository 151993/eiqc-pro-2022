

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{

    public class TestReportCommodityMapping : EntityTypeConfigurationWithUpdateUserAudit<TestReportCommodity, int>
    {
        /// <summary>
        /// Binds Database column UserRoleId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<TestReportCommodity> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("TestReportCommodityId");

            builder.HasOne(d => d.TestReport)
                .WithMany(d => d.TestReportCommodities)
                .HasForeignKey(d => d.TestReportId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TestReportCommodity_TestReportId");

            builder.HasOne(d => d.Commodity)
                .WithMany(d => d.TestReportCommodities)
                .HasForeignKey(d => d.CommodityId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_TestReportCommodity_CommodityId");
        }
    }
}
