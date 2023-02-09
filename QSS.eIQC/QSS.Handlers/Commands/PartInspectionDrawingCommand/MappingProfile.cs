/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.PartInspectionDrawingAttachmentCommand;

namespace QSS.eIQC.Handlers.Commands.PartInspectionDrawingCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {

            CreateMap<PartInspectionDrawingModel, PartInspectionDrawing>()
          .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive))
          .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
          .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
          .ForMember(dest => dest.PartInspectionDrawingAttachments, opt => opt.ExplicitExpansion());

            CreateMap<PartInspectionDrawingAttachment, PartInspectionDrawingAttachmentModel>()
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<PartInspectionDrawingAttachmentModel, PartInspectionDrawingAttachment>()
                .ForMember(dest => dest.Attachment, opt => opt.MapFrom(src => src.Attachment))
                .ForMember(dest => dest.PartInspectionDrawing, opt => opt.MapFrom(src => src.PartInspectionDrawing));

        }
    }
}
