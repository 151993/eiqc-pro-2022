/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Add;
using QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand.Update;

namespace QSS.eIQC.Handlers.Commands.BowTwistFormulaCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<BowTwistFormula, BowTwistFormulaModel>()
                .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
               .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.WarPage, opt => opt.ExplicitExpansion());

            CreateMap<AddBowTwistFormulaModel, BowTwistFormula>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdateBowTwistFormulaModel, BowTwistFormula>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<WarPageModel, QSS.eIQC.Handlers.Commands.WarPageCommand.WarPageModel>();
        }
    }
}
