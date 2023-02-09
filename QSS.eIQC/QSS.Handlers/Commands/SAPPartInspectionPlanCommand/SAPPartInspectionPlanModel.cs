/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using QSS.eIQC.Handlers.Commands.AdminCertificationCommand;
using QSS.eIQC.Handlers.Commands.CommodityCommand;
using QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand;
using QSS.eIQC.Handlers.Commands.PartCommand;
using QSS.eIQC.Handlers.Commands.PartDateCodeCommand;
using QSS.eIQC.Handlers.Commands.PartCountParameterCommand;
using QSS.eIQC.Handlers.Commands.PartFunParameterCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionCertificationAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartLPositionToleranceCommand;
using QSS.eIQC.Handlers.Commands.PartMeasurementParameterCommand;
using QSS.eIQC.Handlers.Commands.PartMicrosectionCommand;
using QSS.eIQC.Handlers.Commands.PartMPositionToleranceCommand;
using QSS.eIQC.Handlers.Commands.PartResultOrientedParameterCommand;
using QSS.eIQC.Handlers.Commands.PartTestReportParameterCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanSamplingPlanCommand;
using QSS.eIQC.Handlers.Commands.UserCommand;
using QSS.eIQC.Handlers.Commands.WorkCellCommand;
using System;
using System.Collections.Generic;
using EnumModel = QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Handlers.Commands.SupplierCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecificationCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommentCommand;

namespace QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand
{
    /// <summary>
    /// Representation model for SAPPartInspectionPlan entity
    /// </summary>
    public class SAPPartInspectionPlanModel : BaseStausModel<int>
    {
        public string PartNo { get; set; }

        public string PartDescription { get; set; }

        public string IP { get; set; }

        public bool IsSafePart { get; set; }

        public int WorkCellId { get; set; }

        public string WorkCellName { get; set; }

        public string CommodityName { get; set; }

        public string SupplierVendorName { get; set; }

        public string SubmittedByName { get; set; }

        public string StateTypeDescription { get; set; }

        public string CreatedByUserName { get; set; }

        public string DivisionModelNumber { get; set; }

        public string GenWI { get; set; }

        public string RefDoc { get; set; }

        public int CommodityId { get; set; }

        public virtual WorkCellModel WorkCell { get; set; }

        public virtual CommodityModel Commodity { get; set; }

        public virtual PartDateCodeModel PartDateCode { get; set; }

        public string Manufacturer { get; set; }

        public string ManufacturePartNumber { get; set; }

        public int AdminCertificationId { get; set; }

        public int? SupplierId { get; set; }

        public virtual SupplierModel Supplier { get; set; }

        public int? SupplierContactId { get; set; }

        public string JabilOwnerContact { get; set; }

        public int? ProductLifeCycleStageId { get; set; }

        public string Comment { get; set; }

        public int SubmittedByUserId { get; set; }

        public DateTimeOffset SubmittedDate { get; set; }

        public int AssignToUserId { get; set; }

        public int ApproveRejectedId { get; set; }

        public virtual IEnumerable<AdminCertificationModel> AdminCertifications { get; set; }

        public virtual EnumModel.StateTypeModel StateType { get; set; }

        public int StateTypeId { get; set; }


        public virtual PartModel Part { get; set; }

        public bool IsMPNMatched { get; set; }

        public string MPNMaterialHERS { get; set; }

        public string MPNReason { get; set; }

        public string MediaCode { get; set; }

        public string MaskedMPN { get; set; }

        public int SpecTypeId { get; set; }

        public int DataTypeId { get; set; }

        public int PartDateCodeId { get; set; }

        public int? ReferenceSAPPartInspectionPlanId { get; set; }

        public virtual EnumModel.ProductLifeCycleStageModel ProductLifeCycleStage { get; set; }

        public virtual IEnumerable<PartInspectionCertificationAttachmentModel> PartInspectionCertificationAttachments { get; set; }

        public virtual IEnumerable<AdminCertificationModel> SAPPartInspectionPlanAdminCertifications { get; set; }

        public virtual IEnumerable<SAPPartInspectionPlanSamplingPlanModel> SAPPartInspectionPlanSamplingPlans { get; set; }

        public virtual IEnumerable<SAPPartInspectionPlanSupplierModel> SAPPartInspectionPlanSuppliers { get; set; }



        public virtual IEnumerable<PartInspectionBowTwistParameterModel> PartInspectionBowTwistParameters { get; set; }

        public virtual JabilUserModel SubmittedBy { get; set; }

        public virtual JabilUserModel AssignTo { get; set; }

        public virtual JabilUserModel ApproveRejected { get; set; }

        public virtual JabilUserModel SupplierContact { get; set; }

        public virtual IEnumerable<PartMPositionToleranceModel> PartMPositionTolerances { get; set; }

        public virtual IEnumerable<PartLPositionToleranceModel> PartLPositionTolerances { get; set; }

        public virtual IEnumerable<PartMeasurementParameterModel> PartMeasurementParameters { get; set; }

        public virtual IEnumerable<PartMicrosectionModel> PartMicrosectionParameters { get; set; }

        public virtual IEnumerable<PartFunParameterModel> PartFunParameters { get; set; }

        public virtual IEnumerable<PartResultOrientedParameterModel> PartResultOrientedParameters { get; set; }

        public virtual IEnumerable<PartTestReportParameterModel> PartTestReportParameters { get; set; }

        public virtual IEnumerable<PartInspectionDrawingModel> PartInspectionDrawings { get; set; }

        public virtual IEnumerable<PartInspectionSpecificationModel> PartInspectionSpecifications { get; set; }

        public virtual IEnumerable<PartCountParameterModel> PartCountParameters { get; set; }


        public virtual IEnumerable<SAPPartInspectionPlanCommentModel> PartComments { get; set; }


        public int? IPSerialNumber { get; set; }

        public string IPVersion { get; set; }

        public string SiteIP { get; set; }

        public int? SiteIPSerialNumber { get; set; }

        public string SiteIPVersion { get; set; }

        public string CAFNo { get; set; }

        public string DateCodeLimit { get; set; }

    }
}