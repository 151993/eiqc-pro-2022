/* Auto Generated Code By AutoCodeGen Jabil © 2Constants.Zero19 */


using AutoMapper;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.SupplierSpcChartCommand;
using QSS.eIQC.Utilities.Common.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SAPPartInspectionPlan Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("SupplierSpcChart")]

    public class SupplierSpcChartODataController : BaseODataController
    {
        private const int RangeControlXBarR = 4;
        private const int RangeControlXBarS = 5;
        private const int RangeIMR = 6;
        private const int SkipCount = 5;



        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public SupplierSpcChartODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }


        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetSPCCPKChartStandardAverage(iP={iP},countValue={countValue},skipValue={skipValue},tabId={tabId},smsId={smsId})")]
        public IEnumerable<SupplierSpcChartModel> GetSPCCPKChartStandardAverage(string iP, int countValue, int skipValue, int tabId, int smsId)
        {
            IEnumerable<SupplierSpcChartModel> actualValueData = null;
            switch (tabId)
            {
                case (int)ParameterManagementType.MicroSection:
                    actualValueData = GetMicroSectionActualValues(iP, countValue, skipValue, tabId, smsId);
                    break;

                case (int)ParameterManagementType.FunctionVariable:
                    actualValueData = GetFunctionVariableActualValues(iP, countValue, skipValue, tabId, smsId);
                    break;

                case (int)ParameterManagementType.DimensionalMeasurements:
                    actualValueData = GetDimensionalMeasurementActualValues(iP, countValue, skipValue, tabId, smsId);
                    break;
            }
            return actualValueData;
        }


        public IEnumerable<SupplierSpcChartModel> GetSPCCPKChartStandardAverageForSummaryResults_MicroSection(string iP, int countValue, int skipValue, int smsId, int chartTypeId)
        {
            List<SupplierSpcChartModel> supplierSpcChartModels = new List<SupplierSpcChartModel>();
            supplierSpcChartModels.AddRange(GetMicroSectionActualValuesForChartType(iP, countValue, skipValue, (int)ParameterManagementType.MicroSection, smsId, chartTypeId));

            return supplierSpcChartModels;
        }

        public IEnumerable<SupplierSpcChartModel> GetSPCCPKChartStandardAverageForSummaryResults_FunctionVariable(string iP, int countValue, int skipValue, int smsId, int chartTypeId)
        {
            List<SupplierSpcChartModel> supplierSpcChartModels = new List<SupplierSpcChartModel>();
            supplierSpcChartModels.AddRange(GetFunctionVariableActualValuesForChartType(iP, countValue, skipValue, (int)ParameterManagementType.FunctionVariable, smsId, chartTypeId));
            return supplierSpcChartModels;
        }

        public IEnumerable<SupplierSpcChartModel> GetSPCCPKChartStandardAverageForSummaryResults_DimensionalMeasurement(string iP, int countValue, int skipValue, int smsId, int chartTypeId)
        {
            List<SupplierSpcChartModel> supplierSpcChartModels = new List<SupplierSpcChartModel>();
            supplierSpcChartModels.AddRange(GetDimensionalMeasurementActualValuesForChartType(iP, countValue, skipValue, (int)ParameterManagementType.DimensionalMeasurements, smsId, chartTypeId));
            return supplierSpcChartModels;
        }

        private IEnumerable<SupplierSpcChartModel> GetMicroSectionActualValues(string iP, int countValue, int skipValue, int tabId, int smsId)
        {
            List<SupplierSpcChartModel> supplierSpcChartModels = new List<SupplierSpcChartModel>();

            supplierSpcChartModels = FillXBarRChartDataForMicroSection(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);

            supplierSpcChartModels.AddRange(FillRangeXBarRChartDataForMicroSection(iP, supplierSpcChartModels, tabId, smsId));

            supplierSpcChartModels.AddRange(FillXbarSChartDataForMicroSection(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId));

            supplierSpcChartModels.AddRange(FillRangeXBarSChartDataForMicroSection(iP, supplierSpcChartModels, tabId, smsId));

            FillIMRChartDataForMicroSection(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);

            FillRangeIMRChartDataForMicroSection(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);

            return supplierSpcChartModels;
        }

        private IEnumerable<SupplierSpcChartModel> GetMicroSectionActualValuesForChartType(string iP, int countValue, int skipValue, int tabId, int smsId, int chartTypeId)
        {
            List<SupplierSpcChartModel> supplierSpcChartModels = new List<SupplierSpcChartModel>();

            switch (chartTypeId)
            {
                case (int)ChartType.xBarR:
                    supplierSpcChartModels = FillXBarRChartDataForMicroSection(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);
                    supplierSpcChartModels.AddRange(FillRangeXBarRChartDataForMicroSection(iP, supplierSpcChartModels, tabId, smsId));
                    break;
                case (int)ChartType.xBarS:
                    supplierSpcChartModels = FillXbarSChartDataForMicroSection(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);
                    supplierSpcChartModels.AddRange(FillRangeXBarSChartDataForMicroSection(iP, supplierSpcChartModels, tabId, smsId));
                    break;
                case (int)ChartType.IMR:
                    FillIMRChartDataForMicroSection(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);
                    FillRangeIMRChartDataForMicroSection(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);
                    break;
            }

            return supplierSpcChartModels;
        }

        private IEnumerable<SupplierSpcChartModel> GetFunctionVariableActualValuesForChartType(string iP, int countValue, int skipValue, int tabId, int smsId, int chartTypeId)
        {
            List<SupplierSpcChartModel> supplierSpcChartModels = new List<SupplierSpcChartModel>();

            switch (chartTypeId)
            {
                case (int)ChartType.xBarR:
                    supplierSpcChartModels = FillXBarRChartDataForFunctionVariable(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);
                    supplierSpcChartModels.AddRange(FillRangeXBarRChartDataForFunctionVariable(iP, supplierSpcChartModels, tabId, smsId));
                    break;
                case (int)ChartType.xBarS:
                    supplierSpcChartModels = FillXBarSChartDataForFunctionVariable(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);
                    supplierSpcChartModels.AddRange(FillRangeXBarSChartDataForFunctionVariable(iP, supplierSpcChartModels, tabId, smsId));
                    break;
                case (int)ChartType.IMR:
                    FillIMRChartDataForFunctionVariable(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);
                    FillRangeIMRChartDataForFunctionVariable(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);
                    break;
            }

            return supplierSpcChartModels;
        }

        private IEnumerable<SupplierSpcChartModel> GetDimensionalMeasurementActualValuesForChartType(string iP, int countValue, int skipValue, int tabId, int smsId, int chartTypeId)
        {
            List<SupplierSpcChartModel> supplierSpcChartModels = new List<SupplierSpcChartModel>();

            switch (chartTypeId)
            {
                case (int)ChartType.xBarR:
                    supplierSpcChartModels = FillXBarRChartDataForDimensionalMeasurement(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);
                    supplierSpcChartModels.AddRange(FillRangeXBarRChartDataForDimensionalMeasurement(iP, supplierSpcChartModels, tabId, smsId));
                    break;
                case (int)ChartType.xBarS:
                    supplierSpcChartModels = FillXBarSChartDataForDimensionalMeasurement(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);
                    supplierSpcChartModels.AddRange(FillRangeXBarSChartDataForDimensionalMeasurement(iP, supplierSpcChartModels, tabId, smsId));
                    break;
                case (int)ChartType.IMR:
                    FillIMRChartDataForDimentionalMeasurements(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);
                    FillRangeIMRChartDataForDimentionalMeasurements(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);
                    break;
            }

            return supplierSpcChartModels;
        }

        private IEnumerable<SupplierSpcChartModel> GetFunctionVariableActualValues(string iP, int countValue, int skipValue, int tabId, int smsId)
        {
            List<SupplierSpcChartModel> supplierSpcChartModels = new List<SupplierSpcChartModel>();

            supplierSpcChartModels = FillXBarRChartDataForFunctionVariable(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);

            supplierSpcChartModels.AddRange(FillRangeXBarRChartDataForFunctionVariable(iP, supplierSpcChartModels, tabId, smsId));

            supplierSpcChartModels.AddRange(FillXBarSChartDataForFunctionVariable(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId));

            supplierSpcChartModels.AddRange(FillRangeXBarSChartDataForFunctionVariable(iP, supplierSpcChartModels, tabId, smsId));

            FillIMRChartDataForFunctionVariable(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);

            FillRangeIMRChartDataForFunctionVariable(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);

            return supplierSpcChartModels;
        }

        private IEnumerable<SupplierSpcChartModel> GetDimensionalMeasurementActualValues(string iP, int countValue, int skipValue, int tabId, int smsId)
        {
            List<SupplierSpcChartModel> supplierSpcChartModels = new List<SupplierSpcChartModel>();

            supplierSpcChartModels = FillXBarRChartDataForDimensionalMeasurement(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);

            supplierSpcChartModels.AddRange(FillRangeXBarRChartDataForDimensionalMeasurement(iP, supplierSpcChartModels, tabId, smsId));

            supplierSpcChartModels.AddRange(FillXBarSChartDataForDimensionalMeasurement(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId));

            supplierSpcChartModels.AddRange(FillRangeXBarSChartDataForDimensionalMeasurement(iP, supplierSpcChartModels, tabId, smsId));

            FillIMRChartDataForDimentionalMeasurements(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);

            FillRangeIMRChartDataForDimentionalMeasurements(iP, countValue, skipValue, supplierSpcChartModels, tabId, smsId);

            return supplierSpcChartModels;

        }

        #region X-Bar-R ChartData
        private List<SupplierSpcChartModel> FillXBarRChartDataForMicroSection(string iP, int countValue, int skipValue, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {

            var latestSMSRecords = (from sms in Context.SupplierMeasurementSubmission
                                    where sms.IP.Trim() == iP.Trim() &&
                                    (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                    orderby sms.LastUpdated descending
                                    select new SupplierSpcChartModel
                                    {
                                        SupplierMeasurementSubmissionId = sms.Id,
                                        SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                        SMSNo = sms.SMSNo,
                                        SMSState = sms.StateType.Description,
                                        CreatedDate = sms.LastUpdated
                                    }).ToList();

            latestSMSRecords = CheckIsCurrentFormData(countValue, smsId, latestSMSRecords).Take(countValue).ToList();

            IEnumerable<SupplierSpcChartModel> latestSMSDataRaw;
            latestSMSDataRaw = SkipAndTake(countValue, skipValue, latestSMSRecords);

            var latestSMSData = (from newSMS in latestSMSDataRaw
                                 join part in Context.PartMicrosection on newSMS.SAPPartInspectionPlanId equals part.SAPPartInspectionPlanId
                                 select new SupplierSpcChartModel
                                 {
                                     SupplierMeasurementSubmissionId = newSMS.SupplierMeasurementSubmissionId,
                                     ParameterId = part.ParameterManagementId,
                                     ChartTypeId = part.ChartTypeId,
                                     SAPPartInspectionPlanId = part.SAPPartInspectionPlanId,
                                     SMSNo = newSMS.SMSNo,
                                     SMSSize = newSMS.SMSNo.Split("-").Length,
                                     SMSState = newSMS.SMSState.Substring(0, 1),
                                     UpperTolerance = part.UpperTolerance,
                                     LowerTolerance = part.LowerTolerance,
                                     CreatedDate = newSMS.CreatedDate

                                 }).ToList();


            supplierSpcChartModels = (from xBarR in latestSMSData
                                      join smicro in Context.SupplierMicrosection on xBarR.SupplierMeasurementSubmissionId equals smicro.SupplierMeasurementSubmissionId
                                      join sma in Context.SupplierMicroSectionActual on smicro.Id equals sma.SupplierMicrosectionId
                                      join pm in Context.ParameterManagement on smicro.ParameterManagementId equals pm.Id
                                      where xBarR.ParameterId == smicro.ParameterManagementId

                                      group new { smicro, sma, pm, xBarR } by new { smicro.SupplierMeasurementSubmissionId, pm.Id, xBarR.SMSNo, xBarR.SMSState, xBarR.SMSSize, xBarR.UpperTolerance, xBarR.LowerTolerance, xBarR.CreatedDate } into xBarRData

                                      select new SupplierSpcChartModel
                                      {
                                          FinalTextValue = xBarRData.Average(k => !string.IsNullOrEmpty(k.sma.ActualTextValue) ? Convert.ToDouble(k.sma.ActualTextValue) : Constants.Zero),
                                          ParameterId = xBarRData.Key.Id,
                                          SMSNoState = xBarRData.Key.SMSNo.Split("-").Last() + ' ' + xBarRData.Key.SMSState,
                                          SupplierMeasurementSubmissionId = xBarRData.Key.SupplierMeasurementSubmissionId,
                                          ChartTypeId = (int)ChartType.xBarR,
                                          TabId = tabId,
                                          UpperTolerance = xBarRData.Key.UpperTolerance,
                                          LowerTolerance = xBarRData.Key.LowerTolerance,
                                          CreatedDate = xBarRData.Key.CreatedDate

                                      }).ToList();


            return supplierSpcChartModels;
        }

        private static IEnumerable<SupplierSpcChartModel> SkipAndTake(int countValue, int skipValue, List<SupplierSpcChartModel> latestSMSRecords)
        {
            IEnumerable<SupplierSpcChartModel> latestSMSDataRaw;
            // equal or more than 30 sms and skip = 5
            if (latestSMSRecords.Count == Constants.Thirty && skipValue > Constants.Zero)
            {
                latestSMSDataRaw = latestSMSRecords.Take(countValue).Skip(skipValue);
            }
            else
            {

                if ((latestSMSRecords.Count - (countValue - skipValue)) < Constants.Zero)
                {
                    //less than 30 sms no skip 
                    latestSMSDataRaw = latestSMSRecords.Take(countValue);
                }
                else
                {
                    //more than 30 sms & skip =0 
                    latestSMSDataRaw = latestSMSRecords.Take(countValue).Skip(latestSMSRecords.Count - (countValue - skipValue));
                }
            }

            return latestSMSDataRaw;
        }

        private List<SupplierSpcChartModel> FillXBarRChartDataForFunctionVariable(string iP, int countValue, int skipValue, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {

            var latestSMSRecords = (from sms in Context.SupplierMeasurementSubmission
                                    where sms.IP.Trim() == iP.Trim() &&
                                    (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                    orderby sms.LastUpdated descending
                                    select new SupplierSpcChartModel
                                    {
                                        SupplierMeasurementSubmissionId = sms.Id,
                                        SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                        SMSNo = sms.SMSNo,
                                        SMSState = sms.StateType.Description,
                                        CreatedDate = sms.LastUpdated
                                    }).ToList();

            latestSMSRecords = CheckIsCurrentFormData(countValue, smsId, latestSMSRecords).Take(countValue).ToList();

            IEnumerable<SupplierSpcChartModel> latestSMSDataRaw;
            latestSMSDataRaw = SkipAndTake(countValue, skipValue, latestSMSRecords);

            var latestSMSData = (from newSMS in latestSMSDataRaw
                                 join part in Context.PartFunParameter on newSMS.SAPPartInspectionPlanId equals part.SAPPartInspectionPlanId
                                 select new SupplierSpcChartModel
                                 {
                                     SupplierMeasurementSubmissionId = newSMS.SupplierMeasurementSubmissionId,
                                     ParameterId = part.ParameterManagementId,
                                     ChartTypeId = (int)ChartType.xBarR,
                                     SAPPartInspectionPlanId = part.SAPPartInspectionPlanId,
                                     SMSNo = newSMS.SMSNo,
                                     SMSSize = newSMS.SMSNo.Split("-").Length,
                                     SMSState = newSMS.SMSState.Substring(0, 1),
                                     UpperTolerance = part.UpperTolerance,
                                     LowerTolerance = part.LowerTolerance,
                                     CreatedDate = newSMS.CreatedDate
                                 }).ToList();


            supplierSpcChartModels = (from xBarR in latestSMSData
                                      join sfunvar in Context.SupplierFunctionVariable on xBarR.SupplierMeasurementSubmissionId equals sfunvar.SupplierMeasurementSubmissionId
                                      join smfun in Context.SupplierFunctionVariableActual on sfunvar.Id equals smfun.SupplierFunctionVariableId
                                      join pm in Context.ParameterManagement on sfunvar.ParameterManagementId equals pm.Id
                                      where xBarR.ParameterId == sfunvar.ParameterManagementId
                                      group new { sfunvar, smfun, pm, xBarR } by new { sfunvar.SupplierMeasurementSubmissionId, pm.Id, xBarR.SMSNo, xBarR.SMSState, xBarR.SMSSize, xBarR.UpperTolerance, xBarR.LowerTolerance, xBarR.CreatedDate } into xBarRData
                                      select new SupplierSpcChartModel
                                      {
                                          FinalTextValue = xBarRData.Average(k => !string.IsNullOrEmpty(k.smfun.ActualTextValue) ? Convert.ToDouble(k.smfun.ActualTextValue) : Constants.Zero),
                                          ParameterId = xBarRData.Key.Id,
                                          SupplierMeasurementSubmissionId = xBarRData.Key.SupplierMeasurementSubmissionId,
                                          SMSNoState = xBarRData.Key.SMSNo.Split("-").Last() + ' ' + xBarRData.Key.SMSState,
                                          ChartTypeId = (int)ChartType.xBarR,
                                          TabId = tabId,
                                          UpperTolerance = xBarRData.Key.UpperTolerance,
                                          LowerTolerance = xBarRData.Key.LowerTolerance,
                                          CreatedDate = xBarRData.Key.CreatedDate
                                      }).ToList();


            return supplierSpcChartModels;
        }

        private List<SupplierSpcChartModel> FillXBarRChartDataForDimensionalMeasurement(string iP, int countValue, int skipValue, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {


            var latestSMSRecords = (from sms in Context.SupplierMeasurementSubmission
                                    where sms.IP.Trim() == iP.Trim() &&
                                    (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                    orderby sms.LastUpdated descending
                                    select new SupplierSpcChartModel
                                    {
                                        SupplierMeasurementSubmissionId = sms.Id,
                                        SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                        SMSNo = sms.SMSNo,
                                        SMSState = sms.StateType.Description,
                                        CreatedDate = sms.LastUpdated
                                    }).ToList();

            latestSMSRecords = CheckIsCurrentFormData(countValue, smsId, latestSMSRecords).Take(countValue).ToList();

            IEnumerable<SupplierSpcChartModel> latestSMSDataRaw;
            latestSMSDataRaw = SkipAndTake(countValue, skipValue, latestSMSRecords);

            var latestSMSData = (from newSMS in latestSMSDataRaw
                                 join part in Context.PartMeasurementParameter on newSMS.SAPPartInspectionPlanId equals part.SAPPartInspectionPlanId
                                 select new SupplierSpcChartModel
                                 {
                                     SupplierMeasurementSubmissionId = newSMS.SupplierMeasurementSubmissionId,
                                     ParameterId = part.ParameterManagementId,
                                     ChartTypeId = (int)ChartType.xBarR,
                                     SAPPartInspectionPlanId = part.SAPPartInspectionPlanId,
                                     SMSNo = newSMS.SMSNo,
                                     SMSSize = newSMS.SMSNo.Split("-").Length,
                                     SMSState = newSMS.SMSState.Substring(0, 1),
                                     UpperTolerance = part.UpperTolerance,
                                     LowerTolerance = part.LowerTolerance,
                                     CreatedDate = newSMS.CreatedDate

                                 }).ToList();


            supplierSpcChartModels = (from xBarR in latestSMSData
                                      join sdim in Context.SupplierDimensionMeasurement on xBarR.SupplierMeasurementSubmissionId equals sdim.SupplierMeasurementSubmissionId
                                      join sdima in Context.SupplierDimensionMeasurementActual on sdim.Id equals sdima.SupplierDimensionMeasurementId
                                      join pm in Context.ParameterManagement on sdim.ParameterManagementId equals pm.Id
                                      where sdim.ParameterManagementId == xBarR.ParameterId
                                      group new { sdim, sdima, pm, xBarR } by new { sdim.SupplierMeasurementSubmissionId, pm.Id, xBarR.SMSNo, xBarR.SMSState, xBarR.SMSSize, xBarR.UpperTolerance, xBarR.LowerTolerance, xBarR.CreatedDate } into xBarRData
                                      select new SupplierSpcChartModel
                                      {
                                          FinalTextValue = xBarRData.Average(k => !string.IsNullOrEmpty(k.sdima.ActualTextValue) ? Convert.ToDouble(k.sdima.ActualTextValue) : Constants.Zero),
                                          ParameterId = xBarRData.Key.Id,
                                          SupplierMeasurementSubmissionId = xBarRData.Key.SupplierMeasurementSubmissionId,
                                          SMSNoState = xBarRData.Key.SMSNo.Split("-").Last() + ' ' + xBarRData.Key.SMSState,
                                          ChartTypeId = (int)ChartType.xBarR,
                                          TabId = tabId,
                                          UpperTolerance = xBarRData.Key.UpperTolerance,
                                          LowerTolerance = xBarRData.Key.LowerTolerance,
                                          CreatedDate = xBarRData.Key.CreatedDate

                                      }).ToList();


            return supplierSpcChartModels;
        }

        #endregion

        #region IMR ChartData
        private void FillIMRChartDataForMicroSection(string iP, int countValue, int skipValue, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {
            var latestImrChartDataForMicroSection = (from sms in Context.SupplierMeasurementSubmission
                                                     join smicro in Context.SupplierMicrosection on sms.Id equals smicro.SupplierMeasurementSubmissionId
                                                     join sma in Context.SupplierMicroSectionActual on smicro.Id equals sma.SupplierMicrosectionId
                                                     join pm in Context.ParameterManagement on smicro.ParameterManagementId equals pm.Id
                                                     where sms.IP.Trim() == iP.Trim() && (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE
                                                     || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                                     orderby sma.LastUpdated descending
                                                     select new SupplierSpcChartModel
                                                     {
                                                         ActualValueIndex = Convert.ToInt32(Regex.Match(sma.ActualTextName, @"\d+$", RegexOptions.RightToLeft).ToString()),
                                                         FinalTextValue = !string.IsNullOrEmpty(sma.ActualTextValue) ? Convert.ToDouble(sma.ActualTextValue) : Constants.Zero,
                                                         ParameterId = pm.Id,
                                                         SupplierMeasurementSubmissionId = sms.Id,
                                                         ChartTypeId = (int)ChartType.IMR,
                                                         SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                                         SMSNoState = Regex.Match(sma.ActualTextName, @"\d+$", RegexOptions.RightToLeft).ToString() + '-' +
                                                         sms.SMSNo.Substring(sms.SMSNo.LastIndexOf('-') + 1) + " " + sms.StateType.Description.Substring(0, 1),
                                                         TabId = tabId,
                                                         UpperTolerance = smicro.UpperTolerance,
                                                         LowerTolerance = smicro.LowerTolerance,
                                                         CreatedDate = sms.LastUpdated
                                                     }).ToList();

            countValue = GetCountOfIMRParameters(countValue, latestImrChartDataForMicroSection);

            latestImrChartDataForMicroSection = CheckIsCurrentFormDataIMR(countValue, smsId, latestImrChartDataForMicroSection).Take(countValue).ToList();

            IEnumerable<SupplierSpcChartModel> imrChartData;

            imrChartData = SkipAndTake(countValue, skipValue, latestImrChartDataForMicroSection);

            imrChartData = imrChartData.OrderBy(k => k.CreatedDate).ThenBy(k => k.ActualValueIndex).ToList();

            if (skipValue == SkipCount)
            {
                double rangeAverage = CalculateAbsoluteRange(imrChartData);
                imrChartData.ToList().ForEach(k => k.RangeAverageFor25 = rangeAverage);
            }

            supplierSpcChartModels.AddRange(imrChartData);
        }

        
        private void FillIMRChartDataForFunctionVariable(string iP, int countValue, int skipValue, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {
            List<SupplierSpcChartModel> latestImrChartDataForFunctionVariable = (from sms in Context.SupplierMeasurementSubmission
                                                                                 join sfunvar in Context.SupplierFunctionVariable on sms.Id equals sfunvar.SupplierMeasurementSubmissionId
                                                                                 join smfun in Context.SupplierFunctionVariableActual on sfunvar.Id equals smfun.SupplierFunctionVariableId
                                                                                 join pm in Context.ParameterManagement on sfunvar.ParameterManagementId equals pm.Id
                                                                                 where sms.IP.Trim() == iP.Trim() && (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE
                                                                                 || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                                                                 orderby smfun.LastUpdated descending
                                                                                 select new SupplierSpcChartModel
                                                                                 {
                                                                                     ActualValueIndex = Convert.ToInt32(Regex.Match(smfun.ActualTextName, @"\d+$", RegexOptions.RightToLeft).ToString()),
                                                                                     FinalTextValue = !string.IsNullOrEmpty(smfun.ActualTextValue) ? Convert.ToDouble(smfun.ActualTextValue) : Constants.Zero,
                                                                                     ParameterId = pm.Id,
                                                                                     SupplierMeasurementSubmissionId = sms.Id,
                                                                                     ChartTypeId = (int)ChartType.IMR,
                                                                                     SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                                                                     SMSNoState = Regex.Match(smfun.ActualTextName, @"\d+$", RegexOptions.RightToLeft).ToString() + '-' +
                                                                                     sms.SMSNo.Substring(sms.SMSNo.LastIndexOf('-') + 1) + " " + sms.StateType.Description.Substring(0, 1),
                                                                                     TabId = tabId,
                                                                                     UpperTolerance = sfunvar.UpperTolerance,
                                                                                     LowerTolerance = sfunvar.LowerTolerance,
                                                                                     CreatedDate = sms.LastUpdated
                                                                                 }).ToList();

            countValue = GetCountOfIMRParameters(countValue, latestImrChartDataForFunctionVariable);


            latestImrChartDataForFunctionVariable = CheckIsCurrentFormDataIMR(countValue, smsId, latestImrChartDataForFunctionVariable).Take(countValue).ToList();

            IEnumerable<SupplierSpcChartModel> imrChartData;

            imrChartData = SkipAndTake(countValue, skipValue, latestImrChartDataForFunctionVariable);

            imrChartData = imrChartData.OrderBy(k => k.CreatedDate).ThenBy(k => k.ActualValueIndex).ToList();

            if (skipValue == SkipCount)
            {
                double rangeAverage = CalculateAbsoluteRange(imrChartData);
                imrChartData.ToList().ForEach(k => k.RangeAverageFor25 = rangeAverage);
            }

            supplierSpcChartModels.AddRange(imrChartData);
        }

        private void FillIMRChartDataForDimentionalMeasurements(string iP, int countValue, int skipValue, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {
            var latestImrChartDataForDimentionalMeasurements = (from sms in Context.SupplierMeasurementSubmission
                                                                join sdim in Context.SupplierDimensionMeasurement on sms.Id equals sdim.SupplierMeasurementSubmissionId
                                                                join sdima in Context.SupplierDimensionMeasurementActual on sdim.Id equals sdima.SupplierDimensionMeasurementId
                                                                join pm in Context.ParameterManagement on sdim.ParameterManagementId equals pm.Id
                                                                where sms.IP.Trim() == iP.Trim() && (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE
                                                                || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                                                orderby sdima.LastUpdated descending
                                                                select new SupplierSpcChartModel
                                                                {
                                                                    ActualValueIndex = Convert.ToInt32(Regex.Match(sdima.ActualTextName, @"\d+$", RegexOptions.RightToLeft).ToString()),
                                                                    FinalTextValue = !string.IsNullOrEmpty(sdima.ActualTextValue) ? Convert.ToDouble(sdima.ActualTextValue) : Constants.Zero,
                                                                    ParameterId = pm.Id,
                                                                    SupplierMeasurementSubmissionId = sms.Id,
                                                                    ChartTypeId = (int)ChartType.IMR,
                                                                    SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                                                    SMSNoState = Regex.Match(sdima.ActualTextName, @"\d+$", RegexOptions.RightToLeft).ToString() + '-' +
                                                                    sms.SMSNo.Substring(sms.SMSNo.LastIndexOf('-') + 1) + " " + sms.StateType.Description.Substring(0, 1),
                                                                    TabId = tabId,
                                                                    UpperTolerance = sdim.UpperTolerance,
                                                                    LowerTolerance = sdim.LowerTolerance,
                                                                    CreatedDate = sms.LastUpdated
                                                                }).ToList();

            countValue = GetCountOfIMRParameters(countValue, latestImrChartDataForDimentionalMeasurements);


            latestImrChartDataForDimentionalMeasurements = CheckIsCurrentFormDataIMR(countValue, smsId, latestImrChartDataForDimentionalMeasurements).Take(countValue).ToList();

            IEnumerable<SupplierSpcChartModel> imrChartData;

            imrChartData = SkipAndTake(countValue, skipValue, latestImrChartDataForDimentionalMeasurements);

            imrChartData = imrChartData.OrderBy(k => k.CreatedDate).ThenBy(k => k.ActualValueIndex).ToList();

            if (skipValue == SkipCount)
            {
                double rangeAverage = CalculateAbsoluteRange(imrChartData);
                imrChartData.ToList().ForEach(k => k.RangeAverageFor25 = rangeAverage);
            }

            supplierSpcChartModels.AddRange(imrChartData);
        }


        private static double CalculateAbsoluteRange(IEnumerable<SupplierSpcChartModel> imrChartData)
        {
            int index = 0;
            double rBarControlLimit = 0;
            if (imrChartData != null)
            {
                foreach (var item in imrChartData)
                {
                    if (index != 0)
                    {
                        var previousItem = imrChartData.ToList()[index - 1];
                        if (previousItem != null)
                        {
                            rBarControlLimit += Math.Abs(Convert.ToDouble(previousItem.FinalTextValue - item.FinalTextValue));
                        }
                        else
                        {
                            rBarControlLimit += 0;
                        }
                    }
                    else
                    {
                        rBarControlLimit += 0;
                    }
                    index++;
                }
            }
            return (rBarControlLimit / imrChartData.Count());

        }

        #endregion

        #region Range IMR ChartData
        private void FillRangeIMRChartDataForMicroSection(string iP, int countValue, int skipValue, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {
            var latestImrChartDataForMicroSection = (from sms in Context.SupplierMeasurementSubmission
                                                     join smicro in Context.SupplierMicrosection on sms.Id equals smicro.SupplierMeasurementSubmissionId
                                                     join sma in Context.SupplierMicroSectionActual on smicro.Id equals sma.SupplierMicrosectionId
                                                     join pm in Context.ParameterManagement on smicro.ParameterManagementId equals pm.Id
                                                     where sms.IP.Trim() == iP.Trim() && (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE
                                                     || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                                     orderby sma.LastUpdated descending
                                                     select new SupplierSpcChartModel
                                                     {
                                                         ActualValueIndex = Convert.ToInt32(Regex.Match(sma.ActualTextName, @"\d+$", RegexOptions.RightToLeft).ToString()),
                                                         ActualTextValue = !string.IsNullOrEmpty(sma.ActualTextValue) ? Convert.ToDouble(sma.ActualTextValue) : Constants.Zero,
                                                         ParameterId = pm.Id,
                                                         SupplierMeasurementSubmissionId = sms.Id,
                                                         ChartTypeId = RangeIMR,
                                                         SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                                         SMSNoState = Regex.Match(sma.ActualTextName, @"\d+$", RegexOptions.RightToLeft).ToString() + '-' +
                                                            sms.SMSNo.Substring(sms.SMSNo.LastIndexOf('-') + 1) + " " + sms.StateType.Description.Substring(0, 1),
                                                         TabId = tabId,
                                                         UpperTolerance = smicro.UpperTolerance,
                                                         LowerTolerance = smicro.LowerTolerance,
                                                         CreatedDate = sms.LastUpdated
                                                     }).ToList();

            countValue = GetCountOfIMRParameters(countValue, latestImrChartDataForMicroSection);


            latestImrChartDataForMicroSection = CheckIsCurrentFormDataIMR(countValue, smsId, latestImrChartDataForMicroSection).Take(countValue).ToList();

            var imrChartData = SkipAndTake(countValue, skipValue, latestImrChartDataForMicroSection);

            imrChartData = imrChartData.OrderBy(k => k.CreatedDate).ThenBy(k => k.ActualValueIndex).ToList();

            CalculateAbsoluteDifferences(imrChartData);

            supplierSpcChartModels.AddRange(imrChartData);
        }

        private static void CalculateAbsoluteDifferences(IEnumerable<SupplierSpcChartModel> imrChartData)
        {
            int index = 0;
            if (imrChartData != null)
            {
                foreach (var item in imrChartData)
                {
                    if (index != 0)
                    {
                        var previousItem = imrChartData.ToList()[index - 1];
                        if (previousItem != null)
                        {
                            item.FinalTextValue = Math.Abs(Convert.ToDouble(previousItem.ActualTextValue) - Convert.ToDouble(item.ActualTextValue));
                        }
                        else
                        {
                            item.FinalTextValue = 0;
                        }
                    }
                    else
                    {
                        item.FinalTextValue = 0;
                    }
                    index++;
                }
            }

        }

        private void FillRangeIMRChartDataForFunctionVariable(string iP, int countValue, int skipValue, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {
            List<SupplierSpcChartModel> latestImrChartDataForFunctionVariable = (from sms in Context.SupplierMeasurementSubmission
                                                                                 join sfunvar in Context.SupplierFunctionVariable on sms.Id equals sfunvar.SupplierMeasurementSubmissionId
                                                                                 join smfun in Context.SupplierFunctionVariableActual on sfunvar.Id equals smfun.SupplierFunctionVariableId
                                                                                 join pm in Context.ParameterManagement on sfunvar.ParameterManagementId equals pm.Id
                                                                                 where sms.IP.Trim() == iP.Trim() && (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE
                                                                                 || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                                                                 orderby smfun.LastUpdated descending
                                                                                 select new SupplierSpcChartModel
                                                                                 {
                                                                                     ActualValueIndex = Convert.ToInt32(Regex.Match(smfun.ActualTextName, @"\d+$", RegexOptions.RightToLeft).ToString()),
                                                                                     ActualTextValue = !string.IsNullOrEmpty(smfun.ActualTextValue) ? Convert.ToDouble(smfun.ActualTextValue) : Constants.Zero,
                                                                                     ParameterId = pm.Id,
                                                                                     SupplierMeasurementSubmissionId = sms.Id,
                                                                                     ChartTypeId = RangeIMR,
                                                                                     SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                                                                     SMSNoState = Regex.Match(smfun.ActualTextName, @"\d+$", RegexOptions.RightToLeft).ToString() + '-' +
                                                                                     sms.SMSNo.Substring(sms.SMSNo.LastIndexOf('-') + 1) + " " + sms.StateType.Description.Substring(0, 1),
                                                                                     TabId = tabId,
                                                                                     UpperTolerance = sfunvar.UpperTolerance,
                                                                                     LowerTolerance = sfunvar.LowerTolerance,
                                                                                     CreatedDate = sms.LastUpdated
                                                                                 }).ToList();

            countValue = GetCountOfIMRParameters(countValue, latestImrChartDataForFunctionVariable);


            latestImrChartDataForFunctionVariable = CheckIsCurrentFormDataIMR(countValue, smsId, latestImrChartDataForFunctionVariable).Take(countValue).ToList();

            IEnumerable<SupplierSpcChartModel> imrChartData;

            imrChartData = SkipAndTake(countValue, skipValue, latestImrChartDataForFunctionVariable);

            imrChartData = imrChartData.OrderBy(k => k.CreatedDate).ThenBy(k => k.ActualValueIndex).ToList();

            CalculateAbsoluteDifferences(imrChartData);

            supplierSpcChartModels.AddRange(imrChartData);
        }

        private void FillRangeIMRChartDataForDimentionalMeasurements(string iP, int countValue, int skipValue, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {
            var latestImrChartDataForDimentionalMeasurements = (from sms in Context.SupplierMeasurementSubmission
                                                                join sdim in Context.SupplierDimensionMeasurement on sms.Id equals sdim.SupplierMeasurementSubmissionId
                                                                join sdima in Context.SupplierDimensionMeasurementActual on sdim.Id equals sdima.SupplierDimensionMeasurementId
                                                                join pm in Context.ParameterManagement on sdim.ParameterManagementId equals pm.Id
                                                                where sms.IP.Trim() == iP.Trim() && (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE
                                                                || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                                                orderby sdima.LastUpdated descending
                                                                select new SupplierSpcChartModel
                                                                {
                                                                    ActualValueIndex = Convert.ToInt32(Regex.Match(sdima.ActualTextName, @"\d+$", RegexOptions.RightToLeft).ToString()),
                                                                    ActualTextValue = !string.IsNullOrEmpty(sdima.ActualTextValue) ? Convert.ToDouble(sdima.ActualTextValue) : Constants.Zero,
                                                                    ParameterId = pm.Id,
                                                                    SupplierMeasurementSubmissionId = sms.Id,
                                                                    ChartTypeId = RangeIMR,
                                                                    SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                                                    SMSNoState = Regex.Match(sdima.ActualTextName, @"\d+$", RegexOptions.RightToLeft).ToString() + '-' +
                                                                    sms.SMSNo.Substring(sms.SMSNo.LastIndexOf('-') + 1) + " " + sms.StateType.Description.Substring(0, 1),
                                                                    TabId = tabId,
                                                                    UpperTolerance = sdim.UpperTolerance,
                                                                    LowerTolerance = sdim.LowerTolerance,
                                                                    CreatedDate = sms.LastUpdated
                                                                }).ToList();

            countValue = GetCountOfIMRParameters(countValue, latestImrChartDataForDimentionalMeasurements);


            latestImrChartDataForDimentionalMeasurements = CheckIsCurrentFormDataIMR(countValue, smsId, latestImrChartDataForDimentionalMeasurements).Take(countValue).ToList();

            IEnumerable<SupplierSpcChartModel> imrChartData;

            imrChartData = SkipAndTake(countValue, skipValue, latestImrChartDataForDimentionalMeasurements);

            imrChartData = imrChartData.OrderBy(k => k.CreatedDate).ThenBy(k => k.ActualValueIndex).ToList();

            CalculateAbsoluteDifferences(imrChartData);

            supplierSpcChartModels.AddRange(imrChartData);
        }

        #endregion

        #region Range-XBar-R ChartData
        private List<SupplierSpcChartModel> FillRangeXBarRChartDataForMicroSection(string iP, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {
            var latestSMSDataRaw = (from sms in Context.SupplierMeasurementSubmission
                                    where sms.IP.Trim() == iP.Trim() &&
                                    (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                    orderby sms.LastUpdated descending
                                    select new SupplierSpcChartModel
                                    {
                                        SupplierMeasurementSubmissionId = sms.Id,
                                        SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                        SMSNo = sms.SMSNo,
                                        SMSState = sms.StateType.Description,
                                        CreatedDate = sms.LastUpdated
                                    }).ToList();


            latestSMSDataRaw = CheckIsCurrentFormData(Constants.Thirty, smsId, latestSMSDataRaw).Take(Constants.Thirty).ToList();

            var latestSMSData = (from newSMS in latestSMSDataRaw
                                 join part in Context.PartMicrosection on newSMS.SAPPartInspectionPlanId equals part.SAPPartInspectionPlanId
                                 select new SupplierSpcChartModel
                                 {
                                     SupplierMeasurementSubmissionId = newSMS.SupplierMeasurementSubmissionId,
                                     ParameterId = part.ParameterManagementId,
                                     ChartTypeId = part.ChartTypeId,
                                     SAPPartInspectionPlanId = part.SAPPartInspectionPlanId,
                                     SMSNo = newSMS.SMSNo,
                                     SMSState = newSMS.SMSState.Substring(0, 1),
                                     UpperTolerance = part.UpperTolerance,
                                     LowerTolerance = part.LowerTolerance,
                                     CreatedDate = newSMS.CreatedDate
                                 }).ToList();

            foreach (var item in latestSMSData)
            {
                supplierSpcChartModels = (from xBarR in latestSMSData
                                          join smicro in Context.SupplierMicrosection on xBarR.SupplierMeasurementSubmissionId equals smicro.SupplierMeasurementSubmissionId
                                          join sma in Context.SupplierMicroSectionActual on smicro.Id equals sma.SupplierMicrosectionId
                                          join pm in Context.ParameterManagement on smicro.ParameterManagementId equals pm.Id
                                          where xBarR.ParameterId == smicro.ParameterManagementId
                                          group new { smicro, sma, xBarR } by new { smicro.SupplierMeasurementSubmissionId, xBarR.SMSNo, xBarR.SMSState, xBarR.UpperTolerance, xBarR.LowerTolerance, xBarR.CreatedDate } into xBarRData
                                          select new SupplierSpcChartModel
                                          {
                                              FinalTextValue = (xBarRData.Max(k => !string.IsNullOrEmpty(k.sma.ActualTextValue) ? Convert.ToDouble(k.sma.ActualTextValue) : Constants.Zero)) - (xBarRData.Min(k => !string.IsNullOrEmpty(k.sma.ActualTextValue) ? Convert.ToDouble(k.sma.ActualTextValue) : Constants.Zero)),
                                              ParameterId = item.ParameterId,
                                              SupplierMeasurementSubmissionId = xBarRData.Key.SupplierMeasurementSubmissionId,
                                              SMSNoState = xBarRData.Key.SMSNo.Split("-").Last() + ' ' + xBarRData.Key.SMSState,
                                              ChartTypeId = RangeControlXBarR,
                                              TabId = tabId,
                                              UpperTolerance = xBarRData.Key.UpperTolerance,
                                              LowerTolerance = xBarRData.Key.LowerTolerance,
                                              CreatedDate = xBarRData.Key.CreatedDate
                                          }).ToList();
            }

            return supplierSpcChartModels;
        }

        private List<SupplierSpcChartModel> FillRangeXBarRChartDataForFunctionVariable(string iP, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {
            var latestSMSDataRaw = (from sms in Context.SupplierMeasurementSubmission
                                    where sms.IP.Trim() == iP.Trim() &&
                                    (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE || sms.StateTypeId == (int)StateType.Rejected_By_SQE)
                                    orderby sms.LastUpdated descending
                                    select new SupplierSpcChartModel
                                    {
                                        SupplierMeasurementSubmissionId = sms.Id,
                                        SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                        SMSNo = sms.SMSNo,
                                        SMSState = sms.StateType.Description,
                                        CreatedDate = sms.LastUpdated
                                    }).ToList();

            latestSMSDataRaw = CheckIsCurrentFormData(Constants.Thirty, smsId, latestSMSDataRaw).Take(Constants.Thirty).ToList();


            var latestSMSData = (from newSMS in latestSMSDataRaw
                                 join part in Context.PartFunParameter on newSMS.SAPPartInspectionPlanId equals part.SAPPartInspectionPlanId
                                 select new SupplierSpcChartModel
                                 {
                                     SupplierMeasurementSubmissionId = newSMS.SupplierMeasurementSubmissionId,
                                     ParameterId = part.ParameterManagementId,
                                     ChartTypeId = RangeControlXBarR,
                                     SAPPartInspectionPlanId = part.SAPPartInspectionPlanId,
                                     SMSNo = newSMS.SMSNo,
                                     SMSState = newSMS.SMSState.Substring(0, 1),
                                     TabId = tabId,
                                     UpperTolerance = part.UpperTolerance,
                                     LowerTolerance = part.LowerTolerance,
                                     CreatedDate = newSMS.CreatedDate
                                 }).ToList();

            foreach (var item in latestSMSData)
            {

                supplierSpcChartModels = (from xBarR in latestSMSData
                                          join sfunvar in Context.SupplierFunctionVariable on xBarR.SupplierMeasurementSubmissionId equals sfunvar.SupplierMeasurementSubmissionId
                                          join smfun in Context.SupplierFunctionVariableActual on sfunvar.Id equals smfun.SupplierFunctionVariableId
                                          join pm in Context.ParameterManagement on sfunvar.ParameterManagementId equals pm.Id
                                          where sfunvar.ParameterManagementId == xBarR.ParameterId
                                          group new { sfunvar, smfun, xBarR } by new { sfunvar.SupplierMeasurementSubmissionId, xBarR.SMSNo, xBarR.SMSState, xBarR.UpperTolerance, xBarR.LowerTolerance, xBarR.CreatedDate } into xBarRData
                                          select new SupplierSpcChartModel
                                          {
                                              FinalTextValue = (xBarRData.Max(k => !string.IsNullOrEmpty(k.smfun.ActualTextValue) ? Convert.ToDouble(k.smfun.ActualTextValue) : Constants.Zero)) - (xBarRData.Min(k => !string.IsNullOrEmpty(k.smfun.ActualTextValue) ? Convert.ToDouble(k.smfun.ActualTextValue) : Constants.Zero)),
                                              ParameterId = item.ParameterId,
                                              SupplierMeasurementSubmissionId = xBarRData.Key.SupplierMeasurementSubmissionId,
                                              SMSNoState = xBarRData.Key.SMSNo.Split("-").Last() + ' ' + xBarRData.Key.SMSState,
                                              ChartTypeId = RangeControlXBarR,
                                              SAPPartInspectionPlanId = item.SAPPartInspectionPlanId,
                                              TabId = tabId,
                                              UpperTolerance = xBarRData.Key.UpperTolerance,
                                              LowerTolerance = xBarRData.Key.LowerTolerance,
                                              CreatedDate = xBarRData.Key.CreatedDate
                                          }).ToList();


            }

            return supplierSpcChartModels;
        }

        private List<SupplierSpcChartModel> FillRangeXBarRChartDataForDimensionalMeasurement(string iP, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {
            var latestSMSDataRaw = (from sms in Context.SupplierMeasurementSubmission
                                    where sms.IP.Trim() == iP.Trim() &&
                                    (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                    orderby sms.LastUpdated descending
                                    select new SupplierSpcChartModel
                                    {
                                        SupplierMeasurementSubmissionId = sms.Id,
                                        SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                        SMSNo = sms.SMSNo,
                                        SMSState = sms.StateType.Description,
                                        CreatedDate = sms.LastUpdated
                                    }).ToList();

            latestSMSDataRaw = CheckIsCurrentFormData(Constants.Thirty, smsId, latestSMSDataRaw).Take(Constants.Thirty).ToList();


            var latestSMSData = (from newSMS in latestSMSDataRaw
                                 join part in Context.PartMeasurementParameter on newSMS.SAPPartInspectionPlanId equals part.SAPPartInspectionPlanId
                                 select new SupplierSpcChartModel
                                 {
                                     SupplierMeasurementSubmissionId = newSMS.SupplierMeasurementSubmissionId,
                                     ParameterId = part.ParameterManagementId,
                                     ChartTypeId = RangeControlXBarR,
                                     SAPPartInspectionPlanId = part.SAPPartInspectionPlanId,
                                     SMSNo = newSMS.SMSNo,
                                     SMSState = newSMS.SMSState.Substring(0, 1),
                                     TabId = tabId,
                                     UpperTolerance = part.UpperTolerance,
                                     LowerTolerance = part.LowerTolerance,
                                     CreatedDate = newSMS.CreatedDate
                                 }).ToList();

            foreach (var item in latestSMSData)
            {
                supplierSpcChartModels = (from xBarR in latestSMSData
                                          join sdim in Context.SupplierDimensionMeasurement on xBarR.SupplierMeasurementSubmissionId equals sdim.SupplierMeasurementSubmissionId
                                          join sdima in Context.SupplierDimensionMeasurementActual on sdim.Id equals sdima.SupplierDimensionMeasurementId
                                          join pm in Context.ParameterManagement on sdim.ParameterManagementId equals pm.Id
                                          where sdim.ParameterManagementId == xBarR.ParameterId
                                          group new { sdim, sdima, xBarR } by new { sdim.SupplierMeasurementSubmissionId, xBarR.SMSNo, xBarR.SMSState, xBarR.UpperTolerance, xBarR.LowerTolerance, xBarR.CreatedDate } into xBarRData
                                          select new SupplierSpcChartModel
                                          {
                                              FinalTextValue = (xBarRData.Max(k => !string.IsNullOrEmpty(k.sdima.ActualTextValue) ? Convert.ToDouble(k.sdima.ActualTextValue) : Constants.Zero)) - (xBarRData.Min(k => !string.IsNullOrEmpty(k.sdima.ActualTextValue) ? Convert.ToDouble(k.sdima.ActualTextValue) : Constants.Zero)),
                                              ParameterId = item.ParameterId,
                                              SupplierMeasurementSubmissionId = xBarRData.Key.SupplierMeasurementSubmissionId,
                                              SMSNoState = xBarRData.Key.SMSNo.Split("-").Last() + ' ' + xBarRData.Key.SMSState,
                                              ChartTypeId = RangeControlXBarR,
                                              SAPPartInspectionPlanId = item.SAPPartInspectionPlanId,
                                              TabId = tabId,
                                              UpperTolerance = xBarRData.Key.UpperTolerance,
                                              LowerTolerance = xBarRData.Key.LowerTolerance,
                                              CreatedDate = xBarRData.Key.CreatedDate,
                                          }).ToList();


            }

            return supplierSpcChartModels;
        }

        #endregion

        #region X-Bar-S ChartData
        private List<SupplierSpcChartModel> FillXbarSChartDataForMicroSection(string iP, int countValue, int skipValue, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {
            var latestSMSRecords = (from sms in Context.SupplierMeasurementSubmission
                                    where sms.IP.Trim() == iP.Trim() &&
                                    (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                    orderby sms.LastUpdated descending
                                    select new SupplierSpcChartModel
                                    {
                                        SupplierMeasurementSubmissionId = sms.Id,
                                        SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                        SMSNo = sms.SMSNo,
                                        SMSState = sms.StateType.Description,
                                        CreatedDate = sms.LastUpdated
                                    }).ToList();

            latestSMSRecords = CheckIsCurrentFormData(Constants.Thirty, smsId, latestSMSRecords).Take(countValue).ToList();


            IEnumerable<SupplierSpcChartModel> latestSMSDataRaw;
            latestSMSDataRaw = SkipAndTake(countValue, skipValue, latestSMSRecords);

            var latestSMSData = (from newSMS in latestSMSDataRaw
                                 join part in Context.PartMicrosection on newSMS.SAPPartInspectionPlanId equals part.SAPPartInspectionPlanId
                                 select new SupplierSpcChartModel
                                 {
                                     SupplierMeasurementSubmissionId = newSMS.SupplierMeasurementSubmissionId,
                                     ParameterId = part.ParameterManagementId,
                                     ChartTypeId = part.ChartTypeId,
                                     SAPPartInspectionPlanId = part.SAPPartInspectionPlanId,
                                     SMSNo = newSMS.SMSNo,
                                     SMSSize = newSMS.SMSNo.Split("-").Length,
                                     SMSState = newSMS.SMSState.Substring(0, 1),
                                     UpperTolerance = part.UpperTolerance,
                                     LowerTolerance = part.LowerTolerance,
                                     CreatedDate = newSMS.CreatedDate


                                 }).ToList();


            supplierSpcChartModels = (from xBarS in latestSMSData
                                      join smicro in Context.SupplierMicrosection on xBarS.SupplierMeasurementSubmissionId equals smicro.SupplierMeasurementSubmissionId
                                      join sma in Context.SupplierMicroSectionActual on smicro.Id equals sma.SupplierMicrosectionId
                                      join pm in Context.ParameterManagement on smicro.ParameterManagementId equals pm.Id
                                      where xBarS.ParameterId == smicro.ParameterManagementId
                                      group new { smicro, sma, pm, xBarS } by new { smicro.SupplierMeasurementSubmissionId, pm.Id, xBarS.SMSNo, xBarS.SMSState, xBarS.SMSSize, xBarS.UpperTolerance, xBarS.LowerTolerance, xBarS.CreatedDate } into xBarSData
                                      select new SupplierSpcChartModel
                                      {
                                          FinalTextValue = xBarSData.Average(k => !string.IsNullOrEmpty(k.sma.ActualTextValue) ? Convert.ToDouble(k.sma.ActualTextValue) : Constants.Zero),
                                          ParameterId = xBarSData.Key.Id,
                                          SMSNoState = xBarSData.Key.SMSNo.Split("-").Last() + ' ' + xBarSData.Key.SMSState,
                                          SupplierMeasurementSubmissionId = xBarSData.Key.SupplierMeasurementSubmissionId,
                                          ChartTypeId = (int)ChartType.xBarS,
                                          TabId = tabId,
                                          UpperTolerance = xBarSData.Key.UpperTolerance,
                                          LowerTolerance = xBarSData.Key.LowerTolerance,
                                          CreatedDate = xBarSData.Key.CreatedDate
                                      }).ToList();


            return supplierSpcChartModels;
        }

        private List<SupplierSpcChartModel> FillXBarSChartDataForFunctionVariable(string iP, int countValue, int skipValue, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {

            var latestSMSRecords = (from sms in Context.SupplierMeasurementSubmission
                                    where sms.IP.Trim() == iP.Trim() &&
                                    (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                    orderby sms.LastUpdated descending
                                    select new SupplierSpcChartModel
                                    {
                                        SupplierMeasurementSubmissionId = sms.Id,
                                        SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                        SMSNo = sms.SMSNo,
                                        SMSState = sms.StateType.Description,
                                        CreatedDate = sms.LastUpdated
                                    }).ToList();


            latestSMSRecords = CheckIsCurrentFormData(Constants.Thirty, smsId, latestSMSRecords).Take(countValue).ToList();

            IEnumerable<SupplierSpcChartModel> latestSMSDataRaw;
            latestSMSDataRaw = SkipAndTake(countValue, skipValue, latestSMSRecords);

            var latestSMSData = (from newSMS in latestSMSDataRaw
                                 join part in Context.PartFunParameter on newSMS.SAPPartInspectionPlanId equals part.SAPPartInspectionPlanId
                                 select new SupplierSpcChartModel
                                 {
                                     SupplierMeasurementSubmissionId = newSMS.SupplierMeasurementSubmissionId,
                                     ParameterId = part.ParameterManagementId,
                                     ChartTypeId = (int)ChartType.xBarS,
                                     SAPPartInspectionPlanId = part.SAPPartInspectionPlanId,
                                     SMSNo = newSMS.SMSNo,
                                     SMSSize = newSMS.SMSNo.Split("-").Length,
                                     SMSState = newSMS.SMSState.Substring(0, 1),
                                     TabId = tabId,
                                     UpperTolerance = part.UpperTolerance,
                                     LowerTolerance = part.LowerTolerance,
                                     CreatedDate = newSMS.CreatedDate
                                 }).ToList();


            supplierSpcChartModels = (from xBarS in latestSMSData
                                      join sfunvar in Context.SupplierFunctionVariable on xBarS.SupplierMeasurementSubmissionId equals sfunvar.SupplierMeasurementSubmissionId
                                      join smfun in Context.SupplierFunctionVariableActual on sfunvar.Id equals smfun.SupplierFunctionVariableId
                                      join pm in Context.ParameterManagement on sfunvar.ParameterManagementId equals pm.Id
                                      where xBarS.ParameterId == sfunvar.ParameterManagementId
                                      group new { sfunvar, smfun, pm, xBarS } by new { sfunvar.SupplierMeasurementSubmissionId, pm.Id, xBarS.SMSNo, xBarS.SMSState, xBarS.SMSSize, xBarS.UpperTolerance, xBarS.LowerTolerance, xBarS.CreatedDate } into xBarRData
                                      select new SupplierSpcChartModel
                                      {
                                          FinalTextValue = xBarRData.Average(k => !string.IsNullOrEmpty(k.smfun.ActualTextValue) ? Convert.ToDouble(k.smfun.ActualTextValue) : Constants.Zero),
                                          ParameterId = xBarRData.Key.Id,
                                          SupplierMeasurementSubmissionId = xBarRData.Key.SupplierMeasurementSubmissionId,
                                          SMSNoState = xBarRData.Key.SMSNo.Split("-").Last() + ' ' + xBarRData.Key.SMSState,
                                          ChartTypeId = (int)ChartType.xBarS,
                                          TabId = tabId,
                                          UpperTolerance = xBarRData.Key.UpperTolerance,
                                          LowerTolerance = xBarRData.Key.LowerTolerance,
                                          CreatedDate = xBarRData.Key.CreatedDate

                                      }).ToList();


            return supplierSpcChartModels;
        }

        private List<SupplierSpcChartModel> FillXBarSChartDataForDimensionalMeasurement(string iP, int countValue, int skipValue, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {


            var latestSMSRecords = (from sms in Context.SupplierMeasurementSubmission
                                    where sms.IP.Trim() == iP.Trim() &&
                                    (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                    orderby sms.LastUpdated descending
                                    select new SupplierSpcChartModel
                                    {
                                        SupplierMeasurementSubmissionId = sms.Id,
                                        SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                        SMSNo = sms.SMSNo,
                                        SMSState = sms.StateType.Description,
                                        CreatedDate = sms.LastUpdated
                                    }).ToList();

            latestSMSRecords = CheckIsCurrentFormData(countValue, smsId, latestSMSRecords).Take(countValue).ToList();


            IEnumerable<SupplierSpcChartModel> latestSMSDataRaw;
            latestSMSDataRaw = SkipAndTake(countValue, skipValue, latestSMSRecords);

            var latestSMSData = (from newSMS in latestSMSDataRaw
                                 join part in Context.PartMeasurementParameter on newSMS.SAPPartInspectionPlanId equals part.SAPPartInspectionPlanId
                                 select new SupplierSpcChartModel
                                 {
                                     SupplierMeasurementSubmissionId = newSMS.SupplierMeasurementSubmissionId,
                                     ParameterId = part.ParameterManagementId,
                                     ChartTypeId = (int)ChartType.xBarS,
                                     SAPPartInspectionPlanId = part.SAPPartInspectionPlanId,
                                     SMSNo = newSMS.SMSNo,
                                     SMSSize = newSMS.SMSNo.Split("-").Length,
                                     SMSState = newSMS.SMSState.Substring(0, 1),
                                     TabId = tabId,
                                     UpperTolerance = part.UpperTolerance,
                                     LowerTolerance = part.LowerTolerance,
                                     CreatedDate = newSMS.CreatedDate
                                 }).ToList();


            supplierSpcChartModels = (from xBarS in latestSMSData
                                      join sdim in Context.SupplierDimensionMeasurement on xBarS.SupplierMeasurementSubmissionId equals sdim.SupplierMeasurementSubmissionId
                                      join sdima in Context.SupplierDimensionMeasurementActual on sdim.Id equals sdima.SupplierDimensionMeasurementId
                                      join pm in Context.ParameterManagement on sdim.ParameterManagementId equals pm.Id
                                      where sdim.ParameterManagementId == xBarS.ParameterId
                                      group new { sdim, sdima, pm, xBarS } by new { sdim.SupplierMeasurementSubmissionId, pm.Id, xBarS.SMSNo, xBarS.SMSState, xBarS.SMSSize, xBarS.UpperTolerance, xBarS.LowerTolerance, xBarS.CreatedDate } into xBarRData
                                      select new SupplierSpcChartModel
                                      {
                                          FinalTextValue = xBarRData.Average(k => !string.IsNullOrEmpty(k.sdima.ActualTextValue) ? Convert.ToDouble(k.sdima.ActualTextValue) : Constants.Zero),
                                          ParameterId = xBarRData.Key.Id,
                                          SupplierMeasurementSubmissionId = xBarRData.Key.SupplierMeasurementSubmissionId,
                                          SMSNoState = xBarRData.Key.SMSNo.Split("-").Last() + ' ' + xBarRData.Key.SMSState,
                                          ChartTypeId = (int)ChartType.xBarS,
                                          TabId = tabId,
                                          UpperTolerance = xBarRData.Key.UpperTolerance,
                                          LowerTolerance = xBarRData.Key.LowerTolerance,
                                          CreatedDate = xBarRData.Key.CreatedDate
                                      }).ToList();


            return supplierSpcChartModels;
        }

        #endregion

        #region Range-XBar-S ChartData
        private List<SupplierSpcChartModel> FillRangeXBarSChartDataForMicroSection(string iP, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {
            var latestSMSDataRaw = (from sms in Context.SupplierMeasurementSubmission
                                    where sms.IP.Trim() == iP.Trim() &&
                                    (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                    orderby sms.LastUpdated descending
                                    select new SupplierSpcChartModel
                                    {
                                        SupplierMeasurementSubmissionId = sms.Id,
                                        SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                        SMSNo = sms.SMSNo,
                                        SMSState = sms.StateType.Description,
                                        CreatedDate = sms.LastUpdated
                                    }).ToList();

            latestSMSDataRaw = CheckIsCurrentFormData(Constants.Thirty, smsId, latestSMSDataRaw).Take(Constants.Thirty).ToList();


            var latestSMSData = (from newSMS in latestSMSDataRaw
                                 join part in Context.PartMicrosection on newSMS.SAPPartInspectionPlanId equals part.SAPPartInspectionPlanId
                                 select new SupplierSpcChartModel
                                 {
                                     SupplierMeasurementSubmissionId = newSMS.SupplierMeasurementSubmissionId,
                                     ParameterId = part.ParameterManagementId,
                                     ChartTypeId = part.ChartTypeId,
                                     SAPPartInspectionPlanId = part.SAPPartInspectionPlanId,
                                     SMSNo = newSMS.SMSNo,
                                     SMSState = newSMS.SMSState.Substring(0, 1),
                                     UpperTolerance = part.UpperTolerance,
                                     LowerTolerance = part.LowerTolerance,
                                     CreatedDate = newSMS.CreatedDate

                                 }).ToList();

            foreach (var item in latestSMSData)
            {
                supplierSpcChartModels = (from xBarR in latestSMSData
                                          join smicro in Context.SupplierMicrosection on xBarR.SupplierMeasurementSubmissionId equals smicro.SupplierMeasurementSubmissionId
                                          join sma in Context.SupplierMicroSectionActual on smicro.Id equals sma.SupplierMicrosectionId
                                          join pm in Context.ParameterManagement on smicro.ParameterManagementId equals pm.Id
                                          where xBarR.ParameterId == smicro.ParameterManagementId
                                          group new { smicro, sma, xBarR } by new { smicro.SupplierMeasurementSubmissionId, xBarR.SMSNo, xBarR.SMSState, xBarR.UpperTolerance, xBarR.LowerTolerance, xBarR.CreatedDate } into xBarRData
                                          select new SupplierSpcChartModel
                                          {
                                              FinalTextValue = CalculateStandardDeviation((xBarRData.Average(k => !string.IsNullOrEmpty(k.sma.ActualTextValue) ? Convert.ToDouble(k.sma.ActualTextValue) : Constants.Zero)), (xBarRData.Select(k => !string.IsNullOrEmpty(k.sma.ActualTextValue) ? Convert.ToDouble(k.sma.ActualTextValue) : Constants.Zero).ToList())),
                                              ParameterId = item.ParameterId,
                                              SupplierMeasurementSubmissionId = xBarRData.Key.SupplierMeasurementSubmissionId,
                                              SMSNoState = xBarRData.Key.SMSNo.Split("-").Last() + ' ' + xBarRData.Key.SMSState,
                                              ChartTypeId = RangeControlXBarS,
                                              TabId = tabId,
                                              UpperTolerance = xBarRData.Key.UpperTolerance,
                                              LowerTolerance = xBarRData.Key.LowerTolerance,
                                              CreatedDate = xBarRData.Key.CreatedDate

                                          }).ToList();
            }

            return supplierSpcChartModels;
        }

        private List<SupplierSpcChartModel> FillRangeXBarSChartDataForFunctionVariable(string iP, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {
            var latestSMSDataRaw = (from sms in Context.SupplierMeasurementSubmission
                                    where sms.IP.Trim() == iP.Trim() &&
                                    (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                    orderby sms.LastUpdated descending
                                    select new SupplierSpcChartModel
                                    {
                                        SupplierMeasurementSubmissionId = sms.Id,
                                        SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                        SMSNo = sms.SMSNo,
                                        SMSState = sms.StateType.Description,
                                        CreatedDate = sms.LastUpdated
                                    }).ToList();

            latestSMSDataRaw = CheckIsCurrentFormData(Constants.Thirty, smsId, latestSMSDataRaw).Take(Constants.Thirty).ToList();


            var latestSMSData = (from newSMS in latestSMSDataRaw
                                 join part in Context.PartFunParameter on newSMS.SAPPartInspectionPlanId equals part.SAPPartInspectionPlanId
                                 select new SupplierSpcChartModel
                                 {
                                     SupplierMeasurementSubmissionId = newSMS.SupplierMeasurementSubmissionId,
                                     ParameterId = part.ParameterManagementId,
                                     ChartTypeId = RangeControlXBarS,
                                     SAPPartInspectionPlanId = part.SAPPartInspectionPlanId,
                                     SMSNo = newSMS.SMSNo,
                                     SMSState = newSMS.SMSState.Substring(0, 1),
                                     TabId = tabId,
                                     UpperTolerance = part.UpperTolerance,
                                     LowerTolerance = part.LowerTolerance,
                                     CreatedDate = newSMS.CreatedDate

                                 }).ToList();

            foreach (var item in latestSMSData)
            {

                supplierSpcChartModels = (from xBarR in latestSMSData
                                          join sfunvar in Context.SupplierFunctionVariable on xBarR.SupplierMeasurementSubmissionId equals sfunvar.SupplierMeasurementSubmissionId
                                          join smfun in Context.SupplierFunctionVariableActual on sfunvar.Id equals smfun.SupplierFunctionVariableId
                                          join pm in Context.ParameterManagement on sfunvar.ParameterManagementId equals pm.Id
                                          where sfunvar.ParameterManagementId == xBarR.ParameterId
                                          group new { sfunvar, smfun, xBarR } by new { sfunvar.SupplierMeasurementSubmissionId, xBarR.SMSNo, xBarR.SMSState, xBarR.UpperTolerance, xBarR.LowerTolerance, xBarR.CreatedDate } into xBarRData
                                          select new SupplierSpcChartModel
                                          {
                                              FinalTextValue = CalculateStandardDeviation((xBarRData.Average(k => !string.IsNullOrEmpty(k.smfun.ActualTextValue) ? Convert.ToDouble(k.smfun.ActualTextValue) : Constants.Zero)), (xBarRData.Select(k => !string.IsNullOrEmpty(k.smfun.ActualTextValue) ? Convert.ToDouble(k.smfun.ActualTextValue) : Constants.Zero).ToList())),
                                              ParameterId = item.ParameterId,
                                              SupplierMeasurementSubmissionId = xBarRData.Key.SupplierMeasurementSubmissionId,
                                              SMSNoState = xBarRData.Key.SMSNo.Split("-").Last() + ' ' + xBarRData.Key.SMSState,
                                              ChartTypeId = RangeControlXBarS,
                                              SAPPartInspectionPlanId = item.SAPPartInspectionPlanId,
                                              TabId = tabId,
                                              UpperTolerance = xBarRData.Key.UpperTolerance,
                                              LowerTolerance = xBarRData.Key.LowerTolerance,
                                              CreatedDate = xBarRData.Key.CreatedDate

                                          }).ToList();


            }

            return supplierSpcChartModels;
        }

        private List<SupplierSpcChartModel> FillRangeXBarSChartDataForDimensionalMeasurement(string iP, List<SupplierSpcChartModel> supplierSpcChartModels, int tabId, int smsId)
        {
            var latestSMSDataRaw = (from sms in Context.SupplierMeasurementSubmission
                                    where sms.IP.Trim() == iP.Trim() &&
                                    (sms.StateTypeId == (int)StateType.Pending_Approval_By_Jabil || sms.StateTypeId == (int)StateType.Approved_By_SQE || sms.StateTypeId == (int)StateType.Rejected_By_SQE || sms.StateTypeId == (int)StateType.Submitted_By_Supplier)
                                    orderby sms.LastUpdated descending
                                    select new SupplierSpcChartModel
                                    {
                                        SupplierMeasurementSubmissionId = sms.Id,
                                        SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                        SMSNo = sms.SMSNo,
                                        SMSState = sms.StateType.Description,
                                        CreatedDate = sms.LastUpdated
                                    }).ToList();

            latestSMSDataRaw = CheckIsCurrentFormData(Constants.Thirty, smsId, latestSMSDataRaw).Take(Constants.Thirty).ToList();


            var latestSMSData = (from newSMS in latestSMSDataRaw
                                 join part in Context.PartMeasurementParameter on newSMS.SAPPartInspectionPlanId equals part.SAPPartInspectionPlanId
                                 select new SupplierSpcChartModel
                                 {
                                     SupplierMeasurementSubmissionId = newSMS.SupplierMeasurementSubmissionId,
                                     ParameterId = part.ParameterManagementId,
                                     ChartTypeId = RangeControlXBarS,
                                     SAPPartInspectionPlanId = part.SAPPartInspectionPlanId,
                                     SMSNo = newSMS.SMSNo,
                                     SMSState = newSMS.SMSState.Substring(0, 1),
                                     UpperTolerance = part.UpperTolerance,
                                     LowerTolerance = part.LowerTolerance,
                                     CreatedDate = newSMS.CreatedDate

                                 }).ToList();

            foreach (var item in latestSMSData)
            {
                supplierSpcChartModels = (from xBarR in latestSMSData
                                          join sdim in Context.SupplierDimensionMeasurement on xBarR.SupplierMeasurementSubmissionId equals sdim.SupplierMeasurementSubmissionId
                                          join sdima in Context.SupplierDimensionMeasurementActual on sdim.Id equals sdima.SupplierDimensionMeasurementId
                                          join pm in Context.ParameterManagement on sdim.ParameterManagementId equals pm.Id
                                          where sdim.ParameterManagementId == xBarR.ParameterId
                                          group new { sdim, sdima, xBarR } by new { sdim.SupplierMeasurementSubmissionId, xBarR.SMSNo, xBarR.SMSState, xBarR.UpperTolerance, xBarR.LowerTolerance, xBarR.CreatedDate } into xBarRData
                                          select new SupplierSpcChartModel
                                          {
                                              FinalTextValue = CalculateStandardDeviation((xBarRData.Average(k => !string.IsNullOrEmpty(k.sdima.ActualTextValue) ? Convert.ToDouble(k.sdima.ActualTextValue) : Constants.Zero)), (xBarRData.Select(k => !string.IsNullOrEmpty(k.sdima.ActualTextValue) ? Convert.ToDouble(k.sdima.ActualTextValue) : Constants.Zero).ToList())),
                                              ParameterId = item.ParameterId,
                                              SupplierMeasurementSubmissionId = xBarRData.Key.SupplierMeasurementSubmissionId,
                                              SMSNoState = xBarRData.Key.SMSNo.Split("-").Last() + ' ' + xBarRData.Key.SMSState,
                                              ChartTypeId = RangeControlXBarS,
                                              SAPPartInspectionPlanId = item.SAPPartInspectionPlanId,
                                              TabId = tabId,
                                              UpperTolerance = xBarRData.Key.UpperTolerance,
                                              LowerTolerance = xBarRData.Key.LowerTolerance,
                                              CreatedDate = xBarRData.Key.CreatedDate
                                          }).ToList();


            }

            return supplierSpcChartModels;
        }

        #endregion

        static double CalculateStandardDeviation(double average, IEnumerable<double> actualValues)
        {
            double stdDeviationValue = 0;

            if (actualValues.Any())
            {
                double sum = actualValues.Sum(d => Math.Pow(d - average, 2));
                stdDeviationValue = Math.Sqrt((sum) / actualValues.Count());
            }
            return stdDeviationValue;
        }

        private static List<SupplierSpcChartModel> CheckIsCurrentFormData(int countValue, int smsId, List<SupplierSpcChartModel> latestSMSRecords)
        {
            if (smsId != 0)
            {
                var currentClickedSmsForm = latestSMSRecords.FirstOrDefault(x => x.SupplierMeasurementSubmissionId == smsId);
                if (currentClickedSmsForm != null)
                {
                    var filteredRecordByDate = (from sms in latestSMSRecords
                                                where sms.CreatedDate <= currentClickedSmsForm.CreatedDate
                                                select new SupplierSpcChartModel
                                                {
                                                    SupplierMeasurementSubmissionId = sms.SupplierMeasurementSubmissionId,
                                                    SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                                    SMSNo = sms.SMSNo,
                                                    SMSState = sms.SMSState,
                                                    CreatedDate = sms.CreatedDate,
                                                }).Take(countValue).ToList();

                    latestSMSRecords = filteredRecordByDate;
                }
            }

            return latestSMSRecords;
        }

        private static List<SupplierSpcChartModel> CheckIsCurrentFormDataIMR(int countValue, int smsId, List<SupplierSpcChartModel> latestSMSRecordsIMR)
        {
            if (smsId != 0)
            {
                var currentClickedSmsForm = latestSMSRecordsIMR.FirstOrDefault(x => x.SupplierMeasurementSubmissionId == smsId);
                if (currentClickedSmsForm != null)
                {
                    var filteredRecordByDate = (from sms in latestSMSRecordsIMR
                                                where sms.CreatedDate <= currentClickedSmsForm.CreatedDate
                                                select new SupplierSpcChartModel
                                                {
                                                    ActualValueIndex = sms.ActualValueIndex,
                                                    FinalTextValue = sms.FinalTextValue,
                                                    ParameterId = sms.ParameterId,
                                                    SupplierMeasurementSubmissionId = sms.SupplierMeasurementSubmissionId,
                                                    ChartTypeId = sms.ChartTypeId,
                                                    SAPPartInspectionPlanId = sms.SAPPartInspectionPlanId,
                                                    SMSNoState = sms.SMSNoState,
                                                    TabId = sms.TabId,
                                                    UpperTolerance = sms.UpperTolerance,
                                                    LowerTolerance = sms.LowerTolerance,
                                                    CreatedDate = sms.CreatedDate


                                                }).Take(countValue).ToList();

                    latestSMSRecordsIMR = filteredRecordByDate;
                }
            }

            return latestSMSRecordsIMR;
        }

        private static int GetCountOfIMRParameters(int countValue, List<SupplierSpcChartModel> latestImrChartData)
        {
            return (latestImrChartData.Select(wf => wf.ParameterId).Distinct().Count() * countValue);
        }

    }

}
