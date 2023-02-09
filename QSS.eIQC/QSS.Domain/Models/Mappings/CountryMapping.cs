using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class CounrtyMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<Country, int>
    {
        public override void Configure(EntityTypeBuilder<Country> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("CountryId");

            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();

            builder.Property(p => p.Description).HasMaxLength(250);

            builder.HasOne(d => d.Region)
               .WithMany(p => p.Country)
               .HasForeignKey(d => d.RegionId)
               .OnDelete(DeleteBehavior.Restrict)
               .HasConstraintName("FK_Country_RegionId");

        }
    }
}