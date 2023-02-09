/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.AdminCertificationCommand;
using QSS.eIQC.Handlers.Commands.PartFunParameterCommand;
using QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionCertificationAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartLPositionToleranceCommand;
using QSS.eIQC.Handlers.Commands.PartMeasurementParameterCommand;
using QSS.eIQC.Handlers.Commands.PartMicrosectionCommand;
using QSS.eIQC.Handlers.Commands.PartMPositionToleranceCommand;
using QSS.eIQC.Handlers.Commands.PartResultOrientedParameterCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanAdminCertificationCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Add;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.ApproveReject;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand.Update;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanSamplingPlanCommand;
using System.Linq;
using QSS.eIQC.Handlers.Commands.PartTestReportParameterCommand;
using QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartDateCodeCommand;
using QSS.eIQC.Handlers.Commands.PartCountParameterCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingCommand;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecificationCommand;
using QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommentCommand;

namespace QSS.eIQC.Handlers.Commands.SAPPartInspectionPlanCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SAPPartInspectionPlan, SAPPartInspectionPlanModel>().PreserveReferences()
 .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
 .ForMember(dest => dest.EnableRowEdit, opt => opt.MapFrom(src => (src.StateTypeId == (int)StateType.Draft || src.StateTypeId == (int)StateType.Rejected_By_SQE
 || src.StateTypeId == (int)StateType.Rejected_By_DCC || src.Status == StatusType.Active)))




 .ForMember(dest => dest.enableRowDelete, opt => opt.MapFrom(src => (src.StateTypeId == (int)StateType.Draft
 || src.StateTypeId == (int)StateType.Rejected_By_SQE || src.Status == StatusType.Active)))
 .ForMember(dest => dest.enableRowView, opt => opt.MapFrom(src => false))
 .ForMember(dest => dest.WorkCell, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.Commodity, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.PartDateCode, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.DateCodeLimit, opt =>
 {
     opt.MapFrom(src => src.PartDateCode.DateCodeLimit);
 })
 .ForMember(dest => dest.AdminCertifications, opt =>
 {
     opt.MapFrom(src => src.SAPPartInspectionPlanAdminCertifications.Select(sd => sd.AdminCertification));
     opt.ExplicitExpansion();
 }).PreserveReferences()
 .ForMember(dest => dest.ProductLifeCycleStage, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.StateType, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.SubmittedBy, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.SAPPartInspectionPlanSamplingPlans, opt => opt.ExplicitExpansion()).PreserveReferences()



 .ForMember(dest => dest.PartMPositionTolerances, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.PartLPositionTolerances, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.PartMeasurementParameters, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.PartMicrosectionParameters, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.PartFunParameters, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.PartCountParameters, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.PartResultOrientedParameters, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.PartTestReportParameters, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.SAPPartInspectionPlanAdminCertifications, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.AssignTo, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.ApproveRejected, opt => opt.ExplicitExpansion()).PreserveReferences()
 .ForMember(dest => dest.PartInspectionBowTwistParameters, opt => opt.ExplicitExpansion()).PreserveReferences();

            CreateMap<PartInspectionDrawingAttachment, PartInspectionDrawingAttachmentModel>()
                           .ForMember(dest => dest.Attachment, opt => opt.MapFrom(src => src.Attachment));

            CreateMap<PartInspectionSpecAttachment, PartInspectionSpecAttachmentModel>()
                            .ForMember(dest => dest.Attachment, opt => opt.MapFrom(src => src.Attachment));

            CreateMap<PartInspectionCertificationAttachment, PartInspectionCertificationAttachmentModel>()
                         .ForMember(dest => dest.Attachment, opt => opt.MapFrom(src => src.Attachment))
                         .ForMember(dest => dest.SAPPartInspectionPlan, opt => opt.MapFrom(src => src.SAPPartInspectionPlan));

            CreateMap<AddSAPPartInspectionPlanModel, SAPPartInspectionPlan>()
                .ForMember(dest => dest.SAPPartInspectionPlanAdminCertifications, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.SAPPartInspectionPlanSamplingPlans, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.PartMPositionTolerances, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.PartLPositionTolerances, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.PartMeasurementParameters, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.PartMicrosectionParameters, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.PartFunParameters, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.PartResultOrientedParameters, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.PartTestReportParameters, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.PartInspectionBowTwistParameters, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.PartDateCode, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.PartCountParameters, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.PartInspectionDrawings, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.PartInspectionSpecifications, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdateSAPPartInspectionPlanModel, SAPPartInspectionPlan>()
                .ForMember(dest => dest.SAPPartInspectionPlanAdminCertifications, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SAPPartInspectionPlanSamplingPlans, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.PartMPositionTolerances, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.PartLPositionTolerances, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.PartMeasurementParameters, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.PartMicrosectionParameters, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.PartFunParameters, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.PartResultOrientedParameters, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.PartTestReportParameters, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.PartDateCode, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.PartInspectionBowTwistParameters, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.PartCountParameters, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.PartInspectionDrawings, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.PartInspectionSpecifications, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));


            CreateMap<ProductLifeCycleStageModel, QSS.eIQC.Handlers.Commands.ProductLifeCycleStageCommand.ProductLifeCycleStageModel>();

            CreateMap<SAPPartInspectionPlanSupplier, SAPPartInspectionPlanSupplierModel>();

            CreateMap<SAPPartInspectionPlanAdminCertification, SAPPartInspectionPlanAdminCertificationModel>();

            CreateMap<SAPPartInspectionPlanAdminCertification, AdminCertificationModel>();

            CreateMap<SAPPartInspectionPlanSamplingPlan, SAPPartInspectionPlanSamplingPlanModel>().ReverseMap();

            CreateMap<PartMPositionTolerance, PartMPositionToleranceModel>()
                .ForMember(dest => dest.PartDimension, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.ParameterManagement, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.UOM, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.InstrumentType, opt => opt.ExplicitExpansion());


            CreateMap<PartLPositionTolerance, PartLPositionToleranceModel>()
                 .ForMember(dest => dest.PartDimension, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.ParameterManagement, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.UOM, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.InstrumentType, opt => opt.ExplicitExpansion());

            CreateMap<PartMeasurementParameter, PartMeasurementParameterModel>().ReverseMap();

            CreateMap<PartMicrosection, PartMicrosectionModel>().ReverseMap();

            CreateMap<PartFunParameter, PartFunParameterModel>().ReverseMap();

            CreateMap<PartResultOrientedParameter, PartResultOrientedParameterModel>()
                .ForMember(dest => dest.ParameterManagement, opt => opt.ExplicitExpansion());

            CreateMap<PartCountParameter, PartCountParameterModel>()
            .ForMember(dest => dest.InspectionToolsType, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.ParameterManagement, opt => opt.ExplicitExpansion());

            CreateMap<PartInspectionBowTwistParameter, PartInspectionBowTwistParameterModel>()
               .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
               .ForMember(dest => dest.BowTwistFormula, opt => opt.ExplicitExpansion());

            CreateMap<PartTestReportParameter, PartTestReportParameterModel>();

            CreateMap<PartInspectionDrawing, PartInspectionDrawingModel>();

            CreateMap<SAPPartInspectionPlanComment, SAPPartInspectionPlanCommentModel>();

            CreateMap<PartInspectionSpecification, PartInspectionSpecificationModel>();

            CreateMap<PartDateCode, PartDateCodeModel>();

            CreateMap<PartTestReportAttachment, PartTestReportAttachmentModel>()
                           .ForMember(dest => dest.Attachment, opt => opt.MapFrom(src => src.Attachment));

            CreateMap<ApproveRejectSAPPartInspectionPlanModel, SAPPartInspectionPlan>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive))
                .ForMember(dest => dest.ApproveRejectedId, opt => opt.MapFrom(src => src.ApproveRejectedId))
                .ForMember(dest => dest.ApproveRejectedDate, opt => opt.MapFrom(src => src.ApproveRejectedDate));


        }
    }
}
