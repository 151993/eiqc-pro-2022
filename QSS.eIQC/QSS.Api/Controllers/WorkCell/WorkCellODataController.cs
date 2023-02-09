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
using QSS.eIQC.Handlers.Commands.WorkCellCommand;
using System.Linq;



namespace QSS.eIQC.API.Controllers
{
    [ODataRoutePrefix("WorkCell")]
    public class WorkCellODataController : BaseODataController
    {
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public WorkCellODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData api to retrieve a User list
        /// </summary>
        /// <returns>An queryable object of _WorkCellsModel, <see cref="WorkCellModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<WorkCellModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.WorkCell.ProjectToExpand<WorkCellModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData api to return a collection of workcell that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">oDataQueryOptions</param>
        /// <returns>An queryable object of _WorkCellsModel,  <see cref="WorkCellModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<WorkCellModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.WorkCell.Where(d => d.Id == id).ProjectToExpand<WorkCellModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetWorkCellByUserAndSite(userId={userId},siteId={siteId})")]
        public IQueryable<WorkCellModel> GetWorkCellByUserAndSite([FromODataUri] int userId, [FromODataUri] int siteId, ODataQueryOptions oDataQueryOptions)
        {
            var result = (from wcu in Context.WorkCellUser
                          join wcj in Context.WorkCellJabilUser on wcu.Id equals wcj.WorkCellUserId
                          join wc in Context.WorkCell on wcu.WorkCellId equals wc.Id
                          where wcj.UserId == userId && wcu.SiteId == siteId && wc.Status == StatusType.Active
                          select new WorkCellModel()
                          {     
                              Id = wc.Id,
                              Name = wc.Name,                              
                              IsEnabled = (wcu.Status == StatusType.Active)
                          }).Distinct();

            var returnobj = result.ProjectToExpand<WorkCellModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();

            return returnobj;

        }

        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetAllWorkCellBySite(siteId={siteId})")]
        public IQueryable<WorkCellModel> GetAllWorkCellBySite([FromODataUri] int siteId, ODataQueryOptions oDataQueryOptions)
        {

            var result = (from wc in Context.WorkCell
                          join wcs in Context.WorkCellSite on wc.Id equals wcs.WorkCellId

                          where wcs.SiteId == siteId
                          select wc);

            var returnobj = result.ProjectToExpand<WorkCellModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();

            return returnobj;
        }
    }
}
