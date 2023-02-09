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
using QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// InspectionToolsType Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("InspectionToolsType")]

    public class InspectionToolsTypeODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public InspectionToolsTypeODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a InspectionToolsType list
        /// </summary>
        /// <returns>An queryable object of InspectionToolsTypeModel, <see cref="InspectionToolsTypeModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<InspectionToolsTypeModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.InspectionToolsType.ProjectToExpand<InspectionToolsTypeModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of InspectionToolsTypes that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">Takes oDataQueryOptions as filtering options</param>
        /// <returns>An queryable object of InspectionToolsTypeModel,  <see cref="InspectionToolsTypeModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<InspectionToolsTypeModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.InspectionToolsType.Where(d => d.Id == id).ProjectToExpand<InspectionToolsTypeModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
