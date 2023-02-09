
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QSS.eIQC.Domain.Models.Mappings
{

    public class WorkCellDccUserMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<WorkCellDccUser, int>
    {
        /// <summary>
        /// Binds Database column MaterialGroupUserId with Id property of Entity model
        /// </summary>
        /// <param name="builder"><see cref="EntityTypeBuilder"/></param>
        public override void Configure(EntityTypeBuilder<WorkCellDccUser> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("WorkCellDccUserId");

            builder.HasOne(d => d.WorkCellUser)
                .WithMany(d => d.WorkCellDccUsers)
                .HasForeignKey(d => d.WorkCellUserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_WorkCellDccUser_WorkCellUserId");

            builder.HasOne(d => d.User)
                .WithMany(d => d.WorkCellDccUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_WorkCellDccUser_UserId");
        }
    }
}
