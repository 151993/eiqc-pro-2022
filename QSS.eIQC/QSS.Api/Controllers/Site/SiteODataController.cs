/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Handlers.Commands.SiteCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// Site Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("Site")]

    public class SiteODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public SiteODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a Site list
        /// </summary>
        /// <returns>An queryable object of SiteModel, <see cref="SiteModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<SiteModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.Site.ProjectToExpand<SiteModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of Sites that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">Takes oDataQueryOptions as filtering options</param>
        /// <returns>An queryable object of SiteModel,  <see cref="SiteModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<SiteModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.Site.Where(d => d.Id == id).ProjectToExpand<SiteModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
