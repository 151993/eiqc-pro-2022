using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.eIQC.Utilities.Helper;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class TM1DataSyncDetailsMapping : IEntityTypeConfiguration<TM1DataSyncDetails>
    {
        public  void Configure(EntityTypeBuilder<TM1DataSyncDetails> builder)
        {

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasData(JsonDeserializer.DeserializerObject<TM1DataSyncDetails>(builder.Metadata.ClrType.Name));
        }
    }
}
