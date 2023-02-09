
﻿using AutoMapper;
using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.DefectManagementCommand.Add;
using QSS.eIQC.Handlers.Commands.DefectManagementCommand.Update;

namespace QSS.eIQC.Handlers.Commands.DefectManagementCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<DefectManagement, DefectManagementModel>()
                .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
               .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.DefectTypes, opt =>   { opt.ExplicitExpansion(); })
                .ForMember(dest => dest.DefectSection, opt => { opt.ExplicitExpansion(); });

            CreateMap<DefectSectionModel, QSS.eIQC.Handlers.Commands.DefectSectionCommand.DefectSectionModel>();

            CreateMap<AddDefectManagementModel, DefectManagement>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdateDefectManagementModel, DefectManagement>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

        }
    }
}
