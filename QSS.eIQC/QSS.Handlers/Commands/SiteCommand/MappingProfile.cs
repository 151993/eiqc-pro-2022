/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SiteCommand.Add;
using QSS.eIQC.Handlers.Commands.SiteCommand.Update;
using QSS.Infrastructure.Core.QSSGatewayAPI.Model;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.SiteCommand
{
    /// <summary>
    /// Mapping for Role CRUD operations
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Site, SiteModel>()
            .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.Location, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.Divisions, opt =>
             {
                 opt.MapFrom(src => src.SiteDivisions.Select(sd => sd.Division));
                 opt.ExplicitExpansion();
             });

            CreateMap<AddSiteModel, Site>()

                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdateSiteModel, Site>()

                   .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<TM1SiteModel, Site>();
        }
    }

}
