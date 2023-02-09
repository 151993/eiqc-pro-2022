/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand.Add;
using QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand.Update;

namespace QSS.eIQC.Handlers.Commands.PartBowTwistParameterCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {

            CreateMap<PartInspectionBowTwistParameterModel, PartInspectionBowTwistParameter>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive))
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.BowTwistFormula, opt => opt.ExplicitExpansion());
        }
    }
}
