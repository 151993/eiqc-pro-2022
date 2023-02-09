using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Handlers.Commands.RegionCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
	/// <summary>
	/// Region Configurations OData controller
	/// </summary>
	[ODataRoutePrefix("Region")]
    
    public class RegionODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of RegionODataController on runtime, <see cref="ILogger"/></param>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public RegionODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData api to retrieve a User list
        /// </summary>
        /// <returns>An queryable object of _RegionModel, <see cref="RegionModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<RegionModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.Region.ProjectToExpand<RegionModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData api to return a collection of Regions that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">Takes oDataQueryOptions as filtering options</param>
        /// <returns>An queryable object of _RegionModel,  <see cref="RegionModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<RegionModel> Get([FromODataUri]int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.Region.Where(d => d.Id == id).ProjectToExpand<RegionModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
