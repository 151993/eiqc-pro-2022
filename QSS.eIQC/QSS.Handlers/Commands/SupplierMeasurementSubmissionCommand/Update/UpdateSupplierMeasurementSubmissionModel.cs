/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.AttachmentCommand.Add;
using QSS.eIQC.Handlers.Commands.SMSCommentAttachmentCommand;
using QSS.eIQC.Handlers.Commands.SupplierDateCodeCommand;
using QSS.eIQC.Handlers.Commands.SupplierDimensionMeasurementCommand;
using QSS.eIQC.Handlers.Commands.SupplierFunctionVariableCommand;
using QSS.eIQC.Handlers.Commands.SupplierLPositionCommand;
using QSS.eIQC.Handlers.Commands.SupplierMicrosectionCommand;
using QSS.eIQC.Handlers.Commands.SupplierMPositionCommand;
using QSS.eIQC.Handlers.Commands.SupplierSamplingPlanCommand;
using QSS.eIQC.Handlers.Commands.SupplierTestReportCommand;
using QSS.eIQC.Handlers.Commands.SupplierVisualInspectionCommand;
using System;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.Update
{
    /// <summary>
    /// Representation model for Update SupplierMeasurementSubmission operation
    /// </summary>
    public class UpdateSupplierMeasurementSubmissionModel : BaseUpdateCommand<int>, IRequest<SupplierMeasurementSubmissionModel>
    {
        public string PartNo { get; set; }

        public string Manufacturer { get; set; }

        public string MediaCode { get; set; }

        public string MaskedMPN { get; set; }

        public int? SapBasedResultPassFailId { get; set; }

        public string ManufacturePartNumber { get; set; }

        public int? WorkCellId { get; set; }

        public int? SupplierContactId { get; set; }

        public int? SupplierId { get; set; }

        public string IP { get; set; }

        public int PurchaseOrderId { get; set; }

        public decimal? Quantity { get; set; }

        public string BatchNo { get; set; }

        public decimal? BatchQuantity { get; set; }

        public int InspectorId { get; set; }

        public int SMSPOStateTypeId { get; set; }

        public int SAPPartInspectionPlanId { get; set; }

        public string ResultDescription { get; set; }

        public int PackagingQuantity { get; set; }

        public int ResultId { get; set; }
        public string SMSNo { get; set; }
        public int? SMSSerialNumber { get; set; }

        public List<int> AddedSMSManufacturePartNumberIds { get; set; }

        public List<int> RemovedSMSManufacturePartNumberIds { get; set; }

        public List<int> RemovedSMSCommentAttachmentIds { get; set; }

        //public IEnumerable<SMSCommentAttachmentModel> UploadSMSCommentAttachments { get; set; }

        public IEnumerable<AddAttachmentModel> UploadSMSCommentAttachments { get; set; }

        public string Comments { get; set; }

        public int StateTypeId { get; set; }

        public int? SubmittedByUserId { get; set; }

        public DateTimeOffset SubmittedDate { get; set; }

        public int? ApproveRejectedId { get; set; }

        public DateTimeOffset ApproveRejectedDate { get; set; }

        public IEnumerable<SupplierFunctionAttributeModel> SupplierFunctionAttributes { get; set; }

        public IEnumerable<SupplierMicrosectionModel> SupplierMicrosectionParameters { get; set; }
        public IEnumerable<SupplierDimensionMeasurementModel> SupplierDimensionMeasurements { get; set; }

        public IEnumerable<SupplierFunctionVariableModel> SupplierFunctionVariables { get; set; }

        public virtual IEnumerable<SupplierSamplingPlanModel> SupplierSamplingPlans { get; set; }

        public IEnumerable<SupplierSapBasedParameterModel> SupplierSapBasedParameters { get; set; }

        public virtual IEnumerable<SupplierTestReportModel> SupplierTestReports { get; set; }

        public virtual IEnumerable<SupplierMPositionModel> SupplierMPositions { get; set; }

        public virtual SupplierDateCodeModel SupplierDateCode { get; set; }

        public int? SupplierDateCodeId { get; set; }

        public IEnumerable<SupplierBowTwistModel> SupplierBowTwists { get; set; }
        public virtual IEnumerable<SupplierLPositionModel> SupplierLPositions { get; set; }


        public IEnumerable<SupplierVisualInspectionModel> SupplierVisualInspections { get; set; }
    }
}
