using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;
using Microsoft.EntityFrameworkCore;
using QSS.eIQC.Utilities.Helper;

namespace QSS.eIQC.Domain
{
    public abstract class EntityTypeConfigurationWithUpdateUserAudit<TEntity, TKey> : EntityTypeConfigurationWithUpdateAudit<TEntity, TKey>
        where TEntity : PersistentObject<TKey>, IUserAuditEntity
       where TKey : IComparable
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);

            builder.HasOne(d => d.CreatedByUser)
                   .WithMany();

            builder.HasOne(d => d.LastUpdatedByUser)
                    .WithMany();

            builder.Property(m => m.Created).HasDefaultValueSql("CURRENT_TIMESTAMP").ValueGeneratedOnAdd();
            builder.Property(m => m.LastUpdated).ValueGeneratedOnAdd().HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.HasData(JsonDeserializer.DeserializerObject<TEntity>(builder.Metadata.ClrType.Name));
        }
    }
}
