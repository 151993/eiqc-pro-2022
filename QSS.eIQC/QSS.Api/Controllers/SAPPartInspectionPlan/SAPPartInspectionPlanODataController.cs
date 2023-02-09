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
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SAPPartInspectionPlan Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("SAPPartInspectionPlan")]

    public class SAPPartInspectionPlanODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public SAPPartInspectionPlanODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a SAPPartInspectionPlan list
        /// </summary>
        /// <returns>An queryable object of SAPPartInspectionPlanModel, <see cref="SAPPartInspectionPlanModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS( HandleNullPropagation = HandleNullPropagationOption.True)]
        [ODataRoute("")]
        public IQueryable<SAPPartInspectionPlanModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.SAPPartInspectionPlan.ProjectToExpand<SAPPartInspectionPlanModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of SAPPartInspectionPlans that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of SAPPartInspectionPlanModel,  <see cref="SAPPartInspectionPlanModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<SAPPartInspectionPlanModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.SAPPartInspectionPlan.Where(d => d.Id == id).ProjectToExpand<SAPPartInspectionPlanModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetDccTasksData(siteId={siteId})")]
        public IQueryable<SAPPartInspectionPlanModel> GetDccTasksData([FromODataUri] int siteId, ODataQueryOptions oDataQueryOptions)
        {
            var dccApprovalWorkCellIds = (from wc in Context.WorkCellUser
                          join dcc in Context.DCCConfiguration on wc.SiteId equals dcc.SiteId
                          where wc.IsDccApproval == true && wc.SiteId == siteId
                          select new { wc.WorkCellId }).Distinct().ToList();
            
            List<int> workCellIds = new List<int>();
            foreach(var i in dccApprovalWorkCellIds)
            {
                workCellIds.Add(i.WorkCellId);
            }
            return Context.SAPPartInspectionPlan.Where(d => workCellIds.Contains((int)d.WorkCellId)).ProjectToExpand<SAPPartInspectionPlanModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

       
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetCompletelyApprovedIPPartNoForSupplier(supplierId={supplierId})")]
        public IQueryable<SAPPartInspectionPlanModel> GetCompletelyApprovedIPPartNoForSupplier([FromODataUri] int supplierId,ODataQueryOptions oDataQueryOptions)
        {
            var fullyApprovedByDCC = (from ip in Context.SAPPartInspectionPlan
                                 join wu in Context.WorkCellUser on ip.WorkCellId equals wu.WorkCellId
                                 where ip.StateTypeId == (int)StateType.Approved_By_DCC && wu.IsDccApproval==true && ip.SupplierId== supplierId
                                 join su in Context.Supplier on ip.SupplierId equals su.Id
                                 select new {ip }).ToList();

            var fullyApprovedBySQE = (from ip in Context.SAPPartInspectionPlan
                                 join wu in Context.WorkCellUser on ip.WorkCellId equals wu.WorkCellId
                                 where ip.StateTypeId == (int)StateType.Approved_By_SQE && (wu.IsDccApproval!=true || wu.IsDccApproval == null) && ip.SupplierId == supplierId
                                 join su in Context.Supplier on ip.SupplierId equals su.Id
                                 select new { ip }).ToList();

            IEnumerable<int> fullyApprovedInspectionPanIds = fullyApprovedByDCC.Union(fullyApprovedBySQE).Select(k=>k.ip.Id);

            return Context.SAPPartInspectionPlan
                .Where(k=>fullyApprovedInspectionPanIds.Contains(k.Id))
                .ProjectToExpand<SAPPartInspectionPlanModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }
        
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetApprovedRejectDataByUser(userId={userId})")]
        public IQueryable<SAPPartInspectionPlanModel> GetApprovedRejectDataByUser([FromODataUri] int userId, ODataQueryOptions oDataQueryOptions)
        {
            return Context.SAPPartInspectionPlan.Where(d => d.ApproveRejectedId == userId).ProjectToExpand<SAPPartInspectionPlanModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetApprovedRejectedDataBySite(siteId={siteId})")]
        public IQueryable<SAPPartInspectionPlanModel> GetApprovedRejectedDataBySite([FromODataUri] int siteId, ODataQueryOptions oDataQueryOptions)
        {
            var siteDetails = Context.Site.FirstOrDefault(x => x.Id == siteId);

            var fullyApprovedRejectedByDCC = (from ip in Context.SAPPartInspectionPlan
                                      join wu in Context.WorkCellUser on ip.WorkCellId equals wu.WorkCellId
                                      where (ip.StateTypeId == (int)StateType.Approved_By_DCC || ip.StateTypeId == (int)StateType.Rejected_By_DCC) && wu.IsDccApproval == true && wu.SiteId == siteId
                                      select new { ip }).ToList();

            var fullyApprovedRejectedBySQE = (from ip in Context.SAPPartInspectionPlan
                                      where (ip.StateTypeId == (int)StateType.Approved_By_SQE || ip.StateTypeId == (int)StateType.Rejected_By_SQE) && ip.IP.StartsWith(siteDetails.Code)
                                      select new { ip }).ToList();

            IEnumerable<int> fullyApprovedRejectedInspectionPanIds = fullyApprovedRejectedByDCC.Union(fullyApprovedRejectedBySQE).Select(k => k.ip.Id);
            
            return Context.SAPPartInspectionPlan.Where(k => fullyApprovedRejectedInspectionPanIds.Contains(k.Id))
                .ProjectToExpand<SAPPartInspectionPlanModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetSQEDCCApprovedDataByUser(userTypeId={userTypeId},userId={userId})")]
        public IQueryable<SAPPartInspectionPlanModel> GetSQEDCCApprovedDataByUser([FromODataUri] int userTypeId, [FromODataUri] int userId, ODataQueryOptions oDataQueryOptions)
        { 
            if (userTypeId ==(int) UserType.Supplier)
            {
                var fullyApprovedByDCC = (from ip in Context.SAPPartInspectionPlan
                                          join wu in Context.WorkCellUser on ip.WorkCellId equals wu.WorkCellId
                                          where ip.StateTypeId == (int)StateType.Approved_By_DCC && wu.IsDccApproval == true && ip.SupplierId == userId
                                          join su in Context.Supplier on ip.SupplierId equals su.Id
                                          select new { ip }).ToList();

                var fullyApprovedBySQE = (from ip in Context.SAPPartInspectionPlan
                                          join wu in Context.WorkCellUser on ip.WorkCellId equals wu.WorkCellId
                                          where ip.StateTypeId == (int)StateType.Approved_By_SQE && (wu.IsDccApproval != true || wu.IsDccApproval == null) && ip.SupplierId == userId
                                          join su in Context.Supplier on ip.SupplierId equals su.Id
                                          select new { ip }).ToList();

                IEnumerable<int> fullyApprovedInspectionPanIds = fullyApprovedByDCC.Union(fullyApprovedBySQE).Select(k => k.ip.Id);

                return Context.SAPPartInspectionPlan
                .Where(k => fullyApprovedInspectionPanIds.Contains(k.Id))
                .ProjectToExpand<SAPPartInspectionPlanModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
            }
            else
            {
                var fullyApprovedByDCC = (from ip in Context.SAPPartInspectionPlan
                                          join wu in Context.WorkCellUser on ip.WorkCellId equals wu.WorkCellId
                                          where ip.StateTypeId == (int)StateType.Approved_By_DCC && wu.IsDccApproval == true && ip.ApproveRejectedId == userId
                                          join su in Context.Supplier on ip.SupplierId equals su.Id
                                          select new { ip }).ToList();

                var fullyApprovedBySQE = (from ip in Context.SAPPartInspectionPlan
                                          join wu in Context.WorkCellUser on ip.WorkCellId equals wu.WorkCellId
                                          where ip.StateTypeId == (int)StateType.Approved_By_SQE && (wu.IsDccApproval != true || wu.IsDccApproval == null) && ip.ApproveRejectedId == userId
                                          join su in Context.Supplier on ip.SupplierId equals su.Id
                                          select new { ip }).ToList();

                IEnumerable<int> fullyApprovedInspectionPanIds = fullyApprovedByDCC.Union(fullyApprovedBySQE).Select(k => k.ip.Id);

                return Context.SAPPartInspectionPlan
                .Where(k => fullyApprovedInspectionPanIds.Contains(k.Id))
                .ProjectToExpand<SAPPartInspectionPlanModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
               
            }
        }
    }
}
