/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand;
using QSS.eIQC.Handlers.Commands.AdminCertificationCommand.Add;
using QSS.eIQC.Handlers.Commands.AdminCertificationCommand.Update;

namespace QSS.eIQC.Handlers.Commands.AdminCertificationCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<AdminCertification, AdminCertificationModel>()
                .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
               .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<AdminCertificationAttachment, AdminCertificationAttachmentModel>()
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<AdminCertificationAttachmentModel, AdminCertificationAttachment>()
                .ForMember(dest => dest.Attachment, opt => opt.MapFrom(src => src.Attachment))
                .ForMember(dest => dest.AdminCertification, opt => opt.MapFrom(src => src.AdminCertification));

            CreateMap<AddAdminCertificationModel, AdminCertification>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdateAdminCertificationModel, AdminCertification>()
                .ForMember(dest => dest.AdminCertificationAttachments, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

        }
    }
}
