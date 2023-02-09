/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QSS.eIQC.Api.Helpers.Extensions;
using QSS.eIQC.Api.Helpers.Filters;
using QSS.eIQC.Api.Helpers.Http;
using QSS.eIQC.DataAccess.DataContext;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SupplierFailedQuantityCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QSS.eIQC.Api.Controllers
{
    /// <summary>
    /// SAPPartInspectionPlan Configurations OData controller
    /// </summary>
    [ODataRoutePrefix("SupplierFailedQuantity")]

    public class SupplierFailedQuantityODataController : BaseODataController
    {
        private const string AV = "AV";
        private const int DimensionDefaultForResult = 3;
        private const string Fail = "Fail";
        private const int NG = 2;
        private const int DateCodeTabId = 8;
        private const int TestReportTabId = 11;
        private const int VisualInspectionTabId = 1;
        private const int PackingInspectionTabId = 13;
        private const int SapBasedTabId = 14;




        /// <summary>
        /// Constructor to bootstrap private members
        /// </summary>
        /// <param name="context">Injected instance of IQSSContext on runtime, <see cref="IQSSContext"/></param>
        /// <param name="mapper">Injected instance of IMapper on runtime, <see cref="IMapper"/></param>
        public SupplierFailedQuantityODataController(IQSSContext context,
            IMapper mapper) : base(context, mapper)
        {
        }


        [HttpGet]
        [EnableQueryFromODataToAWS]
        [ODataRoute("GetFailedQuantityDataForSupplier(SMSId={SMSId})")]
        public async Task<IEnumerable<SupplierFailedQuantityModel>> GetFailedQuantityDataForSupplier([FromODataUri] int SMSId, ODataQueryOptions oDataQueryOptions)
        {
            List<SupplierFailedQuantityModel> supplierFailedQuantityModelList = new List<SupplierFailedQuantityModel>();

            UpdateFailedQuantityForDIM(SMSId, supplierFailedQuantityModelList);

            UpdateFailedQuantityForFUN(SMSId, supplierFailedQuantityModelList);

            UpdateFailedQuantityForVIS(SMSId, supplierFailedQuantityModelList);

            return supplierFailedQuantityModelList.ToList();

        }

        private void UpdateFailedQuantityForVIS(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            UpdateFailedQuantityForSAPBased(SMSId, supplierFailedQuantityModelList);

            UpdateFailedQuantityForPackingInspection(SMSId, supplierFailedQuantityModelList);

            UpdateFailedQuantityForTestReport(SMSId, supplierFailedQuantityModelList);

            UpdateFailedQuantityForVisualInspection(SMSId, supplierFailedQuantityModelList);

            UpdateFailedQuantityForDateCode(SMSId, supplierFailedQuantityModelList);
        }

        private void UpdateFailedQuantityForFUN(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            UpdateFailedQuantityForFunctionAttribute(SMSId, supplierFailedQuantityModelList);

            UpdateFailedQuantityForFunctionVariable(SMSId, supplierFailedQuantityModelList);
        }

        public void UpdateFailedQuantityForDIM(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            UpdateFailedQuantityForDimensionalMeasurement(SMSId, supplierFailedQuantityModelList);

            UpdateFailedQuantityForMicroSection(SMSId, supplierFailedQuantityModelList);

            UpdateFailedQuantityForBowTwist(SMSId, supplierFailedQuantityModelList);

            UpdateFailedQuantityForMPosition(SMSId, supplierFailedQuantityModelList);

            UpdateFailedQuantityForLPosition(SMSId, supplierFailedQuantityModelList);
        }

        public void UpdateFailedQuantityForDimensionalMeasurement(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            var supplierDimensionMeasurement = Context.SupplierDimensionMeasurement.Where(k => k.SupplierMeasurementSubmissionId == SMSId).ToList();

            foreach (var item in supplierDimensionMeasurement)
            {
                var supplierMeasurementActual = Context.SupplierDimensionMeasurementActual.Where(k => k.SupplierDimensionMeasurementId == item.Id);
                foreach (var itemActual in supplierMeasurementActual)
                {
                    SupplierFailedQuantityModel supplierFailedQuantityModel = new SupplierFailedQuantityModel();
                    supplierFailedQuantityModel.MasterInspectionTypeId = Convert.ToInt16(MasterInspectionType.DIM);
                    supplierFailedQuantityModel.TabId = Convert.ToInt16(ParameterManagementType.DimensionalMeasurements);
                    if (itemActual.ActualTextValue.Trim() != String.Empty && (Convert.ToDouble(itemActual.ActualTextValue) > item.UpperTolerance || Convert.ToDouble(itemActual.ActualTextValue) < item.LowerTolerance))
                    {
                        supplierFailedQuantityModel.IsFail = true;
                        supplierFailedQuantityModel.FailIndicator = 0;
                        UpdateSupplierFailedQuantityForDIM(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 1);


                    }
                    else if (itemActual.ActualTextValue.Trim() == String.Empty)
                    {
                        //empty
                        supplierFailedQuantityModel.FailIndicator = 2;
                        UpdateSupplierFailedQuantityForDIM(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 0);

                    }
                    else
                    {
                        supplierFailedQuantityModel.IsFail = false;
                        supplierFailedQuantityModel.FailIndicator = 1;
                        UpdateSupplierFailedQuantityForDIM(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 0);


                    }

                }
            }
        }

        public void UpdateFailedQuantityForMicroSection(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            var supplierMicrosection = Context.SupplierMicrosection.Where(k => k.SupplierMeasurementSubmissionId == SMSId).ToList();

            foreach (var item in supplierMicrosection)
            {
                var supplierMicroSectionActual = Context.SupplierMicroSectionActual.Where(k => k.SupplierMicrosectionId == item.Id);
                foreach (var itemActual in supplierMicroSectionActual)
                {
                    SupplierFailedQuantityModel supplierFailedQuantityModel = new SupplierFailedQuantityModel();
                    supplierFailedQuantityModel.MasterInspectionTypeId = Convert.ToInt16(MasterInspectionType.DIM);
                    supplierFailedQuantityModel.TabId = Convert.ToInt16(ParameterManagementType.MicroSection);

                    if (itemActual.ActualTextValue.Trim() != String.Empty && (Convert.ToDouble(itemActual.ActualTextValue) > item.UpperTolerance || Convert.ToDouble(itemActual.ActualTextValue) < item.LowerTolerance))
                    {
                        supplierFailedQuantityModel.IsFail = true;
                        supplierFailedQuantityModel.FailIndicator = 0;
                        UpdateSupplierFailedQuantityForDIM(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 1);

                    }
                    else if (itemActual.ActualTextValue.Trim() == String.Empty)
                    {
                        //empty
                        supplierFailedQuantityModel.FailIndicator = 2;
                        UpdateSupplierFailedQuantityForDIM(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 0);
                    }
                    else
                    {
                        supplierFailedQuantityModel.IsFail = false;
                        supplierFailedQuantityModel.FailIndicator = 1;
                        UpdateSupplierFailedQuantityForDIM(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 0);


                    }

                }
            }
        }

        public void UpdateFailedQuantityForBowTwist(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            var supplierBowTwist = Context.SupplierBowTwist.Where(k => k.SupplierMeasurementSubmissionId == SMSId).ToList();

            foreach (var item in supplierBowTwist)
            {
                var supplierBowTwistActual = Context.SupplierBowTwistActual.Where(k => k.SupplierBowTwistId == item.Id).ToList();
                foreach (var itemActual in supplierBowTwistActual)
                {
                    SupplierFailedQuantityModel supplierFailedQuantityModel = new SupplierFailedQuantityModel();
                    supplierFailedQuantityModel.MasterInspectionTypeId = Convert.ToInt16(MasterInspectionType.DIM);
                    supplierFailedQuantityModel.TabId = Convert.ToInt16(ParameterManagementType.BowAndTwist);
                    var partInspectionBowTwistParameter = Context.PartInspectionBowTwistParameter.Where(k => k.Id == item.PartBowTwistParameterId).FirstOrDefault();
                    if (itemActual.ActualTextValue.Trim() != String.Empty && partInspectionBowTwistParameter != null &&
                        (Convert.ToDecimal(itemActual.ActualTextValue) > partInspectionBowTwistParameter.UpperLimit))
                    {
                        supplierFailedQuantityModel.IsFail = true;
                        supplierFailedQuantityModel.FailIndicator = 0;

                        UpdateSupplierFailedQuantityForDIM(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 1);


                    }
                    else if (itemActual.ActualTextValue.Trim() == String.Empty)
                    {
                        //empty
                        supplierFailedQuantityModel.FailIndicator = 2;
                    }
                    else
                    {
                        supplierFailedQuantityModel.FailIndicator = 1;
                        supplierFailedQuantityModel.IsFail = false;
                        UpdateSupplierFailedQuantityForDIM(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 0);

                    }

                }
            }
        }

        public void UpdateFailedQuantityForMPosition(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            var supplierMPosition = Context.SupplierMPosition.Where(k => k.SupplierMeasurementSubmissionId == SMSId && k.DimensionDefaultId == DimensionDefaultForResult).ToList();

            foreach (var item in supplierMPosition)
            {
                var supplierMPositionActual = Context.SupplierMPositionActual.Where(k => k.SupplierMPositionId == item.Id);
                foreach (var itemActual in supplierMPositionActual)
                {
                    SupplierFailedQuantityModel supplierFailedQuantityModel = new SupplierFailedQuantityModel();
                    supplierFailedQuantityModel.MasterInspectionTypeId = Convert.ToInt16(MasterInspectionType.DIM);
                    supplierFailedQuantityModel.TabId = Convert.ToInt16(ParameterManagementType.SpecWithMMC);
                    if (itemActual.ActualText.Trim() != String.Empty && itemActual.ActualValue == Fail)
                    {
                        supplierFailedQuantityModel.IsFail = true;
                        supplierFailedQuantityModel.FailIndicator = 0;
                        UpdateSupplierFailedQuantityForDIM(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 1);

                    }
                    else if (itemActual.ActualText.Trim() == String.Empty)
                    {
                        //empty
                        supplierFailedQuantityModel.FailIndicator = 2;
                        supplierFailedQuantityModel.FailedQuantityCount = 0;
                    }
                    else
                    {
                        supplierFailedQuantityModel.FailIndicator = 1;
                        supplierFailedQuantityModel.FailedQuantityCount = 0;
                        supplierFailedQuantityModel.IsFail = false;
                        UpdateSupplierFailedQuantityForDIM(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 0);

                    }

                }
            }
        }

        public void UpdateFailedQuantityForLPosition(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            var supplierLPosition = Context.SupplierLPosition.Where(k => k.SupplierMeasurementSubmissionId == SMSId && k.DimensionDefaultId == DimensionDefaultForResult).ToList();

            foreach (var item in supplierLPosition)
            {
                var supplierLPositionActual = Context.SupplierLPositionActual.Where(k => k.SupplierLPositionId == item.Id);
                foreach (var itemActual in supplierLPositionActual)
                {
                    SupplierFailedQuantityModel supplierFailedQuantityModel = new SupplierFailedQuantityModel();
                    supplierFailedQuantityModel.MasterInspectionTypeId = Convert.ToInt16(MasterInspectionType.DIM);
                    supplierFailedQuantityModel.TabId = Convert.ToInt16(ParameterManagementType.SpecWithLMC);
                    if (itemActual.ActualText.Trim() != String.Empty && itemActual.ActualValue == Fail)
                    {
                        supplierFailedQuantityModel.IsFail = true;
                        supplierFailedQuantityModel.FailIndicator = 0;
                        UpdateSupplierFailedQuantityForDIM(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 1);

                    }
                    else if (itemActual.ActualText.Trim() == String.Empty)
                    {
                        //empty
                        supplierFailedQuantityModel.FailIndicator = 2;
                        supplierFailedQuantityModel.FailedQuantityCount = 0;
                    }
                    else
                    {
                        supplierFailedQuantityModel.FailIndicator = 1;
                        supplierFailedQuantityModel.IsFail = false;
                        UpdateSupplierFailedQuantityForDIM(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 0);

                    }

                }
            }
        }


        public void UpdateFailedQuantityForFunctionAttribute(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            var supplierFunctionAttribute = Context.SupplierFunctionAttribute.Where(k => k.SupplierMeasurementSubmissionId == SMSId).ToList();

            foreach (var item in supplierFunctionAttribute)
            {
                var supplierFunctionAttributeActual = Context.SupplierFunctionAttributeActual.Where(k => k.SupplierFunctionAttributeId == item.Id);
                foreach (var itemActual in supplierFunctionAttributeActual)
                {
                    SupplierFailedQuantityModel supplierFailedQuantityModel = new SupplierFailedQuantityModel();
                    supplierFailedQuantityModel.MasterInspectionTypeId = Convert.ToInt16(MasterInspectionType.FUN);
                    supplierFailedQuantityModel.TabId = Convert.ToInt16(ParameterManagementType.FunctionAttribute);


                    if (itemActual.ActualTextValue.Trim() != String.Empty && (Convert.ToInt32(itemActual.ActualTextValue) == NG))
                    {
                        supplierFailedQuantityModel.FailIndicator = 0;
                        supplierFailedQuantityModel.IsFail = true;
                        UpdateSupplierFailedQuantityForFUN(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 1);
                    }
                    else if (itemActual.ActualTextValue.Trim() == String.Empty)
                    {
                        //empty
                        supplierFailedQuantityModel.FailIndicator = 2;
                    }
                    else
                    {
                        supplierFailedQuantityModel.FailIndicator = 1;
                        supplierFailedQuantityModel.IsFail = false;
                        UpdateSupplierFailedQuantityForFUN(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 0);

                    }

                }
            }
        }

        public void UpdateFailedQuantityForFunctionVariable(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            var supplierFunctionVariable = Context.SupplierFunctionVariable.Where(k => k.SupplierMeasurementSubmissionId == SMSId).ToList();

            foreach (var item in supplierFunctionVariable)
            {
                var supplierFunctionVariableActual = Context.SupplierFunctionVariableActual.Where(k => k.SupplierFunctionVariableId == item.Id);
                foreach (var itemActual in supplierFunctionVariableActual)
                {
                    SupplierFailedQuantityModel supplierFailedQuantityModel = new SupplierFailedQuantityModel();
                    supplierFailedQuantityModel.MasterInspectionTypeId = Convert.ToInt16(MasterInspectionType.FUN);
                    supplierFailedQuantityModel.TabId = Convert.ToInt16(ParameterManagementType.FunctionVariable);

                    if (itemActual.ActualTextValue.Trim() != String.Empty && (Convert.ToDouble(itemActual.ActualTextValue) > item.UpperTolerance || Convert.ToDouble(itemActual.ActualTextValue) < item.LowerTolerance))
                    {
                        supplierFailedQuantityModel.FailIndicator = 0;
                        supplierFailedQuantityModel.IsFail = true;
                        UpdateSupplierFailedQuantityForFUN(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 1);

                    }
                    else if (itemActual.ActualTextValue.Trim() == String.Empty)
                    {
                        //empty
                        supplierFailedQuantityModel.FailIndicator = 2;
                        UpdateSupplierFailedQuantityForFUN(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 0);
                    }
                    else
                    {
                        supplierFailedQuantityModel.IsFail = false;
                        supplierFailedQuantityModel.FailIndicator = 1;
                        UpdateSupplierFailedQuantityForFUN(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual, 0);

                    }

                }
            }
        }

        public void UpdateFailedQuantityForDateCode(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            var sms = Context.SupplierMeasurementSubmission.Where(k => k.Id == SMSId).FirstOrDefault();
            var supplierDateCode = Context.SupplierDateCode.Where(k => k.Id == sms.SupplierDateCodeId).FirstOrDefault();

            SupplierFailedQuantityModel supplierFailedQuantityModel = new SupplierFailedQuantityModel();
            supplierFailedQuantityModel.MasterInspectionTypeId = Convert.ToInt16(MasterInspectionType.VIS);
            supplierFailedQuantityModel.TabId = DateCodeTabId;
            if (supplierDateCode != null)
            {
                supplierFailedQuantityModel.IsFail = supplierDateCode.AcceptRejectId == NG ? true : false;
                supplierFailedQuantityModel.FailedQuantityCount = supplierDateCode.AcceptRejectId == NG ? 1 : 0;
                supplierFailedQuantityModel.FailIndicator = supplierDateCode.AcceptRejectId == NG ? 0 : 1;

            }
            supplierFailedQuantityModelList.Add(supplierFailedQuantityModel);
        }

        public void UpdateFailedQuantityForVisualInspection(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            int count = Context.SupplierVisualInspection.Where(k => k.SupplierMeasurementSubmissionId == SMSId).Count();
            var supplierVisualInspection = Context.SupplierVisualInspection.Where(k => k.SupplierMeasurementSubmissionId == SMSId).Sum(l => l.TotalDefectQty);
            var supplierVIData = Context.SupplierVisualInspection.Where(k => k.SupplierMeasurementSubmissionId == SMSId && k.ResultPassFailId == 2).ToList();
            SupplierFailedQuantityModel supplierFailedQuantityModel = new SupplierFailedQuantityModel();
            supplierFailedQuantityModel.MasterInspectionTypeId = Convert.ToInt16(MasterInspectionType.VIS);
            supplierFailedQuantityModel.TabId = VisualInspectionTabId;
            if (count == 0)
            {
                supplierFailedQuantityModel.FailedQuantityCount = (int)supplierVisualInspection;
                supplierFailedQuantityModel.IsFail = supplierVIData != null && supplierVIData.Count() > 0 ? true : false;
                supplierFailedQuantityModel.FailIndicator = 2;
            }
            else if ((int)supplierVisualInspection == 0)
            {
                supplierFailedQuantityModel.FailedQuantityCount = (int)supplierVisualInspection;
                supplierFailedQuantityModel.IsFail = supplierVIData != null && supplierVIData.Count() > 0 ? true : false;
                supplierFailedQuantityModel.FailIndicator = 1;
            }
            else
            {
                supplierFailedQuantityModel.FailedQuantityCount = (int)supplierVisualInspection;
                supplierFailedQuantityModel.IsFail = supplierVIData != null && supplierVIData.Count() > 0 ? true : false;
                supplierFailedQuantityModel.FailIndicator = supplierVIData != null && supplierVIData.Count() > 0 ? 0 : 1;
            }
            supplierFailedQuantityModelList.Add(supplierFailedQuantityModel);
        }

        public void UpdateFailedQuantityForTestReport(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            var supplierTestReport = Context.SupplierTestReport.Where(k => k.SupplierMeasurementSubmissionId == SMSId && k.ResultId == NG).ToList();
            SupplierFailedQuantityModel supplierFailedQuantityModel = new SupplierFailedQuantityModel();
            supplierFailedQuantityModel.MasterInspectionTypeId = Convert.ToInt16(MasterInspectionType.VIS);
            supplierFailedQuantityModel.TabId = TestReportTabId;
            if (supplierTestReport.Count() > 0)
            {
                supplierFailedQuantityModel.FailedQuantityCount = 1;
                supplierFailedQuantityModel.IsFail = true;
                // false = fail
                supplierFailedQuantityModel.FailIndicator = 0;
            }
            else if (Context.SupplierTestReport.Where(k => k.SupplierMeasurementSubmissionId == SMSId).Count() <= 0)
            {
                //empty
                supplierFailedQuantityModel.FailIndicator = 2;
                supplierFailedQuantityModel.FailedQuantityCount = 1;
            }
            else
            {
                supplierFailedQuantityModel.FailedQuantityCount = 1;
                supplierFailedQuantityModel.IsFail = false;
                // true = pass
                supplierFailedQuantityModel.FailIndicator = 1;
            }
            supplierFailedQuantityModelList.Add(supplierFailedQuantityModel);
        }

        public void UpdateFailedQuantityForPackingInspection(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            var packingInspectionResult = Context.SupplierMeasurementSubmission.Where(k => k.Id == SMSId && k.ResultId == NG).ToList();
            SupplierFailedQuantityModel supplierFailedQuantityModel = new SupplierFailedQuantityModel();
            supplierFailedQuantityModel.MasterInspectionTypeId = Convert.ToInt16(MasterInspectionType.VIS);
            supplierFailedQuantityModel.TabId = PackingInspectionTabId;
            if (packingInspectionResult.Count() > 0)
            {
                supplierFailedQuantityModel.FailedQuantityCount = 1;
                supplierFailedQuantityModel.IsFail = true;
                supplierFailedQuantityModel.FailIndicator = 0;
            }
            else if (Context.SupplierMeasurementSubmission.Where(k => k.Id == SMSId && k.ResultId == NG).Count() <= 0)
            {
                //empty
                supplierFailedQuantityModel.FailIndicator = 2;
                supplierFailedQuantityModel.FailedQuantityCount = 1;
            }
            else
            {
                supplierFailedQuantityModel.FailIndicator = 1;
                supplierFailedQuantityModel.FailedQuantityCount = 1;
                supplierFailedQuantityModel.IsFail = false;
            }
            supplierFailedQuantityModelList.Add(supplierFailedQuantityModel);
        }

        public void UpdateFailedQuantityForSAPBased(int SMSId, List<SupplierFailedQuantityModel> supplierFailedQuantityModelList)
        {
            var supplierSapBasedParameter = Context.SupplierSapBasedParameter.Where(k => k.SupplierMeasurementSubmissionId == SMSId && k.MatchId == 0).ToList();
            SupplierFailedQuantityModel supplierFailedQuantityModel = new SupplierFailedQuantityModel();
            supplierFailedQuantityModel.MasterInspectionTypeId = Convert.ToInt16(MasterInspectionType.VIS);
            supplierFailedQuantityModel.TabId = SapBasedTabId;
            if (supplierSapBasedParameter.Count() > 0)
            {
                supplierFailedQuantityModel.FailedQuantityCount = 1;
                supplierFailedQuantityModel.IsFail = true;
                supplierFailedQuantityModel.FailIndicator = 0;
            }
            else if (Context.SupplierSapBasedParameter.Where(k => k.SupplierMeasurementSubmissionId == SMSId).Count() <= 0)
            {
                //empty
                supplierFailedQuantityModel.FailIndicator = 2;
                supplierFailedQuantityModel.FailedQuantityCount = 1;
            }
            else
            {
                supplierFailedQuantityModel.FailIndicator = 1;
                supplierFailedQuantityModel.FailedQuantityCount = 1;
                supplierFailedQuantityModel.IsFail = false;
            }
            supplierFailedQuantityModelList.Add(supplierFailedQuantityModel);
        }

        private static void UpdateSupplierFailedQuantityForDIM(List<SupplierFailedQuantityModel> supplierFailedQuantityModelList,
            SupplierFailedQuantityModel supplierFailedQuantityModel, SupplierDimensionMeasurementActual itemActual, int FailedQuantity)
        {
            string generalActualValue = string.Concat(AV, Regex.Match(itemActual.ActualTextName, @"\d+").Value);
            var existingElement = supplierFailedQuantityModelList.Where(k => k.FieldName == generalActualValue &&
            k.MasterInspectionTypeId == Convert.ToInt16(MasterInspectionType.DIM) && k.TabId == Convert.ToInt16(ParameterManagementType.DimensionalMeasurements)).FirstOrDefault();
            UpdateFailedQuantityList(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual.ActualTextName, FailedQuantity, existingElement);
        }

        private static void UpdateSupplierFailedQuantityForDIM(List<SupplierFailedQuantityModel> supplierFailedQuantityModelList,
           SupplierFailedQuantityModel supplierFailedQuantityModel, SupplierMicroSectionActual itemActual, int FailedQuantity)
        {
            string generalActualValue = string.Concat(AV, Regex.Match(itemActual.ActualTextName, @"\d+").Value);
            var existingElement = supplierFailedQuantityModelList.Where(k => k.FieldName == generalActualValue
            && k.MasterInspectionTypeId == Convert.ToInt16(MasterInspectionType.DIM) && k.TabId == Convert.ToInt16(ParameterManagementType.MicroSection)).FirstOrDefault();
            UpdateFailedQuantityList(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual.ActualTextName, FailedQuantity, existingElement);
        }

        private static void UpdateSupplierFailedQuantityForDIM(List<SupplierFailedQuantityModel> supplierFailedQuantityModelList,
          SupplierFailedQuantityModel supplierFailedQuantityModel, SupplierBowTwistActual itemActual, int FailedQuantity)
        {
            string generalActualValue = string.Concat(AV, Regex.Match(itemActual.ActualTextName, @"\d+").Value);
            var existingElement = supplierFailedQuantityModelList.Where(k => k.FieldName == generalActualValue
            && k.MasterInspectionTypeId == Convert.ToInt16(MasterInspectionType.DIM) && k.TabId == Convert.ToInt16(ParameterManagementType.BowAndTwist)).FirstOrDefault();
            UpdateFailedQuantityList(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual.ActualTextName, FailedQuantity, existingElement);
        }

        private static void UpdateSupplierFailedQuantityForDIM(List<SupplierFailedQuantityModel> supplierFailedQuantityModelList,
         SupplierFailedQuantityModel supplierFailedQuantityModel, SupplierMPositionActual itemActual, int FailedQuantity)
        {
            string generalActualValue = string.Concat(AV, Regex.Match(itemActual.ActualText, @"\d+").Value);
            var existingElement = supplierFailedQuantityModelList.Where(k => k.FieldName == generalActualValue
            && k.MasterInspectionTypeId == Convert.ToInt16(MasterInspectionType.DIM) && k.TabId == Convert.ToInt16(ParameterManagementType.SpecWithMMC)).FirstOrDefault();
            UpdateFailedQuantityList(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual.ActualText, FailedQuantity, existingElement);
        }

        private static void UpdateSupplierFailedQuantityForDIM(List<SupplierFailedQuantityModel> supplierFailedQuantityModelList,
        SupplierFailedQuantityModel supplierFailedQuantityModel, SupplierLPositionActual itemActual, int FailedQuantity)
        {
            string generalActualValue = string.Concat(AV, Regex.Match(itemActual.ActualText, @"\d+").Value);
            var existingElement = supplierFailedQuantityModelList.Where(k => k.FieldName == generalActualValue
            && k.MasterInspectionTypeId == Convert.ToInt16(MasterInspectionType.DIM) && k.TabId == Convert.ToInt16(ParameterManagementType.SpecWithLMC)).FirstOrDefault();
            UpdateFailedQuantityList(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual.ActualText, FailedQuantity, existingElement);
        }

        private static void UpdateSupplierFailedQuantityForFUN(List<SupplierFailedQuantityModel> supplierFailedQuantityModelList,
        SupplierFailedQuantityModel supplierFailedQuantityModel, SupplierFunctionAttributeActual itemActual, int FailedQuantity)
        {
            string generalActualValue = string.Concat(AV, Regex.Match(itemActual.ActualTextName, @"\d+").Value);
            var existingElement = supplierFailedQuantityModelList.Where(k => k.FieldName == generalActualValue
            && k.MasterInspectionTypeId == Convert.ToInt16(MasterInspectionType.FUN) && k.TabId == Convert.ToInt16(ParameterManagementType.FunctionAttribute)).FirstOrDefault();
            UpdateFailedQuantityList(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual.ActualTextName, FailedQuantity, existingElement);
        }

        private static void UpdateSupplierFailedQuantityForFUN(List<SupplierFailedQuantityModel> supplierFailedQuantityModelList,
        SupplierFailedQuantityModel supplierFailedQuantityModel, SupplierFunctionVariableActual itemActual, int FailedQuantity)
        {
            string generalActualValue = string.Concat(AV, Regex.Match(itemActual.ActualTextName, @"\d+").Value);
            var existingElement = supplierFailedQuantityModelList.Where(k => k.FieldName == generalActualValue
            && k.MasterInspectionTypeId == Convert.ToInt16(MasterInspectionType.FUN) && k.TabId == Convert.ToInt16(ParameterManagementType.FunctionVariable)).FirstOrDefault();
            UpdateFailedQuantityList(supplierFailedQuantityModelList, supplierFailedQuantityModel, itemActual.ActualTextName, FailedQuantity, existingElement);
        }

        private static void UpdateFailedQuantityList(List<SupplierFailedQuantityModel> supplierFailedQuantityModelList,
        SupplierFailedQuantityModel supplierFailedQuantityModel, string ActualTextName, int FailedQuantity, SupplierFailedQuantityModel existingElement)
        {
            if (existingElement != null )
            {
                if (existingElement.FailedQuantityCount == 1 || FailedQuantity == 1)
                {
                    existingElement.FailedQuantityCount = 1;
                    supplierFailedQuantityModel.IsFail = true;
                    supplierFailedQuantityModel.FailIndicator = 0;
                    existingElement.FailIndicator = 0;
                    existingElement.IsFail = true;
                }
                 else
                {
                    existingElement.FailedQuantityCount = 0;
                    existingElement.FailIndicator = 1;
                    existingElement.IsFail = false;
                }
            }
            else
            {
                if (supplierFailedQuantityModel.IsFail == true)
                {
                    supplierFailedQuantityModel.IsFail = supplierFailedQuantityModel.IsFail;
                    supplierFailedQuantityModel.FailIndicator = supplierFailedQuantityModel.FailIndicator;
                    supplierFailedQuantityModel.FieldName = string.Concat(AV, Regex.Match(ActualTextName, @"\d+").Value);
                    supplierFailedQuantityModel.FailedQuantityCount = FailedQuantity;
                    supplierFailedQuantityModelList.Add(supplierFailedQuantityModel);
                } else if (supplierFailedQuantityModel.FailIndicator == 2)
                {
                    supplierFailedQuantityModel.IsFail = supplierFailedQuantityModel.IsFail;
                    supplierFailedQuantityModel.FailIndicator = supplierFailedQuantityModel.FailIndicator;
                    supplierFailedQuantityModel.FieldName = string.Concat(AV, Regex.Match(ActualTextName, @"\d+").Value);
                    supplierFailedQuantityModel.FailedQuantityCount = FailedQuantity;
                    supplierFailedQuantityModelList.Add(supplierFailedQuantityModel);
                }
                else
                {
                    supplierFailedQuantityModel.IsFail = false;
                    supplierFailedQuantityModel.FailIndicator = 1;
                    supplierFailedQuantityModel.FieldName = string.Concat(AV, Regex.Match(ActualTextName, @"\d+").Value);
                    supplierFailedQuantityModel.FailedQuantityCount = FailedQuantity;
                    supplierFailedQuantityModelList.Add(supplierFailedQuantityModel);
                }

            }
        }

    }
}
