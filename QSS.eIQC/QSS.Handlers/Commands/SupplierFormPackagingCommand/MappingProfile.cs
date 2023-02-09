/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SupplierFormPackagingCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierFormPackagingCommand.Update;

namespace QSS.eIQC.Handlers.Commands.SupplierFormPackagingCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SupplierFormPackaging, SupplierFormPackagingModel>()
                .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierForm, opt =>
                {
                    opt.ExplicitExpansion();
                });

            CreateMap<AddSupplierFormPackagingModel, SupplierFormPackaging>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdateSupplierFormPackagingModel, SupplierFormPackaging>()
               .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

        }
    }
}
