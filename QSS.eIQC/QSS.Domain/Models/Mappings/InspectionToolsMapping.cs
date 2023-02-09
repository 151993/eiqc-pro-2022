/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map InspectionTools entity model with Database table and bootstrap
    /// </summary>
    public class InspectionToolsMapping : EntityTypeConfigurationWithUpdateUserAudit<InspectionTools, int>
    {
        /// <summary>
        /// Binds Database column InspectionToolsId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<InspectionTools> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("InspectionToolsId");

            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();

            builder.HasOne(d => d.InspectionToolsType)
            .WithMany(p => p.InspectionTools)
            .HasForeignKey(d => d.InspectionToolsTypeId)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("FK_InspectionTools_InspectionToolsTypeId");

        }
    }
}
