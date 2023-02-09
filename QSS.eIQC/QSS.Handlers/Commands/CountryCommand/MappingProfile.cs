using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.CountryCommand.Add;
using QSS.eIQC.Handlers.Commands.CountryCommand.Update;

namespace QSS.eIQC.Handlers.Commands.CountryCommand
{
    /// <summary>
    /// Mapping for Country CRUD Operations
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Country models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Country, CountryModel>()
            .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.Region, opt =>
            {
                opt.ExplicitExpansion();
            });

            CreateMap<UpdateCountryModel, Country>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));

            CreateMap<AddCountryModel, Country>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));
        }
    }
}
