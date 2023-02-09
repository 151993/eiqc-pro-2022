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
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// ParameterManagement Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("ParameterManagement")]

    public class ParameterManagementODataController : BaseODataController
    {

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public ParameterManagementODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        /// <summary>
        /// OData API to retrieve a ParameterManagement list
        /// </summary>
        /// <returns>An queryable object of ParameterManagementModel, <see cref="ParameterManagementModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<ParameterManagementModel> Get(ODataQueryOptions oDataQueryOptions)

        {
            return Context.ParameterManagement.ProjectToExpand<ParameterManagementModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData API to return a collection of ParameterManagements that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of ParameterManagementModel,  <see cref="ParameterManagementModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<ParameterManagementModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)
        {
            return Context.ParameterManagement.Where(d => d.Id == id).ProjectToExpand<ParameterManagementModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

        /// <summary>
        /// OData API to return a collection of ParameterManagements that matches with the input
        /// </summary>
        /// <param name="commodityId">Takes input commodityId as a key</param>
        /// <param name="pcNames"></param>
        /// <param name="oDataQueryOptions">OdataQueryOptions as input</param>
        /// <returns>An queryable object of ParameterManagementModel,  <see cref="ParameterManagementModel"/></returns>

        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetParameterManagementDataByCommodityId(commodityId={commodityId},pcNames={pcNames})")]
        public IQueryable<ParameterManagementModel> GetParameterManagementDataByCommodityId([FromODataUri] int commodityId, [FromODataUri] string pcNames, ODataQueryOptions oDataQueryOptions)
        {
            string[] pcCodes = pcNames.Split(',');
            var pmcd = (from pm in Context.ParameterManagement
                       join pmc in Context.ParameterManagementCommodity on pm.Id equals pmc.ParameterManagementId
                       join ptc in Context.ParameterTypeCode on pm.ParameterTypeCodeId equals ptc.Id
                       join ptpc in Context.ParameterTypePcCode on ptc.Id equals ptpc.ParameterTypeCodeId
                       join pcc in  Context.PCCode on ptpc.PCCodeId equals pcc.Id
                       join pmt in Context.ParameterManagementType on ptc.ParameterManagementTypeId equals pmt.Id
                       where pmc.CommodityId == commodityId && pcCodes.Contains(pcc.Code)
                       select new ParameterManagementModel()
                       {
                           Name = pm.Name,
                           Description = pm.Description,
                           ParameterTypeCodeId = pm.ParameterTypeCodeId,
                           Id = pm.Id,
                           IsEnabled = !(pm.Status == StatusType.Active),
                           IsChecked = (pm.Status == StatusType.Active),
                           ParameterManagementTypeId = ptc.ParameterManagementTypeId
                       }).Distinct();
            return (IQueryable<ParameterManagementModel>)pmcd.ToList().AsQueryable();
        }

    }
}
