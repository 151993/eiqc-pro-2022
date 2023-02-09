/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.FormSpecialParameterCommand.Add;
using QSS.eIQC.Handlers.Commands.FormSpecialParameterCommand.Update;

namespace QSS.eIQC.Handlers.Commands.FormSpecialParameterCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<FormSpecialParameter, FormSpecialParameterModel>()
                .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))

                .ForMember(dest => dest.Form, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<AddFormSpecialParameterModel, FormSpecialParameter>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdateFormSpecialParameterModel, FormSpecialParameter>()
               .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

        }
    }
}
