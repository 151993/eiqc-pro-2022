
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class ParameterTypePcCodeMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<ParameterTypePcCode, int>
    {
        /// <summary>
        /// Binds Database column ParameterTypePcCode with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<ParameterTypePcCode> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("ParameterTypePcCodeId");

            builder.HasOne(d => d.ParameterTypeCode)
                .WithMany(d => d.ParameterTypePcCodes)
                .HasForeignKey(d => d.ParameterTypeCodeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ParameterTypeCode_ParameterTypeCodeId");


            builder.HasOne(d => d.PCCode)
                .WithMany(d => d.ParameterTypePcCodes)
                .HasForeignKey(d => d.PCCodeId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_ParameterTypePcCode_PCCodeId");
        }
    }
}
