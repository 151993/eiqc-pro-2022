using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.CommodityCategoryTypeCommand;

namespace QSS.eIQC.Handlers.Commands.CommodityCategoryOptionCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Division models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<CommodityCategoryOption, CommodityCategoryOptionModel>()
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());
        }
    }
}
