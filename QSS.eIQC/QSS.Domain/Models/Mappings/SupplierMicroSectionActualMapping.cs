using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class SupplierMicroSectionActualMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierMicroSectionActual, int>
    {
        /// <summary>
        /// Binds Database column UserRoleId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierMicroSectionActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SupplierMicroSectionActualId");

            builder.HasOne(d => d.SupplierMicrosection)
                .WithMany(d => d.SupplierMicroSectionActuals)
                .HasForeignKey(d => d.SupplierMicrosectionId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SupplierMicroSectionActual_SupplierMicrosectionId");
        }
    }
}
