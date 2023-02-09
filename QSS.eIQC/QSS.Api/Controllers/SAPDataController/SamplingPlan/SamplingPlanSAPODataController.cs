/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Handlers.Commands.SAPSamplingPlanCommand;
using QSS.eIQC.SAPHana.Services.Interface;
using QSS.eIQC.SAPHana.Services.Models;
using Reference;
using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Threading.Tasks;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// Part Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("SamplingPlanSAPData")]

    public class SamplingPlanSAPODataController : BaseODataController
    {

        private readonly ISAPHanaClient _sapHanaClient;
        private readonly ISAPeHanaClient _sapeHanaClient;
        private readonly IMapper _mapper;
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        /// <param name="sapHanaClient"></param>
        /// <param name="sapeHanaClient"></param>
        public SamplingPlanSAPODataController(IQSSContext context, IMapper mapper, ISAPHanaClient sapHanaClient, ISAPeHanaClient sapeHanaClient) : base(context, mapper)
        {
            _sapHanaClient = sapHanaClient;
            _sapeHanaClient = sapeHanaClient;
            _mapper = mapper;

        }

        /// <summary>
        /// OData API to retrieve a Part list
        /// </summary>
        /// <returns>An queryable object of PartModel, <see cref="SAPSamplingPlanModel"/></returns>
        [HttpGet]
        // [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public async Task<PageResult<SamplingPlanModel>> GetSamplingPlanDataAsync(ODataQueryOptions queryOptions)
        
        {
            try
            {
                var res = _sapeHanaClient.GetSamplingPlans();
                res = res.AddODataOptions<SAMPLINGPLANType>(queryOptions);

                var result = await Task.Factory.FromAsync(res.BeginExecute, res.EndExecute, null);

                var model = _mapper.Map<IEnumerable<SAMPLINGPLANType>, IEnumerable<SAPSamplingPlanModel>>(result.ToList());

                #region Count
                // We have implemented PageResult explicitly to return the total number of records count that we are getting from the SAP to Odata.
                // Also removed [EnableQuery] attribute to achieve this.

                var pageSize = queryOptions.Top?.Value ?? 10;
                Uri uri = Request.GetNextPageLink(pageSize);
                if (result is QueryOperationResponse sapResult)
                {
                    long? sapCount = queryOptions.Count != null ? sapResult.TotalCount : (long?)null;

                    var latestModel = _mapper.Map<IEnumerable<SAPSamplingPlanModel>, IEnumerable<SamplingPlanModel>>(model.ToList());

                    List<SamplingPlanModel> distinctModel = latestModel.GroupBy(x => new { x.PartNo, x.MstrChar, x.SmplProc })
                                                                    .Select(g => g.FirstOrDefault())
                                                                    .ToList();

                    var pageResultData = new PageResult<SamplingPlanModel>(distinctModel, uri, sapCount);

                    return pageResultData;

              
                }

                #endregion Count

                return null;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }

  

        /// <summary>
        /// checking whether approved inspection plan part number exists in the sampling plan module.
        /// </summary>
        /// <param name="oDataQueryOptions"></param>
        /// <returns></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("CheckPartNumberExistsInSamplingModule")]
        public async Task<IEnumerable<SamplingPlanModel>> CheckPartNumberExistsInSamplingModule(ODataQueryOptions oDataQueryOptions)
        {
            try
            {
                var respSampling = _sapeHanaClient.GetSamplingPlans();
                respSampling = respSampling.AddODataOptions<SAMPLINGPLANType>(oDataQueryOptions);

                var result = await Task.Factory.FromAsync(respSampling.BeginExecute, respSampling.EndExecute, null);

                var sapSamplingPlanModel = _mapper.Map<IEnumerable<SAMPLINGPLANType>, IEnumerable<SAPSamplingPlanModel>>(result.ToList());

                var lstSamplingPlanModel = _mapper.Map<IEnumerable<SAPSamplingPlanModel>, IEnumerable<SamplingPlanModel>>(sapSamplingPlanModel.ToList());

                return lstSamplingPlanModel;
            }
            catch (System.Exception ex)
            {
                throw ex.InnerException;
            }
        }
    }
}
