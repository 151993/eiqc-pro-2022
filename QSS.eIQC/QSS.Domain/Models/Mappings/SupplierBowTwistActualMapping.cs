using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class SupplierBowTwistActualMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierBowTwistActual, int>
    {
        /// <summary>
        /// Binds Database column UserRoleId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierBowTwistActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SupplierBowTwistActualId");

            builder.HasOne(d => d.SupplierBowTwist)
                .WithMany(d => d.SupplierBowTwistActuals)
                .HasForeignKey(d => d.SupplierBowTwistId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SupplierBowTwistActual_SupplierBowTwistId");
        }
    }
}
