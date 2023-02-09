using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using production.pu.XS_PU_EIQC_SUPPLIER;
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Handlers.Commands.SupplierCommand;
using QSS.eIQC.SAPHana.Services.Interface;
using QSS.eIQC.SAPHana.Services.Models;
using QSS.eIQC.SAPSync.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;
using System.Data.Services.Client;
using Microsoft.AspNet.OData.Extensions;
using QSS.Infrastructure.Core.QSSGatewayAPI.Model;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Hosting;
using QSS.eIQC.Api.Extensions.Environment;

namespace QSS.eIQC.API.Controllers
{
    /// <summary>
    /// Supplier Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("Supplier")]
    public class SupplierODataController : BaseODataController
    {
        private readonly ISAPeHanaClient _sapHanaClient;
        private readonly IMapper _mapper;
        private readonly ISyncSAPDataHelper _syncSAPDataHelper;
        private IOptionsSnapshot<QSSGatewayAPIOptions> _qssGatewayAPIOptions;
        private readonly IWebHostEnvironment _currentEnvironment;
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public SupplierODataController(IQSSContext context, IMapper mapper, ISAPeHanaClient sapeHanaClient,
            ISyncSAPDataHelper syncSAPDataHelper, IOptionsSnapshot<QSSGatewayAPIOptions> qssGatewayAPIOptions, IWebHostEnvironment env) : base(context, mapper)
        {
            _sapHanaClient = sapeHanaClient;
            _mapper = mapper;
            _syncSAPDataHelper = syncSAPDataHelper;
            _qssGatewayAPIOptions = qssGatewayAPIOptions;
            this._currentEnvironment = env;
        }

        /// <summary>
        /// OData api to retrieve a Country list
        /// </summary>
        /// <returns>An queryable object of _SupplierModel, <see cref="SupplierModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public IQueryable<SupplierModel> Get(ODataQueryOptions oDataQueryOptions)
        {
            return Context.Supplier.ProjectToExpand<SupplierModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }


        /// <summary>
        /// OData api to return a collection of Suppliers that matches with the input
        /// </summary>
        /// <param name="id">Takes input id as a key</param>
        /// <param name="oDataQueryOptions">Takes oDataQueryOptions as filtering options</param>
        /// <returns>An queryable object of _SupplierModel,  <see cref="SupplierModel"/></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("({id})")]
        public IQueryable<SupplierModel> Get([FromODataUri] int id, ODataQueryOptions oDataQueryOptions)

        {
            return Context.Supplier.Where(d => d.Id == id).ProjectToExpand<SupplierModel>(Mapper.ConfigurationProvider, oDataQueryOptions).AsQueryable();
        }

        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("SyncSupplierFromSAP")]
        public async Task<PageResult<SupplierModel>> SyncSupplierFromSAP(ODataQueryOptions queryOptions)
        {
            DataServiceQuery<SUPPLIERType> res;

            res = _sapHanaClient.GetSuppliersForAllEnv(queryOptions.Filter.RawValue, out string valuationArea);


            res = res.AddODataOptions<SUPPLIERType>(queryOptions);

            var result = await Task.Factory.FromAsync(res.BeginExecute, res.EndExecute, null);

            var sapSuppliers = _mapper.Map<IEnumerable<SUPPLIERType>, IEnumerable<SAPSupplierModel>>(result.ToList());

            if (sapSuppliers.Count() > 0)
            {
                int count = sapSuppliers.Count();
                int batchSize = _qssGatewayAPIOptions.Value.BatchSize;
                int batchNumbers = count / batchSize;
                for (int i = 0; i <= batchNumbers; i++)
                {
                    var supplier = sapSuppliers.Skip(i * batchSize).Take(batchSize).ToList();
                    _syncSAPDataHelper.SyncSuppliers((IList<SAPSupplierModel>)supplier, valuationArea);

                }
            }


            #region Count
            // We have implemented PageResult explicitly to return the total number of records count that we are getting from the SAP to Odata.
            // Also removed [EnableQuery] attribute to achieve this.

            var pageSize = queryOptions.Top?.Value ?? 10;
            Uri uri = Request.GetNextPageLink(pageSize);

            if (result is QueryOperationResponse sapResult)
            {
                long? sapCount = queryOptions.Count != null ? sapResult.TotalCount : (long?)null;

                var pageResultModel = _mapper.Map<IEnumerable<SAPSupplierModel>, IEnumerable<SupplierModel>>(sapSuppliers.ToList());
                var pageResultData = new PageResult<SupplierModel>(pageResultModel, uri, sapCount);

                return pageResultData;
            }

            #endregion Count

            return null;
        }
    }
}
