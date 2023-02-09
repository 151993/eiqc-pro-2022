/* Auto Generated Code By AutoCodeGen Jabil © 2019 */

 
using MediatR;
using System.Collections.Generic;
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
using QSS.eIQC.Handlers.Commands.AttachmentCommand.Add;

namespace QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.ApproveReject
{
    /// <summary>
    /// Representation model for Update SupplierMeasurementSubmission operation
    /// </summary>
    public class ApproveRejectSupplierMeasurementSubmissionPlanModel : BaseUpdateCommand<int>, IRequest<SupplierMeasurementSubmissionModel>
    {

        public string PartNo { get; set; }

        public string Manufacturer { get; set; }

        public string MediaCode { get; set; }

        public string MaskedMPN { get; set; }

        public int? SapBasedResultPassFailId { get; set; }

        public string ManufacturePartNumber { get; set; }

        public int? WorkCellId { get; set; }
        //public UserModel SupplierContact { get; set; }
        public int? SupplierContactId { get; set; }
       
        public int? SupplierId { get; set; }
 
        public string SAPPartInspectionPlanId { get; set; }

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

        public int? SupplierDateCodeId { get; set; }

        public int SubmittedByUserId { get; set; }

        public DateTimeOffset SubmittedDate { get; set; }

        public int ApproveRejectedId { get; set; }

        public string Comments { get; set; }

        public int StateTypeId { get; set; }

        public List<int> removedSMSCommentAttachmentIds { get; set; }

        //public IEnumerable<SMSCommentAttachmentModel> UploadSMSCommentAttachments { get; set; }

        public IEnumerable<AddAttachmentModel> UploadSMSCommentAttachments { get; set; }

    }


}
