using Microsoft.EntityFrameworkCore;
using QSS.Common.Utilities.EntityFramework;
using QSS.eIQC.DataAccess.Common;
using QSS.eIQC.Domain;
using QSS.eIQC.Domain.Enums;
using QSS.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace QSS.eIQC.DataAccess.Repositories
{
    public class BaseRepository<TEntity, TType> : Repository<TEntity, TType>, IBaseRepository<TEntity, TType> where TEntity : class
    {
        private readonly AuditLogType? _auditLogType = null;

        public BaseRepository(DbContext context) : base(context)
        {
        }

        public BaseRepository(DbContext context, AuditLogType auditLogType) : base(context)
        {
            _auditLogType = auditLogType;
        }

        protected async Task ValidateUniqueAsync(TEntity entity)
        {
            var properties = entity.GetType().GetProperties();

            if (entity is IPersistentObject)
            {
                var idProperty = entity.GetType().GetProperties().FirstOrDefault(p => p.Name == "Id");
                var idValue = idProperty.GetValue(entity);

                foreach (var prop in properties)
                {
                    var uniqueAttribute = (UniqueAttribute)Attribute.GetCustomAttribute(prop, typeof(UniqueAttribute));

                    if (uniqueAttribute != null)
                    {
                        var value = prop.GetValue(entity);
                        var propertyType = prop.PropertyType;

                        var param = Expression.Parameter(typeof(TEntity));
                        var condition =
                            Expression.Lambda<Func<TEntity, bool>>(
                                Expression.Equal(
                                    Expression.Property(param, prop),
                                    Expression.Constant(value, propertyType)
                                ),
                                param
                            );

                        var query = Entities.AsQueryable();

                        if (!idValue.Equals(GetDefaultValue(idProperty.PropertyType)))
                        {
                            query = query.Where(e => ((IPersistentObject)e).Id != idValue);
                        }

                        var isExists = await query.AnyAsync(condition);
                        string propertyName = !string.IsNullOrEmpty(uniqueAttribute.DisplayName) ? uniqueAttribute.DisplayName : prop.Name;
                        if (isExists)
                        {
                            throw new Exception(Constants.ErrorMessage.RecordNotUnique(propertyName));
                        }
                    }
                }
            }
        }

        protected async Task ValidateExistsAsync(TType id)
        {
            var isRecordExists = await Entities
                                .AnyAsync(e => ((IPersistentObject)e).Id.Equals(id));

            if (!isRecordExists)
            {
                throw new Exception(Constants.ErrorMessage.RecordDoesNotExists(id));
            }
        }

        protected async Task<TEntity> ValidateExistsAndGetAsync(TType id)
        {
            var dbEntity = await Get(id);

            if (dbEntity == null)
            {
                throw new Exception(Constants.ErrorMessage.RecordDoesNotExists(id));
            }

            return dbEntity;
        }

        protected void SetAuditLog(TEntity entity, string title, string changeReason)
        {
            if(_auditLogType == null)
            {
                new Exception(Constants.ErrorMessage.AuditLogTypeNotSet);
            }

            var auditLogEntity = entity as IAuditLogEntity;

            if (auditLogEntity != null)
            {
                auditLogEntity.AuditLog = new AuditLog()
                {
                    Title = title,
                    ChangeReason = changeReason,
                    AuditLogType = _auditLogType.Value,
                };
            }
        }

        protected object GetDefaultValue(Type t)
        {
            if (t.IsValueType)
                return Activator.CreateInstance(t);

            return null;
        }

        public async Task<TEntity> AddAsync(TEntity entity, string auditLogTitle, string changeReason)
        {
            await ValidateUniqueAsync(entity);

            SetAuditLog(entity, auditLogTitle, changeReason);

            return await AddAsync(entity);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity, string auditLogTitle, string changeReason)
        {
            await ValidateUniqueAsync(entity);

            var id = (entity as IPersistentObject)?.Id;

            await ValidateExistsAsync((TType)id);

            SetAuditLog(entity, auditLogTitle, changeReason);

            return Update(entity);
        }

    }
}
