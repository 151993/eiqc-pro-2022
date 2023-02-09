/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand.Add;
using QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand.Update;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.InspectionToolsTypeCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<InspectionToolsType, InspectionToolsTypeModel>()
                .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.PCCodes, opt =>
                {
                    opt.MapFrom(src => src.InspectionToolsTypePcCodes.Select(sd => sd.PCCode));
                    opt.ExplicitExpansion();
                });

            CreateMap<AddInspectionToolsTypeModel, InspectionToolsType>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdateInspectionToolsTypeModel, InspectionToolsType>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

        }
    }
}
