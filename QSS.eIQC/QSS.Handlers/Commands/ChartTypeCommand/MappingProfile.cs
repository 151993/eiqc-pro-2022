

using AutoMapper;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Handlers.Commands.ChartTypeCommand
{
    /// <summary>
    /// Mapping for ProductLifeCycleStage CRUD Operations
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Division models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<ChartType, ChartTypeModel>()
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<Domain.EnumModels.ChartTypeModel, ChartTypeModel>();
        }
    }
}
