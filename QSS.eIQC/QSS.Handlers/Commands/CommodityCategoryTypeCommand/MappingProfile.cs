using AutoMapper;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Handlers.Commands.CommodityCategoryTypeCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Division models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<CommodityCategoryType, CommodityCategoryTypeModel>()
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());
        }
    }
}
