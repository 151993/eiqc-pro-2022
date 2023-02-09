using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace QSS.eIQC.Infrastucture.Core.Helper
{
    public static class ParseEmailHelper
    {
        /// <summary>
        /// Parse template
        /// </summary>
        /// <param name="obj">Key value pairs for parsing</param>
        /// <param name="template">Template string</param>
        /// <returns></returns>
        public static string ParseTemplate(Dictionary<string, string> obj, string template)
        {
            var rawTemplate = new StringBuilder();
            if (!string.IsNullOrEmpty(template))
            {
                rawTemplate = new StringBuilder(template);

                var props = obj.Keys;

                foreach (var prop in props)
                {
                    if (template.Contains("#{" + prop + "}#"))
                    {
                        rawTemplate.Replace("#{" + prop + "}#", obj[prop]);
                    }
                }
            }

            return rawTemplate.ToString();
        }

        /// <summary>
        /// Build Email Object
        /// </summary>
        /// <param name="entity">Required class object to parse</param>
        /// <param name="template">Template string</param>
        /// <returns>Key value pairs</returns>
        public static Dictionary<string, string> BuildEmailObject(object entity, string template)
        {
            Dictionary<string, string> emailObj = new Dictionary<string, string>();
            var properties = template.Split("#{".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string propertyString in properties)
            {
                if (!propertyString.Contains("}#") || propertyString.Substring(0, propertyString.IndexOf("}#")).Equals("DNS"))
                {
                    continue;
                }

                string templatePropertyName = propertyString.Substring(0, propertyString.IndexOf("}#"));
                var propertyValue = GetPropValues(templatePropertyName, entity, null);

                if (!emailObj.ContainsKey(templatePropertyName) && propertyValue != null)
                {
                    emailObj.Add(propertyString.Substring(0, propertyString.IndexOf("}#")), propertyValue.ToString());
                }
            }

            return emailObj;
        }

        /// <summary>
        /// Get property values from object
        /// </summary>
        /// <param name="templatePropertyName">Original property name to be replaced in email template</param>
        /// <param name="subProperty">sub Property object of the main object</param>
        /// <param name="propertyValue">value of the subproperty</param>
        /// <returns>Key value pairs</returns>
        private static object GetPropValues(string templatePropertyName, object subProperty, object propertyValue)
        {
            var propertyNames = templatePropertyName.Split(' ');
            foreach (string propertyName in propertyNames)
            {

                var property = subProperty.GetType().GetProperties().FirstOrDefault(p => p.Name.Equals(propertyName, StringComparison.InvariantCultureIgnoreCase));
                if (property == null)
                {
                    continue;
                }

                if (property.PropertyType != typeof(string) && typeof(IEnumerable).IsAssignableFrom(property.PropertyType))
                {
                    var deepProperties = templatePropertyName.Substring(templatePropertyName.IndexOf(propertyName) + propertyName.Length);
                    propertyValue = GetEnumerableTypePropValues(deepProperties, property, subProperty);
                    break;
                }
                else
                {
                    propertyValue = property.GetValue(subProperty);
                    subProperty = propertyValue;
                }

                if (subProperty == null)
                {
                    break;
                }
            }

            return propertyValue;
        }

        /// <summary>
        /// Get Enumerable property values from object
        /// </summary>
        /// <param name="deepProperties">Deep property name to be replaced in email template</param>
        /// <param name="propertyInfo">PropertyInfo of the enumerable property</param>
        /// <param name="subProperty">Value of a sub property inside object</param>
        /// <returns>property value string</returns>
        private static string GetEnumerableTypePropValues(string deepProperties, PropertyInfo propertyInfo, object subProperty)
        {
            var value = string.Empty;
            var propertiesCollection = propertyInfo.GetValue(subProperty) as IEnumerable;

            foreach (var entity in propertiesCollection)
            {
                subProperty = entity;
                object propertyValue = GetPropValues(deepProperties, entity, null);

                if (propertyValue != null && !string.IsNullOrEmpty(propertyValue.ToString()))
                {
                    value += propertyValue + "</br>";
                }
            }

            return value;
        }

    }
}
