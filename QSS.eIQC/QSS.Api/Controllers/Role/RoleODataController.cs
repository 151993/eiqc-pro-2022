using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.DataAccess.Helpers.Claim;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.RoleCommand;
using System.Linq;
using System.Security.Claims;

namespace QSS.Controllers
{
	/// <summary>
	/// Role Configurations OData controller
	/// </summary>
	[ODataRoutePrefix("Role")]
    
    public class RoleODataController : BaseODataController
    {
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public RoleODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a Role list
        /// </summary>
        /// <returns>An queryable object of RoleModel, <see cref="RoleModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<RoleModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.Role.Include(r => r.Permissions).ProjectToExpand<RoleModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

        /// <summary>
        /// OData API to return a Role matching key 
        /// </summary>
        /// <param name="id">Takes input Role Id as a key</param>
        /// <param name="oDataQueryOptions">Takes oDataQueryOptions as filtering options</param>
        /// <returns>An queryable object of RoleModel,  <see cref="RoleModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<RoleModel> Get([FromODataUri]int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.Role.Where(d => d.Id == id).ProjectToExpand<RoleModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetRoleForNonJabilUser")]
        public IQueryable<RoleModel> GetRoleForNonJabilUser(ODataQueryOptions oDataQueryOptions)
        {
            return Context.Role.Where(d => d.RoleEnumId  == (int)RoleEnum.Supplier || d.RoleEnumId == (int)RoleEnum.Customer).ProjectToExpand<RoleModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetRoleForJabilUser")]
        public IQueryable<RoleModel> GetRoleForJabilUser(ODataQueryOptions oDataQueryOptions)
        {
            return Context.Role.Where(d => d.RoleEnumId != (int)RoleEnum.Supplier && d.RoleEnumId != (int)RoleEnum.Customer).ProjectToExpand<RoleModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
    }
}
