using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Handlers.Commands.MaterialGroupCommand;

namespace QSS.eIQC.Handlers.Commands.ParameterManagementTypeCommand
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
            CreateMap<ParameterManagementType, ParameterManagementTypeModel>()
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());
        }
    }
}
