/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map Instrument entity model with Database table and bootstrap
    /// </summary>
    public class InstrumentMapping : EntityTypeConfigurationWithUpdateUserAudit<Instrument, int>
    {
        /// <summary>
        /// Binds Database column InstrumentId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<Instrument> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("InstrumentId");

            builder.HasIndex(p => p.InstrumentNo)
                .HasName("UK_Instrument_InstrumentNo")
                .IsUnique();
            builder.Property(p => p.Description)
                .HasMaxLength(255);
            builder.Property(p => p.ValidDate)
                .IsRequired();

            builder.HasOne(d => d.InstrumentType)
       .WithMany(p => p.Instrument)
       .HasForeignKey(d => d.InstrumentTypeId)
       .OnDelete(DeleteBehavior.Restrict)
       .HasConstraintName("FK_Instrument_InstrumentTypeId");

        }
    }
}