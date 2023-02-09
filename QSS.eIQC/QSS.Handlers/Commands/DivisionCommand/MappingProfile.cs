using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.DivisionCommand.Add;
using QSS.eIQC.Handlers.Commands.DivisionCommand.Update;
using QSS.Infrastructure.Core.QSSGatewayAPI.Model;

namespace QSS.eIQC.Handlers.Commands.DivisionCommand
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

            CreateMap<Division, DivisionModel>()
            .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<UpdateDivisionModel, Division>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));

            CreateMap<AddDivisionModel, Division>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));

            CreateMap<TM1DivisionModel, Division>();
        }
    }
}
