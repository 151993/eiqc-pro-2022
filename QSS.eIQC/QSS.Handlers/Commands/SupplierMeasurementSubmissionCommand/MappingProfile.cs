/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SMSCommentAttachmentCommand;
using QSS.eIQC.Handlers.Commands.SupplierDateCodeCommand;
using QSS.eIQC.Handlers.Commands.SupplierDimensionMeasurementActualCommand;
using QSS.eIQC.Handlers.Commands.SupplierDimensionMeasurementCommand;
using QSS.eIQC.Handlers.Commands.SupplierFunctionVariableActualCommand;
using QSS.eIQC.Handlers.Commands.SupplierFunctionVariableCommand;
using QSS.eIQC.Handlers.Commands.SupplierLPositionActualCommand;
using QSS.eIQC.Handlers.Commands.SupplierLPositionCommand;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.ApproveReject;
using QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierMicrosectionCommand;
using QSS.eIQC.Handlers.Commands.SupplierMPositionActualCommand;
using QSS.eIQC.Handlers.Commands.SupplierMPositionCommand;
using QSS.eIQC.Handlers.Commands.SupplierSamplingPlanCommand;
using QSS.eIQC.Handlers.Commands.SupplierTestReportAttachmentCommand;
using QSS.eIQC.Handlers.Commands.SupplierTestReportCommand;
using QSS.eIQC.Handlers.Commands.SupplierVisualInspectionCommand;
using QSS.eIQC.Handlers.Commands.SupplierVisualInspectionDefectTypeCommand;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.SupplierMeasurementSubmissionCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SupplierMeasurementSubmission, SupplierMeasurementSubmissionModel>()
                .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
                .ForMember(dest => dest.EnableRowEdit, opt => opt.MapFrom(src => src.StateTypeId == (int)StateType.Draft || src.StateTypeId == (int)StateType.Submitted_By_Supplier))
                .ForMember(dest => dest.enableRowDelete, opt => opt.MapFrom(src => src.StateTypeId == (int)StateType.Draft))
                .ForMember(dest => dest.enableRowView, opt => opt.MapFrom(src => false))
                .ForMember(dest => dest.WorkCell, opt => opt.ExplicitExpansion())

                .ForMember(dest => dest.Inspector, opt => opt.ExplicitExpansion())

                .ForMember(dest => dest.SMSPOStateType, opt => opt.ExplicitExpansion())

                .ForMember(dest => dest.SupplierContact, opt => opt.ExplicitExpansion())

                .ForMember(dest => dest.Supplier, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierName, opt => opt.MapFrom(src => src.Supplier.VendorName))
                .ForMember(dest => dest.PurchaseOrderNumber, opt => opt.MapFrom(src => src.PurchaseOrder.PurchaseOrderNo))
                .ForMember(dest => dest.PurchaseOrder, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SAPPartInspectionPlan, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SubmittedBy, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.ApproveRejected, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierFunctionAttributes, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierMicroSectionParameters, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierDimensionMeasurements, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierFunctionVariables, opt => opt.ExplicitExpansion())
               .ForMember(dest => dest.SupplierSamplingPlans, opt => opt.ExplicitExpansion())
               .ForMember(dest => dest.SupplierSapBasedParameters, opt => opt.ExplicitExpansion())
               .ForMember(dest => dest.SupplierBowTwists, opt => opt.ExplicitExpansion())
               .ForMember(dest => dest.SupplierTestReports, opt => opt.ExplicitExpansion())
               .ForMember(dest => dest.SupplierMPositions, opt => opt.ExplicitExpansion())
               .ForMember(dest => dest.SupplierLPositions, opt => opt.ExplicitExpansion()).PreserveReferences()
               .ForMember(dest => dest.SupplierVisualInspections, opt => opt.ExplicitExpansion()).PreserveReferences();

            CreateMap<SMSCommentAttachment, SMSCommentAttachmentModel>()
             .ForMember(dest => dest.Attachment, opt => opt.MapFrom(src => src.Attachment))
             .ForMember(dest => dest.SupplierMeasurementSubmission, opt => opt.MapFrom(src => src.SupplierMeasurementSubmission));

            CreateMap<AddSupplierMeasurementSubmissionModel, SupplierMeasurementSubmission>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive))
                .ForMember(dest => dest.SupplierFunctionAttributes, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierMicrosectionParameters, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierSapBasedParameters, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierBowTwists, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierTestReports, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierMPositions, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierLPositions, opt => opt.ExplicitExpansion()).PreserveReferences()
                .ForMember(dest => dest.SupplierVisualInspections, opt => opt.ExplicitExpansion()).PreserveReferences();


            CreateMap<UpdateSupplierMeasurementSubmissionModel, SupplierMeasurementSubmission>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive))
                .ForMember(dest => dest.SupplierFunctionAttributes, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierMicrosectionParameters, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierSapBasedParameters, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierBowTwists, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierTestReports, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierMPositions, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierVisualInspections, opt => opt.ExplicitExpansion());

            CreateMap<SupplierMicrosection, SupplierMicrosectionModel>()
                 .ForMember(dest => dest.enableRowAddChartType, opt => opt.MapFrom(src => true))
                .ForMember(dest => dest.SupplierMicroSectionActuals, opt => opt.ExplicitExpansion());
            CreateMap<SupplierDimensionMeasurement, SupplierDimensionMeasurementModel>()
                 .ForMember(dest => dest.enableRowAddChartType, opt => opt.MapFrom(src => true)).ReverseMap();
            CreateMap<SupplierFunctionVariable, SupplierFunctionVariableModel>()
                 .ForMember(dest => dest.enableRowAddChartType, opt => opt.MapFrom(src => true)).ReverseMap();
            CreateMap<SupplierFunctionAttribute, SupplierFunctionAttributeModel>()
                .ForMember(dest => dest.SupplierFunctionAttributeActuals, opt => opt.ExplicitExpansion()).ReverseMap();
            CreateMap<SupplierBowTwist, SupplierBowTwistModel>()
                .ForMember(dest => dest.PartInspectionBowTwistParameter, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.BowTwistFormulas, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierBowTwistActuals, opt => opt.ExplicitExpansion());
            CreateMap<SupplierSapBasedParameter, SupplierSapBasedParameterModel>()
                .ForMember(dest => dest.enableRowAddDefectTypes, opt => opt.MapFrom(src => (src.MatchId == 0)))
                .ForMember(dest => dest.DefectTypes, opt =>
                {
                    opt.MapFrom(src => src.SupplierSapBasedParameterDefectTypes.Select(sd => sd.DefectType));
                    opt.ExplicitExpansion();
                }).ReverseMap();
            CreateMap<SupplierSamplingPlan, SupplierSamplingPlanModel>()
                .ForMember(dest => dest.PartInspectionSamplingPlan, opt => opt.ExplicitExpansion()).ReverseMap();


            CreateMap<SupplierTestReport, SupplierTestReportModel>()
               .ForMember(dest => dest.DefectType, opt => opt.ExplicitExpansion())
               .ForMember(dest => dest.PartTestReportParameter, opt => opt.ExplicitExpansion());

            CreateMap<SupplierMPosition, SupplierMPositionModel>()
                .ForMember(dest => dest.PartDimension, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.ParameterManagement, opt => opt.ExplicitExpansion())
                //.ForMember(dest => dest.UOM, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.InstrumentType, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierMPositionActuals, opt => opt.ExplicitExpansion());

            CreateMap<SupplierMPositionActual, SupplierMPositionActualModel>();


            CreateMap<SupplierTestReportAttachment, SupplierTestReportAttachmentModel>()
                          .ForMember(dest => dest.Attachment, opt => opt.MapFrom(src => src.Attachment));

            CreateMap<SupplierDateCode, SupplierDateCodeModel>();
            CreateMap<SupplierFunctionVariableActual, SupplierFunctionVariableActualModel>();
            CreateMap<SupplierDimensionMeasurementActual, SupplierDimensionMeasurementActualModel>();

            CreateMap<SupplierBowTwistActual, SupplierBowTwistActualModel>();
            CreateMap<SupplierVisualInspectionDefectType, SupplierVisualInspectionDefectTypeModel>();

            CreateMap<SupplierLPosition, SupplierLPositionModel>()
                .ForMember(dest => dest.PartDimension, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.ParameterManagement, opt => opt.ExplicitExpansion())
                //.ForMember(dest => dest.UOM, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.InstrumentType, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierLPositionActuals, opt => opt.ExplicitExpansion());

            CreateMap<SupplierLPositionActual, SupplierLPositionActualModel>();

            CreateMap<SupplierMicroSectionActual, SupplierMicroSectionActualModel>();

            CreateMap<SupplierFunctionAttributeActual, SupplierFunctionAttributeActualModel>();



            CreateMap<SupplierVisualInspection, SupplierVisualInspectionModel>()
                //.ForMember(dest => dest.PartCountParameter, opt => opt.ExplicitExpansion())
             .ForMember(dest => dest.DefectTypes, opt =>
            {
                opt.MapFrom(src => src.SupplierVisualInspectionDefectTypes.Select(sd => sd.DefectType));
                opt.ExplicitExpansion();
            }).ReverseMap();

            CreateMap<ApproveRejectSupplierMeasurementSubmissionPlanModel, SupplierMeasurementSubmission>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));
                //.ForMember(dest => dest.ApproveRejectedId, opt => opt.MapFrom(src => src.ApproveRejectedId))
                //.ForMember(dest => dest.ApproveRejectedDate, opt => opt.MapFrom(src => src.ApproveRejectedDate));
           }
    }
}
