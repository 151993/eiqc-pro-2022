using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.LocationCommand.Add;
using QSS.eIQC.Handlers.Commands.LocationCommand.Update;

namespace QSS.eIQC.Handlers.Commands.LocationCommand
{
    /// <summary>
    /// Mapping for Location CRUD Operations
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Location models
        /// </summary>
        public MappingProfile()
        {

            CreateMap<Location, LocationModel>()
            .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.Country, opt =>
             {
                 opt.ExplicitExpansion();
             });

            CreateMap<UpdateLocationModel, Location>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));

            CreateMap<AddLocationModel, Location>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));
        }
    }
}
