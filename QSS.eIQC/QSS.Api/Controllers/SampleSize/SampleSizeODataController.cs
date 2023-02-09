/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using production.pu.XS_PU_SAMPLESIZECALC;
using QSS.eIQC.Api.Extensions.Environment;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// Part Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("SAPSampleSize")]

    public class SampleSizeODataController : BaseODataController
    {

        private readonly ISAPeHanaClient _sapeHanaClient;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _currentEnvironment;
        private readonly ILogger<SampleSizeODataController> _logger;

        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        /// <param name="sapeHanaClient"></param>
        public SampleSizeODataController(IQSSContext context, IMapper mapper, ISAPeHanaClient sapeHanaClient, IWebHostEnvironment env, ILogger<SampleSizeODataController> logger) : base(context, mapper)
        {
            _logger = logger;
            _sapeHanaClient = sapeHanaClient;
            _mapper = mapper;
            this._currentEnvironment = env;

        }

        /// <summary>
        /// OData API to retrieve a Part list
        /// </summary>
        /// <returns>An queryable object of PartModel, <see cref="SAPSampleSizeCalcModel"/></returns>
        [HttpGet]
        [ODataRoute("")]
        public async Task<PageResult<SAPSampleSizeCalcModel>> GetPartDataAsync(ODataQueryOptions queryOptions)
        {
            try
            {

                DataServiceQuery<SAMPLESIZECALCType> res;
                res = _sapeHanaClient.GetSampleSizeForHAD(queryOptions.Filter.RawValue);

                //if (_currentEnvironment.IsDevelopement())
                //{
                //    res = _sapeHanaClient.GetSampleSizeForHAD(queryOptions.Filter.RawValue);
                //}
                //else
                //{
                //    res = _sapeHanaClient.GetSampleSize();
                //}

                res = res.AddODataOptions<SAMPLESIZECALCType>(queryOptions);



                var result = await Task.Factory.FromAsync(res.BeginExecute, res.EndExecute, null);

                var model = _mapper.Map<IEnumerable<SAMPLESIZECALCType>, IEnumerable<SAPSampleSizeModel>>(result.ToList());

                var sapParts = _mapper.Map<IEnumerable<SAPSampleSizeModel>, IEnumerable<SAPSampleSizeCalcModel>>(model.ToList());


                #region Count

                var pageSize = queryOptions.Top?.Value ?? 10;
                Uri uri = Request.GetNextPageLink(pageSize);
                if (result is QueryOperationResponse sapResult)
                {
                    long? sapCount = queryOptions.Count != null ? sapResult.TotalCount : (long?)null;

                    var pageResultData = new PageResult<SAPSampleSizeCalcModel>(sapParts, uri, sapCount);

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


        [HttpGet]
        [ODataRoute("GetSampleSize(batchQuantity={batchQuantity},smplProc={smplProc})")]
        public async Task<IEnumerable<SAPSampleSizeCalcModel>> GetSampleSize([FromODataUri] int batchQuantity, [FromODataUri] string smplProc, ODataQueryOptions queryOptions)
        {
            try
            {
                DataServiceQuery<SAMPLESIZECALCType> res;
                res = _sapeHanaClient.GetSampleSizeForHAD(queryOptions.Filter.RawValue);

                res = res.AddODataOptions<SAMPLESIZECALCType>(queryOptions);

                //Debugging purpose only
                _logger.LogError("Url for SAP request" + res.RequestUri.AbsoluteUri);

                var result = await Task.Factory.FromAsync(res.BeginExecute, res.EndExecute, null);

                var model = _mapper.Map<IEnumerable<SAMPLESIZECALCType>, IEnumerable<SAPSampleSizeModel>>(result.ToList());

                var sapSampleSize = _mapper.Map<IEnumerable<SAPSampleSizeModel>, IEnumerable<SAPSampleSizeCalcModel>>(model.ToList());

                if (smplProc == "F")
                {
                    var sapSampleSizeGreaterThanZero = from s in sapSampleSize where s.SmplSize != null && s.SmplSize != "0" select s;
                    if (sapSampleSizeGreaterThanZero.Count() > 0)
                    {
                        return sapSampleSizeGreaterThanZero.Select(r => r).Take(1).ToList();
                    }
                }
                else
                {
                    //var sapSampleSizeNotEqualToZero = from s in sapSampleSize where s.SmplSize != null && s.SmplSize != "0" select s;
                    //var sampleSize = sapSampleSizeNotEqualToZero.Select(r => r).Take(1).ToList();

                    IEnumerable<SAPSampleSizeCalcModel> slotResult;


                    var sapSampleSizeByMethod = from x in sapSampleSize where x.InspSev != null && x.InspSev != "0" select x;
                    var inspSev = sapSampleSizeByMethod.Select(r => r).Take(1).ToList();
                    var inspSevValue = inspSev.AsEnumerable().Select(r => Regex.Match(r.InspSev, @"\d+").Value).FirstOrDefault();

                    if (inspSevValue != null && inspSevValue != "0")
                    {
                        var sapSampleSizeMatchInsp = from s in sapSampleSizeByMethod where s.InspSev == s.QdpsInspSev select s;
                        var nextInspStage = sapSampleSizeMatchInsp.AsEnumerable().Select(r => Regex.Match(r.NextInspStage, @"\d+").Value).FirstOrDefault();

                        if (nextInspStage != null && nextInspStage != "0")
                        {

                            slotResult = from s in sapSampleSizeByMethod where s.InspStage == s.NextInspStage select s;
                        }
                        else
                        {
                            var initInspStage = sapSampleSizeMatchInsp.AsEnumerable().Select(r => Regex.Match(r.InitInspStage, @"\d+").Value).FirstOrDefault();
                            if (initInspStage != null && initInspStage != "0")
                            {
                                slotResult = from s in sapSampleSizeByMethod where s.InspStage == s.InitInspStage select s;
                            }
                            else
                            {
                                var ResultZero = sapSampleSize.Take(1).ToList();
                                if (ResultZero.Count > 0)
                                {
                                    ResultZero[0].SmplSize = "0";
                                    ResultZero[0].PartNo = "NA";
                                    ResultZero[0].Site = "NA";
                                    ResultZero[0].VendorCode = "NA";
                                    ResultZero[0].InspMethod = "NA";
                                    ResultZero[0].MstrInspChar = "NA";
                                }
                                return ResultZero;
                            }

                        }

                        string id = string.Empty;
                        if(slotResult!=null)
                        {
                            var matchingLot = slotResult.Where(k => k.LotSize!=null && Convert.ToInt32(k.LotSize) == batchQuantity).FirstOrDefault();
                            if(matchingLot!=null)
                            {
                                id = matchingLot.Id;
                                matchingLot.SmplSize = matchingLot.NoSmplSize;
                            }
                            else                               
                            {
                                var matchingLotGreater = slotResult.Where(k => k.LotSize != null && Convert.ToInt32(k.LotSize) > batchQuantity).FirstOrDefault();
                                if(matchingLotGreater !=null)
                                {
                                    id = matchingLotGreater.Id;
                                    matchingLotGreater.SmplSize = matchingLotGreater.NoSmplSize;
                                }
                            }
                        }
                        return slotResult.Where(r => r.Id == id).ToList();


                    }


                }


                //Return Sample Size =0
                var blankResult = sapSampleSize.Take(1).ToList();
                if (blankResult.Count > 0)
                {
                    blankResult[0].SmplSize = "0";
                    blankResult[0].PartNo = "NA";
                    blankResult[0].Site = "NA";
                    blankResult[0].VendorCode = "NA";
                    blankResult[0].InspMethod = "NA";
                    blankResult[0].MstrInspChar = "NA";
                }
                return blankResult;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }


        /// <summary>
        /// checking whether approved inspection plan part number exists in the purchase order module.
        /// </summary>
        /// <param name="oDataQueryOptions"></param>
        /// <returns></returns>
        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("CheckPartNumberExistsInSampleSizeCalculationModule")]
        public async Task<IEnumerable<SAPSampleSizeCalcModel>> CheckPartNumberExistsInSampleSizeCalculationModule(ODataQueryOptions oDataQueryOptions)
        {
            try
            {
                DataServiceQuery<SAMPLESIZECALCType> res;
                res = _sapeHanaClient.GetSampleSizeForHAD(oDataQueryOptions.Filter.RawValue);

                res = res.AddODataOptions<SAMPLESIZECALCType>(oDataQueryOptions);

                var result = await Task.Factory.FromAsync(res.BeginExecute, res.EndExecute, null);

                var sapSampleSizeCalculation = _mapper.Map<IEnumerable<SAMPLESIZECALCType>, IEnumerable<SAPSampleSizeModel>>(result.ToList());

                var lstSampleSizeCalculationModel = _mapper.Map<IEnumerable<SAPSampleSizeModel>, IEnumerable<SAPSampleSizeCalcModel>>(sapSampleSizeCalculation.ToList());

                return lstSampleSizeCalculationModel;
            }
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
        }
    }
}
