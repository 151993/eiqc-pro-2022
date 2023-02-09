using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.Handlers.Commands.CommodityPartNumberSiteCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Commodity model
        /// </summary>
        public MappingProfile()
        {

            CreateMap<CommodityPartNumberSite, CommodityPartNumberSiteModel>()
            //.ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.Commodity, opt =>
            {
                opt.ExplicitExpansion();
            });

        }
    }
}
