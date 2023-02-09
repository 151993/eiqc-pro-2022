

using AutoMapper;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Handlers.Commands.WarPageCommand
{
    /// <summary>
    /// Mapping for Division CRUD Operations
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Division models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<WarPage, WarPageModel>()
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());
        }
    }
}
