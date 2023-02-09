using Microsoft.AspNet.OData.Query;
using Microsoft.OData.UriParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace QSS.eIQC.Api.Helpers.Filters
{
	public static class ODataExpand
	{
		public static string[] GetMembersToExpandNames(ODataQueryOptions options)
		{
			return GetExpandPropertyPaths(GetExpandItems(options?.SelectExpand?.SelectExpandClause)).ToArray();
		}

		private static IEnumerable<string> GetExpandPropertyPaths(IEnumerable<ExpandedNavigationSelectItem> items, string prefix = "")
		{
			foreach (var item in items)
			{
				foreach (var res in GetExpandPropertyPaths(item, prefix))
				{
					yield return res;
				}
			}
		}

		private static IEnumerable<string> GetExpandPropertyPaths(ExpandedNavigationSelectItem item, string prefix = "")
		{
			var curPropName = item.NavigationSource.Name;
			var nestedExpand = GetExpandItems(item.SelectAndExpand).ToArray();
			if (nestedExpand.Count() > 0)
			{
				foreach (var res in GetExpandPropertyPaths(nestedExpand, $"{prefix}{curPropName}."))
				{
					yield return res;
				}
			}
			else
			{
				yield return $"{prefix}{curPropName}";
			}
		}

		private static IEnumerable<ExpandedNavigationSelectItem> GetExpandItems(SelectExpandClause sec)
		{
			if (sec != null)
			{
				var res = sec?.SelectedItems?.OfType<ExpandedNavigationSelectItem>();
				if (res != null)
				{
					return res;
				}
			}
			return new ExpandedNavigationSelectItem[0];
		}

		public static bool IsNavigationPropertyExpected<TSource, TKey>(this ODataQueryOptions<TSource> source, Expression<Func<TSource, TKey>> keySelector)
		{
			if (source == null) { throw new ArgumentNullException("source"); }
			if (keySelector == null) { throw new ArgumentNullException("keySelector"); }

			var returnValue = false;
			var propertyName = (keySelector.Body as MemberExpression ?? ((UnaryExpression)keySelector.Body).Operand as MemberExpression).Member.Name;
			var expandProperties = source.SelectExpand == null || string.IsNullOrWhiteSpace(source.SelectExpand.RawExpand) ? new List<string>().ToArray() : source.SelectExpand.RawExpand.Split(',');
			var selectProperties = source.SelectExpand == null || string.IsNullOrWhiteSpace(source.SelectExpand.RawSelect) ? new List<string>().ToArray() : source.SelectExpand.RawSelect.Split(',');

			returnValue = returnValue ^ expandProperties.Contains<string>(propertyName);
			returnValue = returnValue ^ selectProperties.Contains<string>(propertyName);

			return returnValue;
		}
	}
}
