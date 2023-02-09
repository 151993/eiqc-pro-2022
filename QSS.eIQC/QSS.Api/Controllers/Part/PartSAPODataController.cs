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
using QSS.eIQC.Handlers.Commands.CommodityCommand;
using QSS.eIQC.Handlers.Commands.PartCommand;
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
    [ODataRoutePrefix("PartSAPData")]

    public class PartSAPODataController : BaseODataController
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
        public PartSAPODataController(IQSSContext context, IMapper mapper, ISAPHanaClient sapHanaClient, ISAPeHanaClient sapeHanaClient) : base(context, mapper)
        {
            _sapHanaClient = sapHanaClient;
            _sapeHanaClient = sapeHanaClient;
            _mapper = mapper;
            
        }

        /// <summary>
        /// OData API to retrieve a Part list
        /// </summary>
        /// <returns>An queryable object of PartModel, <see cref="SAPPartModel"/></returns>
        [HttpGet]
       // [EnableQueryFromODataToAWS]
        [ODataRoute("")]
        public async Task<PageResult<SAPPartModel>> GetPartDataAsync(ODataQueryOptions queryOptions)
        {
            try
            {
                var res = _sapeHanaClient.GetPartNumber();
                res = res.AddODataOptions<PARTNUMBER_BY_SITEType>(queryOptions);

                var result = await Task.Factory.FromAsync(res.BeginExecute, res.EndExecute, null);

                var model = _mapper.Map<IEnumerable<PARTNUMBER_BY_SITEType>, IEnumerable<PartNumberBySiteModel>>(result.ToList());

                var sapParts = _mapper.Map<IEnumerable<PartNumberBySiteModel>, IEnumerable<SAPPartModel>>(model.ToList());

                sapParts = sapParts.Where(k => k.PartNo != "#N/A");

                foreach(var part in sapParts)
                {
                    part.Commodity = (from cm in Context.Commodity
                                           join cmps in Context.CommodityPartNumberSite on cm.Id equals cmps.CommodityId
                                           where cmps.PartNumber == part.PartNo
                                           select cm.Name).FirstOrDefault();
                }

                #region Count
                // We have implemented PageResult explicitly to return the total number of records count that we are getting from the SAP to Odata.
                // Also removed [EnableQuery] attribute to achieve this.

                var pageSize = queryOptions.Top?.Value ?? 10;
                Uri uri = Request.GetNextPageLink(pageSize);
                if (result is QueryOperationResponse sapResult)
                {
                    long? sapCount = queryOptions.Count != null ? sapResult.TotalCount : (long?)null;

                    var pageResultData = new PageResult<SAPPartModel>(sapParts, uri, sapCount);

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
