/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.PCCodeInspectionToolsTypeCommand.Add;
using QSS.eIQC.Handlers.Commands.PCCodeInspectionToolsTypeCommand.Update;

namespace QSS.eIQC.Handlers.Commands.PCCodeInspectionToolsTypeCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<PCCodeInspectionToolsType, PCCodeInspectionToolsTypeModel>()
                .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))

                .ForMember(dest => dest.PCCode, opt => opt.ExplicitExpansion())

                .ForMember(dest => dest.InspectionToolsType, opt => opt.ExplicitExpansion())

                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<AddPCCodeInspectionToolsTypeModel, PCCodeInspectionToolsType>()

                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdatePCCodeInspectionToolsTypeModel, PCCodeInspectionToolsType>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

        }
    }
}
