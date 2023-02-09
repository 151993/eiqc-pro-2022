using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.eIQC.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace QSS.eIQC.Domain
{
    public abstract class EntityTypeConfigurationEnum<TEntity, TEnum, TKey> : IEntityTypeConfiguration<TEntity>
      where TEntity : BaseEnum<TEnum, TKey>
      where TKey : IComparable
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            //base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedNever();
            builder.HasData(EnumSeedDataHelper.SeedEnumData<TEntity, TEnum, TKey>());
        }
    }
}
