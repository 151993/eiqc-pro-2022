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
using QSS.eIQC.Handlers.Commands.PartCountParameterCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// PartCountParameter Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("PartCountParameter")]

    public class PartCountParameterODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public PartCountParameterODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a PartCountParameter list
        /// </summary>
        /// <returns>An queryable object of PartCountParameterModel, <see cref="PartCountParameterModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<PartCountParameterModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.PartCountParameter.ProjectToExpand<PartCountParameterModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of PartCountParameters that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of PartCountParameterModel,  <see cref="PartCountParameterModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<PartCountParameterModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.PartCountParameter.Where(d => d.Id == id).ProjectToExpand<PartCountParameterModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
