using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNet.OData.Query;
using System.Linq;

namespace QSS.eIQC.Api.Helpers.Extensions
{
    /// <summary>
    /// AutoMapper ProjectToExpand
    /// </summary>
    public static class AutoMapperExtensions
    {
        /// <summary>
        /// Extension method for AutoMapper ProjectTo
        /// </summary>
        /// <typeparam name="TDestination"></typeparam>
        /// <param name="source">source</param>
        /// <param name="configuration">configuration</param>
        /// <param name="query">query</param>
        /// <returns></returns>
        public static IQueryable<TDestination> ProjectToExpand<TDestination>(this IQueryable source, IConfigurationProvider configuration, ODataQueryOptions query)
        {
            return source.ProjectTo<TDestination>(configuration, null, query.ToExpandedProperties<TDestination>());
        }
    }
}
