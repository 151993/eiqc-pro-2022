/* Auto Generated Code By AutoCodeGen Jabil © 2Constants.Zero19 */


using AutoMapper;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.SupplierFailedQuantityCommand;
using QSS.eIQC.Handlers.Commands.SupplierSpcChartCommand;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SAPPartInspectionPlan Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("SupplierSpcChartSummary")]

    public class SupplierSpcChartSummaryODataController : BaseODataController
    {
        private const int FetchCount = 30;
        private const int SkipCount = 5;
        private const int RangeControlXBarR = 4;
        private const int RangeControlXBarS = 5;
        private const int RangeIMR = 6;
        private const double CpkConstant = 1.67;
        private const int Sms30Count = 30;


        private const int RuleOneOnePointOfControlLimit = 1;
        private const int RuleTwoAscendingOrDescending = 6;
        private const int RuleThreeUpAndDown = 14;
        private const int RuleFourOneSideOfMean = 9;
        private const int RuleFiveUpperOrLower = 2;
        private const int RuleFiveUpperOrLowerMax = 3;
        private const int RuleSixFourOrFiveConsecutivePoint = 4;
        private const int RuleSixFourOrFiveConsecutivePointMax = 5;
        private const int RuleSevenFifteenPoints = 15;
        private const int RuleEightEightPointsOnTwoSigmaZone = 8;
        private const int LastThree = 2;
        private const int LastFive = 4;

        private const int RuleOne = 1;
        private const int RuleTwo = 2;
        private const int RuleThree = 3;
        private const int RuleFour = 4;
        private const int RuleFive = 5;
        private const int RuleSix = 6;
        private const int RuleSeven = 7;
        private const int RuleEight = 8;

        private const int PackingInspectionTabId = 13;
        private const int SapBasedTabId = 14;
        private const int TestReportTabId = 11;

        List<SupplierSpcChartResultSummary> supplierSpcChartResultSummaries = new List<SupplierSpcChartResultSummary>();
        List<SupplierFailedQuantityModel> supplierFailedQuantityModelList = new List<SupplierFailedQuantityModel>();
        private readonly IQSSContext _context;
        private readonly IMapper _mapper;
        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public SupplierSpcChartSummaryODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetSupplierSpcChartSummary(iP={iP}, smsId={smsId})")]
        public IEnumerable<SupplierSpcChartResultSummary> GetSupplierSpcChartSummary(string iP, int smsId)
        {

            SupplierSpcChartODataController supplierSpcChartODataController = new SupplierSpcChartODataController(_context, _mapper);

            SupplierFailedQuantityODataController supplierFailedQuantityODataController = new SupplierFailedQuantityODataController(_context, _mapper);

            var smsTabsData = Context.SupplierMeasurementSubmission.Where(x => x.Id == smsId)?
                .Include(x => x.SupplierMicrosectionParameters)
                .Include(x => x.SupplierFunctionVariables)
                .Include(x => x.SupplierDimensionMeasurements)
                .FirstOrDefault();

            if (smsTabsData != null)
            {
                // Micro section
                foreach (var microSectionParameter in smsTabsData.SupplierMicrosectionParameters)
                {
                    microSectionParameter.ChartTypeId = microSectionParameter.ChartTypeId == null ? 0 : microSectionParameter.ChartTypeId;
                    IEnumerable<SupplierSpcChartModel> microSectionActualDataFor30 = supplierSpcChartODataController.GetSPCCPKChartStandardAverageForSummaryResults_MicroSection(iP, FetchCount, 0, smsId, (int)microSectionParameter.ChartTypeId);
                    IEnumerable<SupplierSpcChartModel> microSectionActualDataFor25 = supplierSpcChartODataController.GetSPCCPKChartStandardAverageForSummaryResults_MicroSection(iP, FetchCount, SkipCount, smsId, (int)microSectionParameter.ChartTypeId);

                    EvaluateMavericLot(microSectionActualDataFor30, microSectionActualDataFor25, (int)ParameterManagementType.MicroSection, supplierSpcChartResultSummaries, microSectionParameter.ChartTypeId);
                }

                if (supplierSpcChartResultSummaries.Where(x => x.TabId == (int)ParameterManagementType.MicroSection).FirstOrDefault() == null)
                {
                    supplierFailedQuantityModelList.Clear();
                    SupplierSpcChartResultSummary supplierSpcChartResultSummary = new SupplierSpcChartResultSummary();
                    supplierFailedQuantityODataController.UpdateFailedQuantityForMicroSection(smsId, supplierFailedQuantityModelList);
                    supplierSpcChartResultSummaries.Add(SetAllTabPassFailData(supplierSpcChartResultSummary, (int)ParameterManagementType.MicroSection, supplierFailedQuantityModelList));
                }

                // Function variable
                foreach (var functionVariable in smsTabsData.SupplierFunctionVariables)
                {
                    functionVariable.ChartTypeId = functionVariable.ChartTypeId == null ? 0 : functionVariable.ChartTypeId;
                    IEnumerable<SupplierSpcChartModel> functionVariableActualDataFor30 = supplierSpcChartODataController.GetSPCCPKChartStandardAverageForSummaryResults_FunctionVariable(iP, FetchCount, 0, smsId, (int)functionVariable.ChartTypeId);
                    IEnumerable<SupplierSpcChartModel> functionVariableActualDataFor25 = supplierSpcChartODataController.GetSPCCPKChartStandardAverageForSummaryResults_FunctionVariable(iP, FetchCount, SkipCount, smsId, (int)functionVariable.ChartTypeId);

                    EvaluateMavericLot(functionVariableActualDataFor30, functionVariableActualDataFor25, (int)ParameterManagementType.FunctionVariable, supplierSpcChartResultSummaries, functionVariable.ChartTypeId);
                }

                if (supplierSpcChartResultSummaries.Where(x => x.TabId == (int)ParameterManagementType.FunctionVariable).FirstOrDefault() == null)
                {
                    supplierFailedQuantityModelList.Clear();
                    SupplierSpcChartResultSummary supplierSpcChartResultSummary = new SupplierSpcChartResultSummary();
                    supplierFailedQuantityODataController.UpdateFailedQuantityForFunctionVariable(smsId, supplierFailedQuantityModelList);
                    supplierSpcChartResultSummaries.Add(SetAllTabPassFailData(supplierSpcChartResultSummary, (int)ParameterManagementType.FunctionVariable, supplierFailedQuantityModelList));
                }

                // Dimensional Measurement
                foreach (var dimensionalMeasurement in smsTabsData.SupplierDimensionMeasurements)
                {
                    dimensionalMeasurement.ChartTypeId = dimensionalMeasurement.ChartTypeId == null ? 0 : dimensionalMeasurement.ChartTypeId;
                    IEnumerable <SupplierSpcChartModel> dimensionalMeasurementActualDataFor30 = supplierSpcChartODataController.GetSPCCPKChartStandardAverageForSummaryResults_DimensionalMeasurement(iP, FetchCount, 0, smsId, (int)dimensionalMeasurement.ChartTypeId);
                    IEnumerable<SupplierSpcChartModel> dimensionalMeasurementActualDataFor25 = supplierSpcChartODataController.GetSPCCPKChartStandardAverageForSummaryResults_DimensionalMeasurement(iP, FetchCount, SkipCount, smsId, (int)dimensionalMeasurement.ChartTypeId);

                    EvaluateMavericLot(dimensionalMeasurementActualDataFor30, dimensionalMeasurementActualDataFor25, (int)ParameterManagementType.DimensionalMeasurements, supplierSpcChartResultSummaries, dimensionalMeasurement.ChartTypeId);
                }

                if (supplierSpcChartResultSummaries.Where(x => x.TabId == (int)ParameterManagementType.DimensionalMeasurements).FirstOrDefault() == null)
                {
                    supplierFailedQuantityModelList.Clear();
                    SupplierSpcChartResultSummary supplierSpcChartResultSummary = new SupplierSpcChartResultSummary();
                    supplierFailedQuantityODataController.UpdateFailedQuantityForDimensionalMeasurement(smsId, supplierFailedQuantityModelList);
                    supplierSpcChartResultSummaries.Add(SetAllTabPassFailData(supplierSpcChartResultSummary, (int)ParameterManagementType.DimensionalMeasurements, supplierFailedQuantityModelList));
                }
            }

            if (smsId != 0)
            {
                // MicroSection
                supplierFailedQuantityModelList.Clear();
                var supplierSpcChartResultSummaryMicroSection = supplierSpcChartResultSummaries.FirstOrDefault(x => x.TabId == (int)ParameterManagementType.MicroSection);
                if (supplierSpcChartResultSummaryMicroSection != null)
                {
                    supplierFailedQuantityODataController.UpdateFailedQuantityForMicroSection(smsId, supplierFailedQuantityModelList);
                    bool isFailPassMicro = supplierFailedQuantityModelList.Any(x => x.IsFail == true && x.FailIndicator == 0 && x.TabId == (int)ParameterManagementType.MicroSection);
                    supplierSpcChartResultSummaryMicroSection.TabResult = isFailPassMicro;
                    if (supplierFailedQuantityModelList.Any(x => x.TabId == (int)ParameterManagementType.MicroSection))
                    {
                        supplierSpcChartResultSummaryMicroSection.FailIndicator = isFailPassMicro ? 0 : 1;
                    }
                    else
                    {
                        supplierSpcChartResultSummaryMicroSection.FailIndicator = 2;
                    }

                }

                // Dimention Measurement
                supplierFailedQuantityModelList.Clear();
                var supplierSpcChartResultSummaryDimentions = supplierSpcChartResultSummaries.FirstOrDefault(x => x.TabId == (int)ParameterManagementType.DimensionalMeasurements);
                if (supplierSpcChartResultSummaryDimentions != null)
                {
                    supplierFailedQuantityODataController.UpdateFailedQuantityForDimensionalMeasurement(smsId, supplierFailedQuantityModelList);
                    bool isFailPassDim = supplierFailedQuantityModelList.Any(x => x.IsFail == true && x.FailIndicator == 0 && x.TabId == (int)ParameterManagementType.DimensionalMeasurements);
                    supplierSpcChartResultSummaryDimentions.TabResult = isFailPassDim;
                    if (supplierFailedQuantityModelList.Any(x => x.TabId == (int)ParameterManagementType.DimensionalMeasurements))
                    {
                        supplierSpcChartResultSummaryDimentions.FailIndicator = isFailPassDim ? 0 : 1;
                    }
                    else
                    {
                        supplierSpcChartResultSummaryDimentions.FailIndicator = 2;
                    }
                }


                // Function Variable
                supplierFailedQuantityModelList.Clear();
                var supplierSpcChartResultSummaryFunctionVariable = supplierSpcChartResultSummaries.FirstOrDefault(x => x.TabId == (int)ParameterManagementType.FunctionVariable);
                if (supplierSpcChartResultSummaryFunctionVariable != null)
                {
                    supplierFailedQuantityODataController.UpdateFailedQuantityForFunctionVariable(smsId, supplierFailedQuantityModelList);
                    bool isFailPassFV = supplierFailedQuantityModelList.Count() > 0 ? supplierFailedQuantityModelList.Any(x => x.IsFail == true && x.FailIndicator == 0 && x.TabId == (int)ParameterManagementType.FunctionVariable) : false;
                    supplierSpcChartResultSummaryFunctionVariable.TabResult = isFailPassFV;
                    if (supplierFailedQuantityModelList.Any(x => x.TabId == (int)ParameterManagementType.FunctionVariable))
                    {
                        supplierSpcChartResultSummaryFunctionVariable.FailIndicator = isFailPassFV ? 0 : 1;
                    }
                    else
                    {
                        supplierSpcChartResultSummaryFunctionVariable.FailIndicator = 2;
                    }
                }

                // sapBased tab
                SupplierSpcChartResultSummary supplierSpcChartResultSummary = new SupplierSpcChartResultSummary();
                supplierFailedQuantityODataController.UpdateFailedQuantityForSAPBased(smsId, supplierFailedQuantityModelList);
                supplierSpcChartResultSummaries.Add(SetAllTabPassFailData(supplierSpcChartResultSummary, SapBasedTabId, supplierFailedQuantityModelList));

                // packingInspection tab
                supplierFailedQuantityModelList.Clear();
                supplierSpcChartResultSummary = new SupplierSpcChartResultSummary();
                supplierFailedQuantityODataController.UpdateFailedQuantityForPackingInspection(smsId, supplierFailedQuantityModelList);
                supplierSpcChartResultSummaries.Add(SetAllTabPassFailData(supplierSpcChartResultSummary, PackingInspectionTabId, supplierFailedQuantityModelList));




                //Spec With MMC
                supplierFailedQuantityModelList.Clear();
                supplierSpcChartResultSummary = new SupplierSpcChartResultSummary();
                supplierFailedQuantityODataController.UpdateFailedQuantityForMPosition(smsId, supplierFailedQuantityModelList);
                supplierSpcChartResultSummaries.Add(SetAllTabPassFailData(supplierSpcChartResultSummary, (int)ParameterManagementType.SpecWithMMC, supplierFailedQuantityModelList));

                //Spec With LMC
                supplierFailedQuantityModelList.Clear();
                supplierSpcChartResultSummary = new SupplierSpcChartResultSummary();
                supplierFailedQuantityODataController.UpdateFailedQuantityForLPosition(smsId, supplierFailedQuantityModelList);
                supplierSpcChartResultSummaries.Add(SetAllTabPassFailData(supplierSpcChartResultSummary, (int)ParameterManagementType.SpecWithLMC, supplierFailedQuantityModelList));

                // Function Attribute
                supplierFailedQuantityModelList.Clear();
                supplierSpcChartResultSummary = new SupplierSpcChartResultSummary();

                supplierFailedQuantityODataController.UpdateFailedQuantityForFunctionAttribute(smsId, supplierFailedQuantityModelList);
                supplierSpcChartResultSummaries.Add(SetAllTabPassFailData(supplierSpcChartResultSummary, (int)ParameterManagementType.FunctionAttribute, supplierFailedQuantityModelList));

                // Date Code
                supplierFailedQuantityModelList.Clear();
                supplierSpcChartResultSummary = new SupplierSpcChartResultSummary();
                supplierFailedQuantityODataController.UpdateFailedQuantityForDateCode(smsId, supplierFailedQuantityModelList);
                supplierSpcChartResultSummaries.Add(SetAllTabPassFailData(supplierSpcChartResultSummary, (int)ParameterManagementType.DateCode, supplierFailedQuantityModelList));

                // Bow - Twist
                supplierFailedQuantityModelList.Clear();
                supplierSpcChartResultSummary = new SupplierSpcChartResultSummary();
                supplierFailedQuantityODataController.UpdateFailedQuantityForBowTwist(smsId, supplierFailedQuantityModelList);
                supplierSpcChartResultSummaries.Add(SetAllTabPassFailData(supplierSpcChartResultSummary, (int)ParameterManagementType.BowAndTwist, supplierFailedQuantityModelList));

                // Test report
                supplierFailedQuantityModelList.Clear();
                supplierSpcChartResultSummary = new SupplierSpcChartResultSummary();
                supplierFailedQuantityODataController.UpdateFailedQuantityForTestReport(smsId, supplierFailedQuantityModelList);
                supplierSpcChartResultSummaries.Add(SetAllTabPassFailData(supplierSpcChartResultSummary, TestReportTabId, supplierFailedQuantityModelList));


                //visual inspection
                supplierFailedQuantityModelList.Clear();
                supplierSpcChartResultSummary = new SupplierSpcChartResultSummary();
                supplierFailedQuantityODataController.UpdateFailedQuantityForVisualInspection(smsId, supplierFailedQuantityModelList);
                supplierSpcChartResultSummaries.Add(SetAllTabPassFailData(supplierSpcChartResultSummary, (int)ParameterManagementType.VisualInspection, supplierFailedQuantityModelList));

            }

            return supplierSpcChartResultSummaries;
        }

        private void AddDefaultSupplierSpcSummaryObject(int tabId)
        {
            SupplierSpcChartResultSummary supplierSpcChartResultSummary = new SupplierSpcChartResultSummary();
            supplierSpcChartResultSummary.MavericLotDetected = false;
            supplierSpcChartResultSummary.TabId = tabId;
            supplierSpcChartResultSummaries.Add(supplierSpcChartResultSummary);
        }


        private double? CalculateStandardDeviation(IEnumerable<SupplierSpcChartModel> supplierSpcChartModel)
        {
            double? result = 0;

            if (supplierSpcChartModel.Any())
            {
                double? average = supplierSpcChartModel.Average(k => k.FinalTextValue);
                double sum = supplierSpcChartModel.Sum(d => Math.Pow(((double)(Convert.ToDouble(d.FinalTextValue) - average)), 2));
                result = Math.Sqrt((sum) / supplierSpcChartModel.Count());
            }
            return result;
        }


        private double? CalculateAverage(IEnumerable<SupplierSpcChartModel> supplierSpcChartModel)
        {
            double? average = 0;
            if (supplierSpcChartModel.Any())
            {
                average = supplierSpcChartModel.Average(k => k.FinalTextValue);
            }
            return average;
        }


        private double? GetSPCChartCalculationUCL(double? averageValue, double? stdValue)
        {
            return averageValue + (3 * stdValue);
        }

        private double? GetSPCChartCalculationLCL(double? averageValue, double? stdValue)
        {
            return averageValue - (3 * stdValue);
        }

        private double? GetSPCChartCalculationUCLForIMR(double? averageValue, double? rangeAverage)
        {
            return averageValue + (2.66 * rangeAverage);
        }

        private double? GetSPCChartCalculationLCLForIMR(double? averageValue, double? rangeAverage)
        {
            return averageValue - (2.66 * rangeAverage);
        }

        private double GetSPCCPKCalculation(double cpkU, double cpkL)
        {
            return Math.Min(cpkU, cpkL);
        }

        private double? GetSPCChartCalculationCpkU(double? upperToleranceValue, double? averageValue, double? stdValue)
        {
            return (upperToleranceValue - averageValue) / (3 * stdValue);
        }

        private double? GetSPCChartCalculationCpkL(double? lowerToleranceValue, double? averageValue, double? stdValue)
        {
            return (averageValue - lowerToleranceValue) / (3 * stdValue);
        }


        private bool EvaluateMavericLot(IEnumerable<SupplierSpcChartModel> chartActualDataFor30, IEnumerable<SupplierSpcChartModel> chartActualDataFor25,
                 int tabId, List<SupplierSpcChartResultSummary> supplierSpcChartResultSummaries, int? chartTypeId)
        {
            SupplierSpcChartResultSummary supplierSpcChartResultSummary = new SupplierSpcChartResultSummary();
            if (chartActualDataFor30 != null && chartActualDataFor30.Count() >= Sms30Count)
            {
                switch (chartTypeId)
                {
                    case (int)ChartType.xBarR:
                        if(!CheckMavericLotForEachChart(chartActualDataFor30, chartActualDataFor25, tabId, supplierSpcChartResultSummary, (int)ChartType.xBarR))
                        {
                            CheckMavericLotForEachChart(chartActualDataFor30, chartActualDataFor25, tabId, supplierSpcChartResultSummary, RangeControlXBarR);
                        }
                        break;
                    case (int)ChartType.xBarS:
                        if (!CheckMavericLotForEachChart(chartActualDataFor30, chartActualDataFor25, tabId, supplierSpcChartResultSummary, (int)ChartType.xBarS))
                        {
                            CheckMavericLotForEachChart(chartActualDataFor30, chartActualDataFor25, tabId, supplierSpcChartResultSummary, RangeControlXBarS);
                        }
                        break;
                    case (int)ChartType.IMR:
                        if (!CheckMavericLotForEachChart(chartActualDataFor30, chartActualDataFor25, tabId, supplierSpcChartResultSummary, (int)ChartType.IMR))
                        {
                            CheckMavericLotForEachChart(chartActualDataFor30, chartActualDataFor25, tabId, supplierSpcChartResultSummary, RangeIMR);
                        }
                        break;
                }
            }

            return false;
        }

        private bool CheckMavericLotForEachChart(IEnumerable<SupplierSpcChartModel> chartActualDataFor30, IEnumerable<SupplierSpcChartModel> chartActualDataFor25,
            int tabId, SupplierSpcChartResultSummary supplierSpcChartResultSummary, int chartTypeId)
        {
            double? lcl = 0;
            double? ucl = 0;
            double? average = 0;
            double cpk = 0;
            double? averageFor25 = 0;
            double? standardDeviationFor25 = 0;
            double? averageFor30 = 0;
            double? standardDeviationFor30 = 0;

            var xBarRDataFor30 = chartActualDataFor30.Where(k => k.ChartTypeId == chartTypeId);
            if (xBarRDataFor30.Count() >= 30)
            {
                if (xBarRDataFor30 != null)
                {
                    averageFor30 = CalculateAverage(xBarRDataFor30);
                    standardDeviationFor30 = CalculateStandardDeviation(xBarRDataFor30);
                }
                var xBarRDataFor25 = chartActualDataFor25.Where(k => k.ChartTypeId == chartTypeId);
                if (xBarRDataFor25 != null)
                {
                    averageFor25 = CalculateAverage(xBarRDataFor25);
                    standardDeviationFor25 = CalculateStandardDeviation(xBarRDataFor25);
                    lcl = GetSPCChartCalculationLCL(averageFor25, standardDeviationFor25);
                    ucl = GetSPCChartCalculationUCL(averageFor25, standardDeviationFor25);
                }
                return EvaluateMavericLotRule(xBarRDataFor30, supplierSpcChartResultSummary, tabId, lcl, ucl, average, chartTypeId);
            }

            return false;
        }

        private bool EvaluateMavericLotRule(IEnumerable<SupplierSpcChartModel> SupplierSpcChartData,
            SupplierSpcChartResultSummary supplierSpcChartResultSummary, int tabId, double? lcl, double? ucl, double? average, int chartTypeId)
        {
            var mavericLotDetectedRecord = supplierSpcChartResultSummaries.Where(k => k.MavericLotDetected && k.TabId == tabId);
            if (mavericLotDetectedRecord.Count() == 0)
            {
                SupplierSpcChartData = SupplierSpcChartData.OrderByDescending(k => k.SupplierMeasurementSubmissionId);
                SupplierSpcChartModel recentSMSData = SupplierSpcChartData.FirstOrDefault();
                int index = 0;
                foreach (var item in SupplierSpcChartData)
                {
                    item.Index = index;
                    index++;
                }

                //Rule 1
                CheckOnePointOutOfControlLimitRule(SupplierSpcChartData, supplierSpcChartResultSummary, tabId, lcl, ucl, recentSMSData != null ? recentSMSData.SupplierMeasurementSubmissionId : 0, chartTypeId);
                // Rule 2
                CheckAscendingOrDescendingRule(SupplierSpcChartData, supplierSpcChartResultSummary, tabId, recentSMSData != null ? recentSMSData.SupplierMeasurementSubmissionId : 0, chartTypeId);
                // Rule 3
                CheckAlternateUpAndDownRule(SupplierSpcChartData, supplierSpcChartResultSummary, tabId, recentSMSData != null ? recentSMSData.SupplierMeasurementSubmissionId : 0, chartTypeId);
                // Rule 4
                CheckNinePointsOneSideOfMeanRule(SupplierSpcChartData, supplierSpcChartResultSummary, tabId, average, recentSMSData != null ? recentSMSData.SupplierMeasurementSubmissionId : 0, chartTypeId);
                // Rule 5
                CheckTwoOrThreeUpperOrLowerRule(SupplierSpcChartData, supplierSpcChartResultSummary, tabId, lcl, ucl, recentSMSData != null ? recentSMSData.SupplierMeasurementSubmissionId : 0, chartTypeId);
                // Rule 6
                CheckFourOrFiveConsecutivePointsRule(SupplierSpcChartData, supplierSpcChartResultSummary, tabId, lcl, ucl, recentSMSData != null ? recentSMSData.SupplierMeasurementSubmissionId : 0, chartTypeId);
                // Rule 7
                CheckFifteenPointsBetweenPlusMinusOneSigmaRule(SupplierSpcChartData, supplierSpcChartResultSummary, tabId, lcl, ucl, recentSMSData != null ? recentSMSData.SupplierMeasurementSubmissionId : 0, chartTypeId);
                // Rule 8
                CheckEightPointsOnTwoSigmaZoneRule(SupplierSpcChartData, supplierSpcChartResultSummary, tabId, lcl, ucl, recentSMSData != null ? recentSMSData.SupplierMeasurementSubmissionId : 0, chartTypeId);
            }

            return false;
        }


        #region Rules

        //Rule 1
        private bool CheckOnePointOutOfControlLimitRule(IEnumerable<SupplierSpcChartModel> supplierSpcChartData,
            SupplierSpcChartResultSummary supplierSpcChartResultSummary, int tabId, double? lcl, double? ucl, int recentSMSId, int chartTypeId)
        {
            IEnumerable<SupplierSpcChartModel> supplierSpcChartForCurrentSMS;
            foreach (var item in supplierSpcChartData)
            {
                if (item.FinalTextValue > ucl || item.FinalTextValue < lcl)
                {
                    supplierSpcChartForCurrentSMS = supplierSpcChartData.Where(k => k.Index >= 0 && k.Index <= item.Index).ToList();
                    if (supplierSpcChartForCurrentSMS != null && supplierSpcChartForCurrentSMS.Any(k => k.SupplierMeasurementSubmissionId == recentSMSId))
                    {
                        return SetMavericLotDetection(supplierSpcChartResultSummary, tabId, RuleOne, supplierSpcChartData.Count(), chartTypeId);
                    }
                }

            }
            return false;
        }

        //Rule 2 
        private bool CheckAscendingOrDescendingRule(IEnumerable<SupplierSpcChartModel> supplierSpcChartData,
        SupplierSpcChartResultSummary supplierSpcChartResultSummary, int tabId, int recentSMSId, int chartTypeId)
        {
            double? prevVal = 0;
            int ascendingCount = 1;
            int descendingCount = 1;
            IEnumerable<SupplierSpcChartModel> supplierSpcChartForCurrentSMS;

            foreach (var item in supplierSpcChartData)
            {
                if (prevVal < item.FinalTextValue)
                {
                    ascendingCount++;
                    descendingCount = 1;
                    if (ascendingCount == RuleTwoAscendingOrDescending)
                    {
                        supplierSpcChartForCurrentSMS = supplierSpcChartData.Where(k => k.Index >= (item.Index + 1 - RuleTwoAscendingOrDescending) && k.Index <= item.Index).ToList();
                        if (supplierSpcChartForCurrentSMS != null && supplierSpcChartForCurrentSMS.Any(k => k.SupplierMeasurementSubmissionId == recentSMSId))
                        {
                            return SetMavericLotDetection(supplierSpcChartResultSummary, tabId, RuleTwo, supplierSpcChartData.Count(), chartTypeId);
                        }
                    }
                }
                else if (prevVal > item.FinalTextValue)
                {
                    descendingCount++;
                    ascendingCount = 1;
                    if (descendingCount == RuleTwoAscendingOrDescending)
                    {
                        supplierSpcChartForCurrentSMS = supplierSpcChartData.Where(k => k.Index >= (item.Index + 1 - RuleTwoAscendingOrDescending) && k.Index <= item.Index).ToList();
                        if (supplierSpcChartForCurrentSMS != null && supplierSpcChartForCurrentSMS.Any(k => k.SupplierMeasurementSubmissionId == recentSMSId))
                        {
                            return SetMavericLotDetection(supplierSpcChartResultSummary, tabId, RuleTwo, supplierSpcChartData.Count(), chartTypeId);
                        }
                    }
                }
                else
                {
                    ascendingCount = 1;
                    descendingCount = 1;
                }
                prevVal = item.FinalTextValue;
            }
            return false;
        }

        //Rule 3
        private bool CheckAlternateUpAndDownRule(IEnumerable<SupplierSpcChartModel> supplierSpcChartData,
         SupplierSpcChartResultSummary supplierSpcChartResultSummary, int tabId, int recentSMSId, int chartTypeId)
        {
            IEnumerable<SupplierSpcChartModel> supplierSpcChartForCurrentSMS;
            double? prevVal = 0;
            int count = 0;
            string nextCheck = String.Empty;
            foreach (var item in supplierSpcChartData)
            {
                if (count == 0 && (prevVal < item.FinalTextValue))
                {
                    count++;
                    nextCheck = "UD";
                }
                else if (count == 0 && prevVal > item.FinalTextValue)
                {
                    count++;
                    nextCheck = "DU";
                }

                if (count > 0 && nextCheck == "DU" && prevVal > item.FinalTextValue)
                {
                    count++;
                    nextCheck = "UD";
                }
                else if (count > 0 && nextCheck == "UD" && prevVal < item.FinalTextValue)
                {
                    count++;
                    nextCheck = "DU";
                }
                else
                {
                    count = 0;
                }

                if (count == RuleThreeUpAndDown)
                {
                    supplierSpcChartForCurrentSMS = supplierSpcChartData.Where(k => k.Index >= (item.Index + 1 - RuleThreeUpAndDown) && k.Index <= item.Index).ToList();
                    if (supplierSpcChartForCurrentSMS != null && supplierSpcChartForCurrentSMS.Any(k => k.SupplierMeasurementSubmissionId == recentSMSId))
                    {
                        return SetMavericLotDetection(supplierSpcChartResultSummary, tabId, RuleThree, supplierSpcChartData.Count(), chartTypeId);
                    }
                }
                prevVal = item.FinalTextValue;

            }
            return false;
        }

        //Rule 4
        private bool CheckNinePointsOneSideOfMeanRule(IEnumerable<SupplierSpcChartModel> supplierSpcChartData,
        SupplierSpcChartResultSummary supplierSpcChartResultSummary, int tabId, double? average, int recentSMSId, int chartTypeId)
        {
            IEnumerable<SupplierSpcChartModel> supplierSpcChartForCurrentSMS;
            int downSideCount = 0;
            int upSideCount = 0;
            foreach (var item in supplierSpcChartData)
            {
                if (item.FinalTextValue > average)
                {
                    upSideCount++;
                    downSideCount = 0;
                    if (upSideCount == RuleFourOneSideOfMean)
                    {
                        supplierSpcChartForCurrentSMS = supplierSpcChartData.Where(k => k.Index >= (item.Index + 1 - RuleFourOneSideOfMean) && k.Index <= item.Index).ToList();
                        if (supplierSpcChartForCurrentSMS != null && supplierSpcChartForCurrentSMS.Any(k => k.SupplierMeasurementSubmissionId == recentSMSId))
                        {
                            return SetMavericLotDetection(supplierSpcChartResultSummary, tabId, RuleFour, supplierSpcChartData.Count(), chartTypeId);
                        }
                    }
                }
                else if (item.FinalTextValue < average)
                {
                    downSideCount++;
                    upSideCount = 0;
                    if (downSideCount == RuleFourOneSideOfMean)
                    {
                        supplierSpcChartForCurrentSMS = supplierSpcChartData.Where(k => k.Index >= (item.Index + 1 - RuleFourOneSideOfMean) && k.Index <= item.Index).ToList();
                        if (supplierSpcChartForCurrentSMS != null && supplierSpcChartForCurrentSMS.Any(k => k.SupplierMeasurementSubmissionId == recentSMSId))
                        {
                            return SetMavericLotDetection(supplierSpcChartResultSummary, tabId, RuleFour, supplierSpcChartData.Count(), chartTypeId);
                        }
                    }
                }
                else
                {
                    upSideCount = 0;
                    downSideCount = 0;
                }
            }
            return false;
        }

        // Rule 5
        private bool CheckTwoOrThreeUpperOrLowerRule(IEnumerable<SupplierSpcChartModel> supplierSpcChartData,
            SupplierSpcChartResultSummary supplierSpcChartResultSummary, int tabId, double? lcl, double? ucl, int recentSMSId, int chartTypeId)
        {
            IEnumerable<SupplierSpcChartModel> supplierSpcChartForCurrentSMS;
            double? upperSigmaCommon = ucl - ((ucl - lcl) / 2);
            double? lowerSigmaCommon = (((ucl - ((ucl - lcl) / 2)) - lcl) / 3);
            double? upperTwoSigma = ucl - (((ucl - upperSigmaCommon) / 3) * 1);
            double? lowerTwoSigma = (lowerSigmaCommon * 1) + lcl;
            int upperBandCount = 0;
            int lowerBandCount = 0;
            int intermediateIndexForUB = 0;
            int intermediateIndexForLB = 0;
            int index = 0;
            foreach (var item in supplierSpcChartData)
            {
                if (index <= LastThree)
                {
                    if (item.FinalTextValue > upperTwoSigma)
                    {
                        upperBandCount++;
                        intermediateIndexForUB = index;
                    }
                    else if (item.FinalTextValue < lowerTwoSigma)
                    {
                        lowerBandCount++;
                        intermediateIndexForLB = index;
                    }
                    else if (upperBandCount < RuleFiveUpperOrLower)
                    {
                        upperBandCount = 0;
                    }
                    else if (lowerBandCount < RuleFiveUpperOrLower)
                    {
                        lowerBandCount = 0;
                    }
                    index++;
                }
            }

            if (upperBandCount >= RuleFiveUpperOrLower && upperBandCount <= RuleFiveUpperOrLowerMax)
            {
                supplierSpcChartForCurrentSMS = supplierSpcChartData.Where(k => k.Index >= (intermediateIndexForUB + 1 - upperBandCount) && k.Index <= intermediateIndexForUB).ToList();
                if (supplierSpcChartForCurrentSMS != null && supplierSpcChartForCurrentSMS.Any(k => k.SupplierMeasurementSubmissionId == recentSMSId))
                {
                    return SetMavericLotDetection(supplierSpcChartResultSummary, tabId, RuleFive, supplierSpcChartData.Count(), chartTypeId);
                }
                return false;
            }
            else if (lowerBandCount >= RuleFiveUpperOrLower && lowerBandCount <= RuleFiveUpperOrLowerMax)
            {
                supplierSpcChartForCurrentSMS = supplierSpcChartData.Where(k => k.Index >= (intermediateIndexForUB + 1 - lowerBandCount) && k.Index <= intermediateIndexForLB).ToList();
                if (supplierSpcChartForCurrentSMS != null && supplierSpcChartForCurrentSMS.Any(k => k.SupplierMeasurementSubmissionId == recentSMSId))
                {
                    return SetMavericLotDetection(supplierSpcChartResultSummary, tabId, RuleFive, supplierSpcChartData.Count(), chartTypeId);
                }
                return false;
            }
            else
            {
                return false;
            }

        }

        //Rule 6
        private bool CheckFourOrFiveConsecutivePointsRule(IEnumerable<SupplierSpcChartModel> supplierSpcChartData,
        SupplierSpcChartResultSummary supplierSpcChartResultSummary, int tabId, double? lcl, double? ucl, int recentSMSId, int chartTypeId)
        {
            IEnumerable<SupplierSpcChartModel> supplierSpcChartForCurrentSMS;
            double? upperSigmaCommon = ucl - ((ucl - lcl) / 2);
            double? lowerSigmaCommon = (((ucl - ((ucl - lcl) / 2)) - lcl) / 3);
            double? upperOneSigma = ucl - (((ucl - upperSigmaCommon) / 3) * 2);
            double? lowerOneSigma = (lowerSigmaCommon * 2) + lcl;
            int upperBandCount = 0;
            int lowerBandCount = 0;
            int intermediateIndexForUB = 0;
            int intermediateIndexForLB = 0;
            int index = 0;
            foreach (var item in supplierSpcChartData)
            {
                if (index <= LastFive)
                {
                    if (item.FinalTextValue > upperOneSigma)
                    {
                        upperBandCount++;
                        intermediateIndexForUB = index;
                        lowerBandCount = 0;
                    }
                    else if (item.FinalTextValue < lowerOneSigma)
                    {
                        lowerBandCount++;
                        intermediateIndexForLB = index;
                        upperBandCount = 0;
                    }
                }
            }

            if (upperBandCount >= RuleSixFourOrFiveConsecutivePoint && upperBandCount <= RuleSixFourOrFiveConsecutivePointMax)
            {
                supplierSpcChartForCurrentSMS = supplierSpcChartData.Where(k => k.Index >= (intermediateIndexForUB + 1 - upperBandCount) && k.Index <= upperBandCount).ToList();
                if (supplierSpcChartForCurrentSMS != null && supplierSpcChartForCurrentSMS.Any(k => k.SupplierMeasurementSubmissionId == recentSMSId))
                {
                    return SetMavericLotDetection(supplierSpcChartResultSummary, tabId, RuleSix, supplierSpcChartData.Count(), chartTypeId);
                }
                return false;
            }
            else if (lowerBandCount >= RuleSixFourOrFiveConsecutivePoint && lowerBandCount <= RuleSixFourOrFiveConsecutivePointMax)
            {
                supplierSpcChartForCurrentSMS = supplierSpcChartData.Where(k => k.Index >= (intermediateIndexForUB + 1 - lowerBandCount) && k.Index <= lowerBandCount).ToList();
                if (supplierSpcChartForCurrentSMS != null && supplierSpcChartForCurrentSMS.Any(k => k.SupplierMeasurementSubmissionId == recentSMSId))
                {
                    return SetMavericLotDetection(supplierSpcChartResultSummary, tabId, RuleSix, supplierSpcChartData.Count(), chartTypeId);
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        //Rule 7
        private bool CheckFifteenPointsBetweenPlusMinusOneSigmaRule(IEnumerable<SupplierSpcChartModel> supplierSpcChartData,
        SupplierSpcChartResultSummary supplierSpcChartResultSummary, int tabId, double? lcl, double? ucl, int recentSMSId, int chartTypeId)
        {
            IEnumerable<SupplierSpcChartModel> supplierSpcChartForCurrentSMS;
            double? upperSigmaCommon = ucl - ((ucl - lcl) / 2);
            double? lowerSigmaCommon = (((ucl - ((ucl - lcl) / 2)) - lcl) / 3);
            double? upperOneSigma = ucl - (((ucl - upperSigmaCommon) / 3) * 2);
            double? lowerOneSigma = (lowerSigmaCommon * 2) + lcl;
            int count = 0;
            foreach (var item in supplierSpcChartData)
            {
                if (item.FinalTextValue < upperOneSigma && item.FinalTextValue > lowerOneSigma)
                {
                    count++;

                    if (count == RuleSevenFifteenPoints)
                    {
                        supplierSpcChartForCurrentSMS = supplierSpcChartData.Where(k => k.Index >= (item.Index + 1 - RuleSevenFifteenPoints) && k.Index <= item.Index).ToList();
                        if (supplierSpcChartForCurrentSMS != null && supplierSpcChartForCurrentSMS.Any(k => k.SupplierMeasurementSubmissionId == recentSMSId))
                        {
                            return SetMavericLotDetection(supplierSpcChartResultSummary, tabId, RuleSeven, supplierSpcChartData.Count(), chartTypeId);
                        }
                    }
                }
                else
                {
                    count = 0;
                }
            }
            return false;
        }

        //Rule 8
        private bool CheckEightPointsOnTwoSigmaZoneRule(IEnumerable<SupplierSpcChartModel> supplierSpcChartData,
            SupplierSpcChartResultSummary supplierSpcChartResultSummary, int tabId, double? lcl, double? ucl, int recentSMSId, int chartTypeId)
        {
            IEnumerable<SupplierSpcChartModel> supplierSpcChartForCurrentSMS;
            double? upperSigmaCommon = ucl - ((ucl - lcl) / 2);
            double? lowerSigmaCommon = (((ucl - ((ucl - lcl) / 2)) - lcl) / 3);
            double? upperOneSigma = ucl - (((ucl - upperSigmaCommon) / 3) * 2);
            double? lowerOneSigma = (lowerSigmaCommon * 2) + lcl;
            int count = 0;
            foreach (var item in supplierSpcChartData)
            {
                if (item.FinalTextValue > upperOneSigma && item.FinalTextValue < lowerOneSigma)
                {
                    count++;
                    if (count == RuleEightEightPointsOnTwoSigmaZone)
                    {
                        supplierSpcChartForCurrentSMS = supplierSpcChartData.Where(k => k.Index >= (item.Index + 1 - RuleEightEightPointsOnTwoSigmaZone) && k.Index <= item.Index).ToList();
                        if (supplierSpcChartForCurrentSMS != null && supplierSpcChartForCurrentSMS.Any(k => k.SupplierMeasurementSubmissionId == recentSMSId))
                        {
                            return SetMavericLotDetection(supplierSpcChartResultSummary, tabId, RuleEight, supplierSpcChartData.Count(), chartTypeId);
                        }
                    }
                }
                else
                {
                    count = 0;
                }
            }
            return false;
        }


        private bool SetMavericLotDetection(SupplierSpcChartResultSummary supplierSpcChartResultSummary, int tabId, int? RuleId, int dataCountToDetectMavericLot, int chartTypeId)
        {
            supplierSpcChartResultSummary.RuleId = (int)RuleId;
            supplierSpcChartResultSummary.MavericLotDetected = true;
            supplierSpcChartResultSummary.TabId = tabId;
            supplierSpcChartResultSummary.DataCountToDetectMavericLot = dataCountToDetectMavericLot;
            supplierSpcChartResultSummary.ChartTypeId = chartTypeId;
            supplierSpcChartResultSummaries.Add(supplierSpcChartResultSummary);
            return true;
        }

        private SupplierSpcChartResultSummary SetAllTabPassFailData(SupplierSpcChartResultSummary supplierSpcChartResultSummary, int tabId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            bool isFailPass = supplierFailedQuantityModelList.Any(x => x.IsFail == true && x.FailIndicator == 0 && x.TabId == tabId);
            var failIndicater = supplierFailedQuantityModelList.Where(x => x.FailIndicator == 1 && x.TabId == tabId).Select(y => y.FailIndicator).FirstOrDefault();
            supplierSpcChartResultSummary.MavericLotDetected = false;
            supplierSpcChartResultSummary.TabId = tabId;
            supplierSpcChartResultSummary.TabResult = isFailPass;
            if (supplierFailedQuantityModelList.Count() != 0)
            {
                if (failIndicater == 0 && isFailPass)
                {
                    supplierSpcChartResultSummary.FailIndicator = 0;
                }
                else if (failIndicater == 1 && isFailPass)
                {
                    supplierSpcChartResultSummary.FailIndicator = 0;
                }
                else if (failIndicater == 1 && !isFailPass)
                {
                    supplierSpcChartResultSummary.FailIndicator = 1;
                }
                else
                {
                    supplierSpcChartResultSummary.FailIndicator = 2;
                }
            }
            else
            {
                supplierSpcChartResultSummary.FailIndicator = 2;
            }
            return supplierSpcChartResultSummary;
        }
        #endregion


        /*Comments
        if (cpk<CpkConstant)
        {
            supplierSpcChartResultSummary.MavericLotDetected = true;
            supplierSpcChartResultSummary.TabId = tabId;
            supplierSpcChartResultSummaries.Add(supplierSpcChartResultSummary);
            return;
         } */

    }

}
