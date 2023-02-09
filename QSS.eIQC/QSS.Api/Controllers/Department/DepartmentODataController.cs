using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Handlers.Commands.DepartmentCommand;
using System.Linq;

namespace iFactory.DataMigration.API.Controllers
{
	/// <summary>
	/// Department Configurations OData controller
	/// </summary>
	[ODataRoutePrefix("Department")]
    
    public class DepartmentODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of DepartmentODataController on runtime, <see cref="ILogger"/></param>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public DepartmentODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData api to retrieve a User list
        /// </summary>
        /// <returns>An queryable object of _DepartmentModel, <see cref="DepartmentModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<DepartmentModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.Department.ProjectToExpand<DepartmentModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData api to return a collection of Departments that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">Takes oDataQueryOptions as filtering options</param>
        /// <returns>An queryable object of _DepartmentModel,  <see cref="DepartmentModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<DepartmentModel> Get([FromODataUri]int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.Department.Where(d => d.Id == id).ProjectToExpand<DepartmentModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
