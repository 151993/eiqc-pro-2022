using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class LocationMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<Location, int>
    {
        public override void Configure(EntityTypeBuilder<Location> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("LocationId");

            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();

            builder.Property(p => p.Description).HasMaxLength(250);

            builder.HasOne(d => d.Country)
              .WithMany(p => p.Location)
              .HasForeignKey(d => d.CountryId)
              .OnDelete(DeleteBehavior.Restrict)
              .HasConstraintName("FK_Location_CountryId");
        }
    }
}
