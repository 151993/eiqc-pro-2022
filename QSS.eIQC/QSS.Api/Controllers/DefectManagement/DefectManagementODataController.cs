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
using QSS.eIQC.Handlers.Commands.DefectManagementCommand;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// DefectManagement Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("DefectManagement")]

    public class DefectManagementODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public DefectManagementODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a DefectManagement list
        /// </summary>
        /// <returns>An queryable object of DefectManagementModel, <see cref="DefectManagementModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<DefectManagementModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.DefectManagement.ProjectToExpand<DefectManagementModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of DefectManagements that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of DefectManagementModel,  <see cref="DefectManagementModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<DefectManagementModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.DefectManagement.Where(d => d.Id == id).ProjectToExpand<DefectManagementModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

    }
}
