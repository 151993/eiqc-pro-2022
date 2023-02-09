using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.SAPHana.Services.Interface;
using QSS.eIQC.SAPHana.Services.Models;
using production.pu.XS_PU_COMMODITY_CLASSIFICATION;
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.SAPSync.Interface;
using QSS.eIQC.Api.Extensions.Environment;
using Microsoft.AspNetCore.Hosting;

namespace QSS.eIQC.Api.Controllers
{
    [ODataRoutePrefix("CommodityClassification")]
    public class CommodityClassificationODataController : BaseODataController
    {
        private readonly ISAPeHanaClient _sapeHanaClient;
        private readonly IMapper _mapper;
        private readonly ISyncSAPDataHelper _syncSAPDataHelper;
        private readonly IWebHostEnvironment _currentEnvironment;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        /// <param name="sapeHanaClient">Injected instance of ISAPPartService on runtime</param>
        /// <param name="syncSAPDataHelper">Injected instance of ISyncSAPDataHelper on runtime </param>
        public CommodityClassificationODataController(IQSSContext context, IMapper mapper, ISAPeHanaClient sapeHanaClient,
            ISyncSAPDataHelper syncSAPDataHelper, IWebHostEnvironment env) : base(context, mapper)
        {
            _sapeHanaClient = sapeHanaClient;
            _mapper = mapper;
            _syncSAPDataHelper = syncSAPDataHelper;
            this._currentEnvironment = env;

        }

        /// <summary>
        /// OData API to query data from Commodity
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ODataRoute("")]
        public async Task<PageResult<CommodityClassification>> GetAsync(ODataQueryOptions queryOptions)
        
        {
            try
            {
                DataServiceQuery<COMMODITY_CLASSType> res;

                res = _sapeHanaClient.GetCommodityClassficationForAllEnv(queryOptions.Filter.RawValue);
                
                res = res.AddODataOptions<COMMODITY_CLASSType>(queryOptions);
                var result = await Task.Factory.FromAsync(res.BeginExecute, res.EndExecute, null);

                var model = _mapper.Map<IEnumerable<COMMODITY_CLASSType>, IEnumerable<CommodityClassification>>(result.ToList());

                var sapCommodities = _mapper.Map<IEnumerable<CommodityClassification>, IEnumerable<SAPCommodity>>(model.ToList());

                await _syncSAPDataHelper.SyncCommodity((IList<SAPCommodity>)sapCommodities.ToList());

                #region Count
                // We have implemented PageResult explicitly to return the total number of records count that we are getting from the SAP to Odata.
                // Also removed [EnableQuery] attribute to achieve this.

                var pageSize = queryOptions.Top?.Value ?? 10;
                Uri uri = Request.GetNextPageLink(pageSize);
                if (result is QueryOperationResponse sapResult)
                {
                    long? sapCount = queryOptions.Count != null ? sapResult.TotalCount : (long?)null;

                    var pageResultData = new PageResult<CommodityClassification>(model, uri, sapCount);

                    return pageResultData;
                }

                #endregion Count

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
