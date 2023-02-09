using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace QSS.eIQC.DataAccess.Helpers
{
    public static class ReflectionHelper
    {
        public static object GetPropValue(this object obj, string propName)
        {
            string[] nameParts = propName.Split('.');
            if (nameParts.Length == 1)
            {
                return obj.GetType().GetProperty(propName).GetValue(obj, null);
            }

            foreach (var part in nameParts)
            {
                if (obj == null) { return null; }

                Type type = obj.GetType();
                PropertyInfo info = type.GetProperty(part);
                if (info == null) { return null; }

                obj = info.GetValue(obj, null);
            }
            return obj;
        }

        public static string GetFkNameFromAttribute(this PropertyInfo self)
        {
            var fkAttribute = self.GetCustomAttributes(typeof(ForeignKeyAttribute), true).FirstOrDefault() as ForeignKeyAttribute;
            if (fkAttribute != null)
            {
                return fkAttribute.Name;
            }

            return null;
        }

        public static bool IsVirtualAndGeneric(this PropertyInfo self)
        {
            if (self == null)
                throw new ArgumentNullException("self");

            bool found = false;
            foreach (MethodInfo method in self.GetAccessors())
            {
                if (method.IsVirtual)
                {
                    found = true;
                    break;
                }
            }

            return found && self.PropertyType.IsGenericType;
        }

        public static bool IsCollection(this PropertyInfo self)
        {
            Type collectionType = typeof(ICollection<>);
            if (collectionType.IsAssignableFrom(self.PropertyType.GetGenericTypeDefinition()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            

        public static string GetPropertyName<T>(this Expression<Func<T>> propertyExpression)
        {
            return (propertyExpression.Body as MemberExpression).Member.Name;
        }
    }
}
