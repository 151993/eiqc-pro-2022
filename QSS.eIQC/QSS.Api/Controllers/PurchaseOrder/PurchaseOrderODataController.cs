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
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.SAPSync.Interface;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Handlers.Commands.PurchaseOrderCommand;
using production.pu.XS_PU_EIQC_PO;
using QSS.eIQC.Api.Extensions.Environment;
using Microsoft.AspNetCore.Hosting;

namespace QSS.eIQC.Api.Controllers
{
    [ODataRoutePrefix("PurchaseOrder")]
    public class PurchaseOrderODataController : BaseODataController
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
        public PurchaseOrderODataController(IQSSContext context, IMapper mapper, ISAPeHanaClient sapeHanaClient, ISyncSAPDataHelper syncSAPDataHelper
            , IWebHostEnvironment env) : base(context, mapper)
        {
            _sapeHanaClient = sapeHanaClient;
            _mapper = mapper;
            _syncSAPDataHelper = syncSAPDataHelper;
            this._currentEnvironment = env;

        }


        /// <summary>
        /// OData api to retrieve a Country list
        /// </summary>
        /// <returns>An queryable object of PurchaseOrderModel, <see cref="PurchaseOrderModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<PurchaseOrderModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.PurchaseOrder.ProjectToExpand<PurchaseOrderModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData api to return a collection of Suppliers that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">Takes oDataQueryOptions as filtering options</param>
        /// <returns>An queryable object of _SupplierModel,  <see cref="PurchaseOrderModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<PurchaseOrderModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)

        {
            return Context.PurchaseOrder.Where(d => d.Id == id).ProjectToExpand<PurchaseOrderModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

        /// <summary>
        /// OData API to query data from Commodity
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("SyncPurchaseOrderFromSAP")]
        public async Task<PageResult<PurchaseOrderModel>> SyncPurchaseOrderFromSAP(ODataQueryOptions queryOptions)

        {
            try
            {
                DataServiceQuery<POType> res;
                
                res = _sapeHanaClient.GetPurchaseOrderForAllEnv(queryOptions.Filter.RawValue);              

                res = res.AddODataOptions<POType>(queryOptions);

                var result = await Task.Factory.FromAsync(res.BeginExecute, res.EndExecute, null);

                var sapPurchaseOrders = _mapper.Map<IEnumerable<POType>, IEnumerable<SAPPurchaseOrderModel>>(result.ToList());

                if (sapPurchaseOrders.Count() > 0)
                {
                    await _syncSAPDataHelper.SyncPurchaseOrders((IList<SAPPurchaseOrderModel>)sapPurchaseOrders.ToList());
                }
                #region Count
                // We have implemented PageResult explicitly to return the total number of records count that we are getting from the SAP to Odata.
                // Also removed [EnableQuery] attribute to achieve this.

                var pageSize = queryOptions.Top?.Value ?? 10;
                Uri uri = Request.GetNextPageLink(pageSize);
                if (result is QueryOperationResponse sapResult)
                {
                    long? sapCount = queryOptions.Count != null ? sapResult.TotalCount : (long?)null;

                    var model = _mapper.Map<IEnumerable<SAPPurchaseOrderModel>, IEnumerable<PurchaseOrderModel>>(sapPurchaseOrders.ToList());

                    var pageResultData = new PageResult<PurchaseOrderModel>(model, uri, sapCount);

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


        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetPurchaseOrderForSupplier(site={site},vendorCode={vendorCode})")]
        public IQueryable<PurchaseOrderModel> GetPurchaseOrderForSupplier([FromODataUri] string site, [FromODataUri] string vendorCode, ODataQueryOptions oDataQueryOptions)
        {
            return Context.PurchaseOrder
                            .Where(k => k.Site == site.Trim() && k.VendorCode == vendorCode.Trim())
                            .ProjectToExpand<PurchaseOrderModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();

        }

        /// <summary>
        /// checking whether approved inspection plan part number exists in the purchase order module.
        /// </summary>
        /// <param name="oDataQueryOptions"></param>
        /// <returns></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("CheckPartNumberExistsInPurchaseOrderModule")]
        public async Task<IEnumerable<PurchaseOrderModel>> CheckPartNumberExistsInPurchaseOrderModule(ODataQueryOptions oDataQueryOptions)
        {
            try
            {
                DataServiceQuery<POType> res;

                res = _sapeHanaClient.GetPurchaseOrderForAllEnv(oDataQueryOptions.Filter.RawValue);

                res = res.AddODataOptions<POType>(oDataQueryOptions);

                var result = await Task.Factory.FromAsync(res.BeginExecute, res.EndExecute, null);

                var sapPurchaseOrders = _mapper.Map<IEnumerable<POType>, IEnumerable<SAPPurchaseOrderModel>>(result.ToList());

                var lstPurchaseOrderModel = _mapper.Map<IEnumerable<SAPPurchaseOrderModel>, IEnumerable<PurchaseOrderModel>>(sapPurchaseOrders.ToList());

                return lstPurchaseOrderModel;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}
