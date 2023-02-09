using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.eIQC.Utilities.Helper;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class SAPDataSyncDetailsMapping : IEntityTypeConfiguration<SAPDataSyncDetails>
    {
        public  void Configure(EntityTypeBuilder<SAPDataSyncDetails> builder)
        {
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasData(JsonDeserializer.DeserializerObject<SAPDataSyncDetails>(builder.Metadata.ClrType.Name));
        }
    }
}
