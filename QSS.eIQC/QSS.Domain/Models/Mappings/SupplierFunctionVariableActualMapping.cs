/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map PartMicrosection entity model with Database table and bootstrap
    /// </summary>
    public class SupplierFunctionVariableActualMapping : EntityTypeConfigurationWithUpdateUserAudit<SupplierFunctionVariableActual, int>
    {
        /// <summary>
        /// Binds Database column PartMicrosectionId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<SupplierFunctionVariableActual> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SupplierFunctionVariableAcutalId");

            builder.HasOne(d => d.SupplierFunctionVariable)
                .WithMany(d => d.SupplierFunctionVariableActuals)
                .HasForeignKey(d => d.SupplierFunctionVariableId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SupplierFunctionVariableAcutal_SupplierFunctionVariableId");


        }
    }
}
