using Microsoft.AspNet.OData.Query;
using Microsoft.OData.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QSS.eIQC.Api.Helpers.Extensions
{
    public static class ODataQueryExtension
    {
        private const string SitePart = "SitePart";
        /// <summary>
        /// Add Odata Options
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="queryOptions"></param>
        public static DataServiceQuery<T> AddODataOptions<T>(this DataServiceQuery<T> query, ODataQueryOptions queryOptions, string serviceName)
        {
            query = AddTop<T>(queryOptions, query);
            query = AddSelectBy(queryOptions, query);
            query = AddSkip(queryOptions, query);
            query = AddFilter(queryOptions, query, serviceName);
            query = AddExapnd(queryOptions, query);
            query = AddOrderBy(queryOptions, query, serviceName);
            query = AddCount(queryOptions, query);

            return query;

        }

        private static DataServiceQuery<T> AddOrderBy<T>(ODataQueryOptions queryOptions, DataServiceQuery<T> query, string serviceName)
        {
            if (queryOptions.OrderBy != null)
            {
                var OrderBy = ReplaceColumnNames(serviceName, queryOptions.OrderBy.RawValue);
                query = query.AddQueryOption("$orderby", OrderBy);
            }
            return query;
        }

        private static DataServiceQuery<T> AddExapnd<T>(ODataQueryOptions queryOptions, DataServiceQuery<T> query)
        {
            if (queryOptions.SelectExpand != null && !string.IsNullOrEmpty(queryOptions.SelectExpand.RawExpand))
                query = query.AddQueryOption("$expand", queryOptions.SelectExpand.RawExpand);
            return query;
        }

        private static DataServiceQuery<T> AddSkip<T>(ODataQueryOptions queryOptions, DataServiceQuery<T> query)
        {
            if (queryOptions.Skip != null)
                query = query.AddQueryOption("$skip", queryOptions.Skip.RawValue);
            return query;
        }

        private static DataServiceQuery<T> AddSelectBy<T>(ODataQueryOptions queryOptions, DataServiceQuery<T> query)
        {
            if (queryOptions.SelectExpand != null)
                query = query.AddQueryOption("$select", queryOptions.SelectExpand.RawSelect);
            return query;
        }

        private static DataServiceQuery<T> AddTop<T>(ODataQueryOptions queryOptions, DataServiceQuery<T> query)
        {
            if (queryOptions.Top != null)
                query = query.AddQueryOption("$top", queryOptions.Top.RawValue);
            return query;
        }

        private static DataServiceQuery<T> AddFilter<T>(ODataQueryOptions queryOptions, DataServiceQuery<T> query, string serviceName)
        {
            if (queryOptions.Filter != null)
            {
                var filters = ReplaceColumnNames(serviceName, queryOptions.Filter.RawValue.ToLower());
                query = query.AddQueryOption("$filter", filters);
            }
            return query;
        }

        private static string ReplaceColumnNames(string serviceName, string rawValue)
        {
            var value = rawValue;
            switch (serviceName)
            {
                case SitePart:
                    {
                        value = rawValue;
                    }
                    break;
                default:
                    break;
            }

            return value;
        }

        private static DataServiceQuery<T> AddCount<T>(ODataQueryOptions queryOptions, DataServiceQuery<T> query)
        {
            //if (queryOptions.Count != null)
            //    query = query.AddQueryOption("$count", queryOptions.Count.RawValue);
            query = query.AddQueryOption("$count", "true");
            return query;
        }
    }
}
