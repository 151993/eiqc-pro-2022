using Microsoft.AspNet.OData.Query;
using Microsoft.OData.UriParser;
using QSS.eIQC.Api.Helpers.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.Api.Helpers.Extensions
{
    /// <summary>
    /// OData Query Options Extensions
    /// </summary>
    public static class ODataQueryOptionsExtensions
    {
        /// <summary>
        /// Expanded Properties
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="queryOptions">queryOptions</param>
        /// <returns>Returns string array of expanded items</returns>
        public static string[] ToExpandedProperties<T>(this ODataQueryOptions queryOptions)
        {
            if (queryOptions == null) { return new string[] { }; }

            var expandProperties = new List<string>();

            if (queryOptions.SelectExpand != null)
            {
                expandProperties.AddRange(GetExpandedProperties(queryOptions.SelectExpand.SelectExpandClause.SelectedItems));
            }

            var properties = new List<string>();

            foreach (var expandProperty in expandProperties)
            {
                var property = string.Empty;

                if (expandProperty.Contains("."))
                {
                    var splittedProperties = expandProperty.Split('.');
                    var subProperties = new List<string>();

                    var propertyType = typeof(T);

                    for (var propIndex = 0; propIndex < splittedProperties.Length; propIndex++)
                    {
                        var propertyInfo = PropertyHelper.GetPropertyName(propertyType, splittedProperties[propIndex]);
                        propertyType = propertyInfo.PropertyType;
                        subProperties.Add(propertyInfo.Name);
                    }

                    property = string.Join(".", subProperties);
                }
                else
                {
                    var propertyInfo = PropertyHelper.GetPropertyName(typeof(T), expandProperty);
                    property = propertyInfo.Name;
                }

                properties.Add(property);

            }

            return properties.ToArray();
        }

        private static List<string> GetExpandedProperties(IEnumerable<SelectItem> selectedItems)
        {
            var expandProperties = new List<string>();

            foreach (SelectItem item in selectedItems)
            {
                if (item.GetType() == typeof(ExpandedNavigationSelectItem))
                {
                    ExpandedNavigationSelectItem navigationProperty = (ExpandedNavigationSelectItem)item;

                    // Get the name of the property expanded (this way you can control which navigation property you are about to expand)
                    var propertyName = (navigationProperty.PathToNavigationProperty.FirstSegment as NavigationPropertySegment).NavigationProperty.Name;

                    expandProperties.Add(propertyName);

                    if (navigationProperty.SelectAndExpand != null && navigationProperty.SelectAndExpand.SelectedItems.Any())
                    {
                        var subProperties = GetExpandedProperties(navigationProperty.SelectAndExpand.SelectedItems);

                        for (int index = 0; index < subProperties.Count; index++)
                        {
                            subProperties[index] = $"{propertyName}.{subProperties[index]}";
                        }

                        expandProperties.AddRange(subProperties);
                    }
                }
            }

            return expandProperties;
        }
    }
}
