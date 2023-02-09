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
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.InspectionToolsCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// InspectionTools Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("InspectionTools")]

    public class InspectionToolsODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public InspectionToolsODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a InspectionTools list
        /// </summary>
        /// <returns>An queryable object of InspectionToolsModel, <see cref="InspectionToolsModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<InspectionToolsModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.InspectionTools.ProjectToExpand<InspectionToolsModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of InspectionToolss that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of InspectionToolsModel,  <see cref="InspectionToolsModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<InspectionToolsModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.InspectionTools.Where(d => d.Id == id).ProjectToExpand<InspectionToolsModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to retrieve a InspectionTools list
        /// </summary>
        /// <returns>An queryable object of InspectionToolsModel, <see cref="InspectionToolsModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetActiveData")]

        public IQueryable<InspectionToolsModel> GetActiveData(ODataQueryOptions oDataQueryOptions)
        {
            return Context.InspectionTools.Where(d => d.Status == StatusType.Active).ProjectToExpand<InspectionToolsModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


    }
}
