using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class WorkCellJabilUserMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<WorkCellJabilUser, int>
    {
        /// <summary>
        /// Binds Database column MaterialGroupUserId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<WorkCellJabilUser> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("WorkCellJabilUserId");

            builder.HasOne(d => d.WorkCellUser)
                .WithMany(d => d.WorkCellJabilUsers)
                .HasForeignKey(d => d.WorkCellUserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_WorkCellJabilUser_WorkCellUserId");

            builder.HasOne(d => d.User)
                .WithMany(d => d.WorkCellJabilUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_WorkCellJabilUser_UserId");
        }
    }
}
