using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class UserMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<User, int>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("UserId");

            builder.Property(p => p.Name).HasMaxLength(300).IsRequired();

            builder.Property(p => p.UserName).HasMaxLength(100);

            builder.Property(p => p.Email).HasMaxLength(100);

            builder.Property(p => p.Phone).HasMaxLength(50);

            builder.HasOne(d => d.Manager)
              .WithMany(p => p.User)
              .HasForeignKey(d => d.ManagerId)
               .IsRequired(false)
              .OnDelete(DeleteBehavior.Restrict)
              .HasConstraintName("FK_User_ManagerId");

            builder.HasOne(d => d.Department)
             .WithMany(p => p.User)
             .HasForeignKey(d => d.DepartmentId)
             .IsRequired(false)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_User_DepartmentId");


            builder.HasOne(d => d.Site)
             .WithMany(p => p.Users)
             .HasForeignKey(d => d.SiteId)
             .IsRequired(false)
             .OnDelete(DeleteBehavior.Restrict)
             .HasConstraintName("FK_User_SiteId");

            builder.HasOne(d => d.Supplier)
           .WithMany(p => p.User)
           .HasForeignKey(d => d.SupplierId)
           .IsRequired(false)
           .OnDelete(DeleteBehavior.Restrict)
           .HasConstraintName("FK_User_SupplierId");
        }
    }
}
