/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.WorkCellCommand;
using QSS.eIQC.Handlers.Commands.SupplierCommand;
using QSS.eIQC.Handlers.Commands.PurchaseOrderCommand;
using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Handlers.Commands.UserCommand;
using QSS.eIQC.Handlers.Commands.CommodityCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand;
using QSS.eIQC.Handlers.Commands.SupplierMicrosectionCommand;
using QSS.eIQC.Handlers.Commands.SupplierSamplingPlanCommand;
using QSS.eIQC.Handlers.Commands.SupplierFunctionVariableCommand;
using QSS.eIQC.Handlers.Commands.SupplierDimensionMeasurementCommand;
using QSS.eIQC.Handlers.Commands.SupplierTestReportCommand;
using QSS.eIQC.Handlers.Commands.SupplierDateCodeCommand;
using QSS.eIQC.Handlers.Commands.SupplierMPositionCommand;
using QSS.eIQC.Handlers.Commands.SupplierLPositionCommand;
using QSS.eIQC.Handlers.Commands.SupplierVisualInspectionCommand;
using System;
using EnumModel = QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Handlers.Commands.SMSCommentAttachmentCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand
{
    /// <summary>
    /// Representation model for SupplierMeasurementSubmission entity
    /// </summary>
    public class SupplierMeasurementSubmissionModel : BaseStausModel<int>
    {

        public string PartNo { get; set; }

        public string Manufacturer { get; set; }

        public string MediaCode { get; set; }

        public string MaskedMPN { get; set; }

        public int? SapBasedResultPassFailId { get; set; }

        public string ManufacturePartNumber { get; set; }

        public int? WorkCellId { get; set; }
        public UserModel SupplierContact { get; set; }
        public int? SupplierContactId { get; set; }
        public WorkCellModel WorkCell { get; set; }
        public SupplierModel Supplier { get; set; }
        public int? SupplierId { get; set; }

        public PurchaseOrderModel PurchaseOrder { get; set; }

        public string SAPPartInspectionPlanId { get; set; }

        public virtual IEnumerable<SupplierMicrosectionModel> SupplierMicroSectionParameters { get; set; }
        public virtual IEnumerable<SupplierDimensionMeasurementModel> SupplierDimensionMeasurements { get; set; }
        public virtual IEnumerable<SupplierFunctionVariableModel> SupplierFunctionVariables { get; set; }

        public virtual IEnumerable<SupplierFunctionAttributeModel> SupplierFunctionAttributes { get; set; }

        public virtual IEnumerable<SupplierSamplingPlanModel> SupplierSamplingPlans { get; set; }

        public virtual IEnumerable<SupplierSapBasedParameterModel> SupplierSapBasedParameters { get; set; }

        public virtual IEnumerable<SupplierTestReportModel> SupplierTestReports{ get; set; }

        public virtual IEnumerable<SupplierBowTwistModel> SupplierBowTwists { get; set; }

        public virtual IEnumerable<SupplierMPositionModel> SupplierMPositions { get; set; }
        public virtual IEnumerable<SupplierLPositionModel> SupplierLPositions { get; set; }

        public virtual IEnumerable<SupplierVisualInspectionModel> SupplierVisualInspections { get; set; }

        public virtual IEnumerable<SMSCommentAttachmentModel> SMSCommentAttachments { get; set; }

        public string ip { get; set; }

        public int PurchaseOrderId { get; set; }

        public decimal? Quantity { get; set; }

        public string BatchNo { get; set; }

        public decimal? BatchQuantity { get; set; }

        public int InspectorId { get; set; }

        public int SMSPOStateTypeId { get; set; }

        public string ResultDescription { get; set; }

        public int PackagingQuantity { get; set; }

        public int ResultId { get; set; }

        public string SMSNo { get; set; }

        public int? SMSSerialNumber { get; set; }

        public string InspectorName { get; set; }

        public string WorkCellName { get; set; }

        public string SupplierName { get; set; }

        public string PurchaseOrderNumber { get; set; }

        public virtual SMSPOStateTypeModel SMSPOStateType { get; set; }

        public virtual JabilUserModel Inspector { get; set; }

        public virtual SAPPartInspectionPlanModel SAPPartInspectionPlan { get; set; }

        public int? SupplierDateCodeId { get; set; }

        public virtual SupplierDateCodeModel SupplierDateCode { get; set; }

        
        public int SubmittedByUserId { get; set; }

        public DateTimeOffset SubmittedDate { get; set; }

        public int ApproveRejectedId { get; set; }

        public virtual EnumModel.StateTypeModel StateType { get; set; }

        public string Comments { get; set; }

        public int StateTypeId { get; set; }
        public virtual JabilUserModel SubmittedBy { get; set; }

        public virtual JabilUserModel ApproveRejected { get; set; }
    }
}
