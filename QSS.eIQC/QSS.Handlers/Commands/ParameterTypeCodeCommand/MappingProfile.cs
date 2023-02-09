
﻿using AutoMapper;
using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand.Add;
using QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand.Update;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.ParameterTypeCodeCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<ParameterTypeCode, ParameterTypeCodeModel>()
                .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
                .ForMember(dest => dest.ParameterManagementType, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.PMTDescription, opt =>
                {
                    opt.MapFrom(src => src.ParameterManagementType.Description);
                })
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                 .ForMember(dest => dest.PCCodes, opt =>
                 {
                     opt.MapFrom(src => src.ParameterTypePcCodes.Select(sd => sd.PCCode));
                     opt.ExplicitExpansion();
                 });

            CreateMap<AddParameterTypeCodeModel, ParameterTypeCode>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdateParameterTypeCodeModel, ParameterTypeCode>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<ParameterManagementTypeModel, QSS.eIQC.Handlers.Commands.ParameterManagementTypeCommand.ParameterManagementTypeModel>();

        }
    }
}
