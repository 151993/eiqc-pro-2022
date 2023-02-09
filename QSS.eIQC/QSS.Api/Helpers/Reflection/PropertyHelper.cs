using System;
using System.Linq;
using System.Reflection;

namespace QSS.eIQC.Api.Helpers.Reflection
{
    public static class PropertyHelper
    {
        public static PropertyInfo GetPropertyName(Type type, string propertyName)
        {
            if (type.GenericTypeArguments.Any())
            {
                type = type.GenericTypeArguments.FirstOrDefault();
            }

            var property = type.GetProperties().FirstOrDefault(p => p.Name.Equals(propertyName, StringComparison.InvariantCultureIgnoreCase));
            if (property == null)
            {
                throw new Exception($"Property {propertyName} not found.");
            }

            return property;
        }
    }
}
