using System;
using QSS.eIQC.Domain.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace QSS.eIQC.Domain
{
    public abstract class EntityTypeConfigurationWithUpdateUserAuditStatus<TEntity, TKey> : EntityTypeConfigurationWithUpdateUserAudit<TEntity, TKey>
        where TEntity : PersistentObject<TKey>, IUserAuditEntity, IStatusEntity
       where TKey : IComparable
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
            builder.Property(d => d.Status).HasDefaultValue(StatusType.Active);

        }

    }
}
