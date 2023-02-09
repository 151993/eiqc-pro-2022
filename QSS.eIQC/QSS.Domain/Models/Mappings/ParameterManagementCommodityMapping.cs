using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class ParameterManagementCommodityMapping : EntityTypeConfigurationWithUpdateUserAudit<ParameterManagementCommodity, int>
    {
        /// <summary>
        /// Binds Database column UserRoleId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<ParameterManagementCommodity> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("ParameterManagementCommodityId");
            builder.HasOne(d => d.ParameterManagement)
                .WithMany(d => d.ParameterManagementCommodity)
                .HasForeignKey(d => d.ParameterManagementId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ParameterManagementCommodity_ParameterManagementId");



            builder.HasOne(d => d.Commodity)
                .WithMany(d => d.ParameterManagementCommodity)
                .HasForeignKey(d => d.CommodityId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_ParameterManagementCommodity_CommodityId");
        }
    }
}
