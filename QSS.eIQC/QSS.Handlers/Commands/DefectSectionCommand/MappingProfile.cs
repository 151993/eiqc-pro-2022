using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.MaterialGroupCommand;

namespace QSS.eIQC.Handlers.Commands.DefectSectionCommand
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
            CreateMap<DefectSection, DefectSectionModel>()
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());
        }
    }
}
