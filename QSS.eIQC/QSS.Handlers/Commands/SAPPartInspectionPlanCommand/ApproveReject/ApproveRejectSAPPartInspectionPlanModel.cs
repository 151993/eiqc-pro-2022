/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand;
using System;
using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanSamplingPlanCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommentCommand;

namespace QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.ApproveReject
{
    /// <summary>
    /// Representation model for Update SAPPartInspectionPlan operation
    /// </summary>
    public class ApproveRejectSAPPartInspectionPlanModel : BaseUpdateCommand<int>, IRequest<SAPPartInspectionPlanModel>
    {
        public string PartNo { get; set; }

        public string PartDescription { get; set; }

        public string IP { get; set; }

        public bool IsSafePart { get; set; }

        public int? WorkCellId { get; set; }

        public string DivisionModelNumber { get; set; }

        public string GenWI { get; set; }

        public string RefDoc { get; set; }

        public int CommodityId { get; set; }

        public int? ProductLifeCycleStageId { get; set; }

        public int? PartDateCodeId { get; set; }

        public string Manufacturer { get; set; }

        public string MediaCode { get; set; }

        public string MaskedMPN { get; set; }

        public string ManufacturePartNumber { get; set; }

        public int? SupplierId { get; set; }

        public int? IPSerialNumber { get; set; }

        public string IPVersion { get; set; }

        public string SiteIP { get; set; }

        public int? SiteIPSerialNumber { get; set; }

        public string SiteIPVersion { get; set; }

        public string CAFNo { get; set; }

        public string JabilOwnerContact { get; set; }

        public int StateTypeId { get; set; }

        public string Comment { get; set; }

        public int? SubmittedByUserId { get; set; }

        public DateTimeOffset? SubmittedDate { get; set; }

        public int? AssignToUserId { get; set; }

        public int? ApproveRejectedId { get; set; }

        public DateTimeOffset? ApproveRejectedDate { get; set; }

        public int? SupplierContactId { get; set; }

        public bool IsMPNMatched { get; set; }

        public string MPNMaterialHERS { get; set; }

        public string MPNReason { get; set; }

        public int SpecTypeId { get; set; }

        public int DataTypeId { get; set; }

        public int[] RemovedAttachmentIds { get; set; }

        public List<int> AddedSamplingPlanIds { get; set; }

        public List<int> RemovedSamplingPlanIds { get; set; }

        public List<int> AddedSupplierIds { get; set; }

        public List<int> RemovedSupplierIds { get; set; }

        public int? ReferenceSAPPartInspectionPlanId { get; set; }

        public IEnumerable<PartInspectionDrawingAttachmentModel> SAPPartInspectionPlanModels { get; set; }

        public virtual IEnumerable<SAPPartInspectionPlanSamplingPlanModel> SAPPartInspectionPlanSamplingPlans { get; set; }

        public virtual IEnumerable<SAPPartInspectionPlanCommentModel> PartComments { get; set; }



    }
}
