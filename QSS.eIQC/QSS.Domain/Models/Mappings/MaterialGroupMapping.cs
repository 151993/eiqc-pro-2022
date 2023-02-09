using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
	/// <summary>
    /// Helps to map Site entity model with Database table and bootstrap
    /// </summary>
    public class MaterialGroupMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<MaterialGroup,int>
    {
        /// <summary>
        /// Binds Database column MaterialGroupId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<MaterialGroup> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("MaterialGroupId");

            builder.Property(p => p.SiteName).HasMaxLength(50).IsRequired();

            builder.Property(p => p.MaterialGroupName).HasMaxLength(50);

        }
    }
}
