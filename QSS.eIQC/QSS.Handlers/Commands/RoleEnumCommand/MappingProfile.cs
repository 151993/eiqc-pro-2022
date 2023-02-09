
﻿using AutoMapper;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Handlers.Commands.RoleEnumCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<RoleEnum, RoleEnumModel>()
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

        }
    }
}
