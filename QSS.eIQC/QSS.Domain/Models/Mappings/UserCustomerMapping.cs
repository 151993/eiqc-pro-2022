/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    /// <summary>
    /// Helps to map UserCustomer entity model with Database table and bootstrap
    /// </summary>
    public class UserCustomerMapping : EntityTypeConfigurationWithUpdateUserAudit<UserCustomer, int>
    {
        /// <summary>
        /// Binds Database column UserCustomerId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<UserCustomer> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).HasColumnName("UserCustomerId");

            builder.HasOne(d => d.Customer)
                            .WithMany(d => d.UserCustomers)
                            .HasForeignKey(d => d.CustomerId)
                            .OnDelete(DeleteBehavior.Cascade)
                            .HasConstraintName("FK_UserCustomer_CustomerId");

            builder.HasOne(d => d.User)
                .WithMany(d => d.UserCustomers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_UserCustomer_UserId");
        }
    }
}
