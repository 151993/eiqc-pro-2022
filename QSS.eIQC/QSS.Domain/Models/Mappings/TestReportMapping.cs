/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map TestReport entity model with Database table and bootstrap
    /// </summary>
    public class TestReportMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<TestReport, int>
    {
        /// <summary>
        /// Binds Database column TestReportId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<TestReport> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("TestReportId");

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.Description)
                .HasMaxLength(250);


        }
    }
}
