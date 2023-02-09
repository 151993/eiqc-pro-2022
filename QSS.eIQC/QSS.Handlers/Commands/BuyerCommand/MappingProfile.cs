/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
﻿using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.BuyerCommand.Add;
using QSS.eIQC.Handlers.Commands.BuyerCommand.Update;

namespace QSS.eIQC.Handlers.Commands.BuyerCommand
{
    /// <summary>
    /// Mapping for Buyer CRUD operations
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Buyer models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Buyer, BuyerModel>()
            .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<AddBuyerModel, Buyer>()

                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdateBuyerModel, Buyer>()

                   .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

        }
    }
}
