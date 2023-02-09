/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using MediatR;
using QSS.eIQC.Handlers.Commands.AttachmentCommand.Add;
using QSS.eIQC.Handlers.Commands.PartFunParameterCommand;
using QSS.eIQC.Handlers.Commands.PartLPositionToleranceCommand;
using QSS.eIQC.Handlers.Commands.PartMeasurementParameterCommand;
using QSS.eIQC.Handlers.Commands.PartMicrosectionCommand;
using QSS.eIQC.Handlers.Commands.PartMPositionToleranceCommand;
using QSS.eIQC.Handlers.Commands.PartResultOrientedParameterCommand;
using QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanSamplingPlanCommand;
using System;
using System.Collections.Generic;
using QSS.eIQC.Handlers.Commands.PartTestReportParameterCommand;
using QSS.eIQC.Handlers.Commands.PartDateCodeCommand;
using QSS.eIQC.Handlers.Commands.PartCountParameterCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecificationCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommentCommand;

namespace QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Add
{
    /// <summary>
    /// Representation model for Add SAPPartInspectionPlan operation
    /// </summary>
    public class AddSAPPartInspectionPlanModel : BaseCommand, IRequest<SAPPartInspectionPlanModel>
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

        public string Manufacturer { get; set; }

        public string MediaCode { get; set; }

        public string MaskedMPN { get; set; }

        public string ManufacturePartNumber { get; set; }

        public int? AdminCertificationId { get; set; }

        public int? SupplierId { get; set; }

        public int? SupplierContactId { get; set; }

        public string JabilOwnerContact { get; set; }

        public int? ProductLifeCycleStageId { get; set; }

        public IEnumerable<AddAttachmentModel> UploadCertificationAttachments { get; set; }

        public int StateTypeId { get; set; }

        public string Comment { get; set; }

        public int? SubmittedByUserId { get; set; }

        public DateTimeOffset SubmittedDate { get; set; }

        public int? AssignToUserId { get; set; }

        public int? ApproveRejectedId { get; set; }

        public DateTimeOffset ApproveRejectedDate { get; set; }

        public List<int> AddedAdminCertificateIds { get; set; }

        public List<int> AddedManufacturePartNumberIds { get; set; }

        public bool IsMPNMatched { get; set; }

        public string MPNMaterialHERS { get; set; }

        public string MPNReason { get; set; }

        public int SpecTypeId { get; set; }

        public int DataTypeId { get; set; }

        public int? WarPageTypeId { get; set; }

        public int? IPSerialNumber { get; set; }

        public string IPVersion { get; set; }
        
        public string SiteIP { get; set; }

        public int? SiteIPSerialNumber { get; set; }

        public string SiteIPVersion { get; set; }

        public string CAFNo { get; set; }

        public int? ReferenceSAPPartInspectionPlanId { get; set; }

        public IEnumerable<SAPPartInspectionPlanSamplingPlanModel> SAPPartInspectionPlanSamplingPlans { get; set; }

        public IEnumerable<PartMPositionToleranceModel> PartMPositionTolerances { get; set; }

        public IEnumerable<PartLPositionToleranceModel> PartLPositionTolerances { get; set; }

        public IEnumerable<PartMeasurementParameterModel> PartMeasurementParameters { get; set; }

        public IEnumerable<PartMicrosectionModel> PartMicrosectionParameters { get; set; }

        public IEnumerable<PartFunParameterModel> PartFunParameters { get; set; }

        public IEnumerable<PartResultOrientedParameterModel> PartResultOrientedParameters { get; set; }


        public IEnumerable<PartInspectionBowTwistParameterModel> PartInspectionBowTwistParameters { get; set; }

        public IEnumerable<PartTestReportParameterModel> PartTestReportParameters { get; set; }

        public virtual PartDateCodeModel PartDateCode { get; set; }

        public virtual IEnumerable<PartCountParameterModel> PartCountParameters { get; set; }

        public virtual IEnumerable<PartInspectionDrawingModel> PartInspectionDrawings { get; set; }

        public virtual IEnumerable<PartInspectionSpecificationModel> PartInspectionSpecifications { get; set; }

        public virtual IEnumerable<SAPPartInspectionPlanCommentModel> PartComments { get; set; }

    }
}
