using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class CertificateTypeParameterMapping : EntityTypeConfigurationWithUpdateUserAudit<CertificateTypeParameter, int>
    {
        /// <summary>
        /// Binds Database column UserRoleId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<CertificateTypeParameter> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("CertificateTypeParameterId");

            builder.HasOne(d => d.CertificateType)
                .WithMany(d => d.CertificateTypeParameters)
                .HasForeignKey(d => d.CertificateTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_CertificateTypeParameter_CertificateTypeId");
        }
    }
}
