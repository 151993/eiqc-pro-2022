/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.PartInspectionSpecAttachmentCommand;

namespace QSS.eIQC.Handlers.Commands.PartInspectionSpecificationCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            //CreateMap<PartInspectionSpecificationModel, PartInspectionSpecification>()
            //    .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            //    .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<PartInspectionSpecificationModel, PartInspectionSpecification>()
           .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive))
           .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
           .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.PartInspectionSpecAttachments, opt => opt.ExplicitExpansion());

            CreateMap<PartInspectionSpecAttachment, PartInspectionSpecAttachmentModel>()
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<PartInspectionSpecAttachmentModel, PartInspectionSpecAttachment>()
                .ForMember(dest => dest.Attachment, opt => opt.MapFrom(src => src.Attachment))
                .ForMember(dest => dest.PartInspectionSpecification, opt => opt.MapFrom(src => src.PartInspectionSpecification));

        }
    }
}
