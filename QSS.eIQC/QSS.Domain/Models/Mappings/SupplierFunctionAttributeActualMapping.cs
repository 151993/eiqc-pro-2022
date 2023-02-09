using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class SupplierFunctionAttributeActualMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFunctionAttributeActual, int>
    {
        /// <summary>
        /// Binds Database column UserRoleId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFunctionAttributeActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SupplierFunctionAttributeActualId");

            builder.HasOne(d => d.SupplierFunctionAttribute)
                .WithMany(d => d.SupplierFunctionAttributeActuals)
                .HasForeignKey(d => d.SupplierFunctionAttributeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SupplierFunctionAttributeActual_SupplierFunctionAttributeId");
        }
    }
}
