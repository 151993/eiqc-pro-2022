using Microsoft.AspNet.OData.Query;
using System.Data.Services.Client;
using System.Text.RegularExpressions;

namespace QSS.eIQC.Api.Helpers.Extensions
{
    public static class DataServiceQueryExtension
    {
        private const string OrderBy = "$orderby";
        private const string Expand = "$expand";
        private const string Skip = "$skip";
        private const string Select = "$select";
        private const string Top = "$top";
        private const string Contains = @"contains\(([^']+),'([^']*)'\)";
        private const string Substringof = @"substringof('$2',$1)";
        private const string Filter = "$filter";
        private const string InlineCount = "$inlinecount";
        private const string AllPages = "allpages";

        /// <summary>
        /// Add Odata Options
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="queryOptions"></param>
        public static DataServiceQuery<T> AddODataOptions<T>(this DataServiceQuery<T> query, ODataQueryOptions queryOptions)
        {
            query = AddTop<T>(queryOptions, query);
            query = AddSelectBy(queryOptions, query);
            query = AddSkip(queryOptions, query);
            query = AddFilter(queryOptions, query);
            query = AddExapnd(queryOptions, query);
            query = AddOrderBy(queryOptions, query);
            query = AddCount(queryOptions, query);

            return query;

        }

        private static DataServiceQuery<T> AddOrderBy<T>(ODataQueryOptions queryOptions, DataServiceQuery<T> query)
        {
            if (queryOptions.OrderBy != null && queryOptions.RawValues.OrderBy != "partNumber asc")
                query = query.AddQueryOption(OrderBy, queryOptions.OrderBy.RawValue);
            return query;
        }

        private static DataServiceQuery<T> AddExapnd<T>(ODataQueryOptions queryOptions, DataServiceQuery<T> query)
        {
            if (queryOptions.SelectExpand != null && !string.IsNullOrEmpty(queryOptions.SelectExpand.RawExpand))
                query = query.AddQueryOption(Expand, queryOptions.SelectExpand.RawExpand);
            return query;
        }

        private static DataServiceQuery<T> AddSkip<T>(ODataQueryOptions queryOptions, DataServiceQuery<T> query)
        {
            if (queryOptions.Skip != null)
                query = query.AddQueryOption(Skip, queryOptions.Skip.RawValue);
            return query;
        }

        private static DataServiceQuery<T> AddSelectBy<T>(ODataQueryOptions queryOptions, DataServiceQuery<T> query)
        {
            if (queryOptions.SelectExpand != null)
                query = query.AddQueryOption(Select, queryOptions.SelectExpand.RawSelect);
            return query;
        }

        private static DataServiceQuery<T> AddTop<T>(ODataQueryOptions queryOptions, DataServiceQuery<T> query)
        {
            if (queryOptions.Top != null)
                query = query.AddQueryOption(Top, queryOptions.Top.RawValue);
            return query;
        }

        private static DataServiceQuery<T> AddFilter<T>(ODataQueryOptions queryOptions, DataServiceQuery<T> query)
        {
            if (queryOptions.Filter != null)
            {
                var containsRegx = new Regex(Contains);
            // https://community.dynamics.com/crm/b/mscrmshop/posts/crm-odata-rest-queries-and-special-characters
                string inputFilter = queryOptions.Filter.RawValue.Replace("#", "%23");
                if (queryOptions.Filter.RawValue.Contains("null"))
                {
                    inputFilter = queryOptions.Filter.RawValue.Replace("null", "'null'");
                }
                var filter = containsRegx.Replace(inputFilter, Substringof);
                query = query.AddQueryOption(Filter, filter);
            }
            return query;
        }
      

        private static DataServiceQuery<T> AddCount<T>(ODataQueryOptions queryOptions, DataServiceQuery<T> query)
        {
            if (queryOptions.Count != null)
            {
                if (queryOptions.Count.RawValue == "true")
                    query = query.AddQueryOption(InlineCount, AllPages);
                else
                    query = query.AddQueryOption(InlineCount, AllPages);
            }
            return query;
        }

    }
}
