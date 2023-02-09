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
using QSS.eIQC.Handlers.Commands;
using System.Linq;

namespace QSS.Controllers
{
	/// <summary>
	/// AuditLog Configurations OData controller
	/// </summary>
	[ODataRoutePrefix("AuditLog")]
    public class AuditLogODataController : BaseODataController
    {
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="logger">Injected instance of ILogger of AuditLogODataController on runtime, <see cref="ILogger"/></param>
        /// <param name="context">Injected instance of ITCCSContext on runtime, <see cref="ITCCSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public AuditLogODataController(IQSSContext context,
          IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData api to retrieve a AuditLog list
        /// </summary>
        /// <returns>An queryable object of AuditLogModel, <see cref="AuditLogModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<AuditLogModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.AuditLog.ProjectToExpand<AuditLogModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

        /// <summary>
        /// OData api to return a Department matching key 
        /// </summary>
        /// <param name="id">Takes input AuditLog Id as a key</param>
        /// <param name="oDataQueryOptions">Takes oDataQueryOptions as filtering options</param>
        /// <returns>An queryable object of AuditLogModel,  <see cref="AuditLogModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<AuditLogModel> GetAuditLog([FromODataUri]string id, ODataQueryOptions oDataQueryOptions)
        {
            // TO DO : Query not working, as a workaround  added ToList()
            return Context.AuditLog.ProjectToExpand<AuditLogModel>(Mapper.ConfigurationProvider, oDataQueryOptions)
                .ToList()
                .Where(a => a.AuditData.Metadata.Entity.Id == id)
                .AsQueryable();
        }
    }
}