using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.RegionCommand.Add;
using QSS.eIQC.Handlers.Commands.RegionCommand.Update;
using System.Linq;


namespace QSS.eIQC.Handlers.Commands.RegionCommand
{
    /// <summary>
    
    /// Mapping for User CRUD Operations
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>

        /// Bootstraps the mapping of base Region models
        /// </summary>
        public MappingProfile()
        {


            CreateMap<Region, RegionModel>()
            .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());


            CreateMap<UpdateRegionModel, Region>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));


            CreateMap<AddRegionModel, Region>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));
        }
    }
}
