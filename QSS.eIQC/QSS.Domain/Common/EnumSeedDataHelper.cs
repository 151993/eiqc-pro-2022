using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace QSS.eIQC.Domain.Common
{
    public class EnumSeedDataHelper
    {
        public static List<TEntity> SeedEnumData<TEntity,TEnum,TKey>()
         where TEntity : BaseEnum<TEnum,TKey>
         where TKey:IComparable
        {
            var items = new List<TEntity>();
            var etype = typeof(TEnum);

            if (!etype.IsEnum)
                throw new Exception(string.Format("Type '{0}' must be enum", etype.AssemblyQualifiedName));

            var ntype = Enum.GetUnderlyingType(etype);

            if (ntype == typeof(long) || ntype == typeof(ulong) || ntype == typeof(uint))
                throw new Exception();

            foreach (TEnum evalue in Enum.GetValues(etype))
            {
                var item = Activator.CreateInstance<TEntity>();

                item.Id = (TKey)Convert.ChangeType(evalue, typeof(TKey));

                item.Name = Enum.GetName(etype, evalue);

                item.Description = GetEnumDescription(evalue);

                items.Add(item);

            }
            return items;
        }
        public static string GetEnumDescription<TEnum>(TEnum item)
        {
            Type type = item.GetType();

            var attribute = type.GetField(item.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false).Cast<DescriptionAttribute>().FirstOrDefault();
            return attribute == null ? string.Empty : attribute.Description;
        }
    }
}
