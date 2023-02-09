/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SiteCommand;
using QSS.eIQC.Handlers.Commands.SiteUserCommand;
using QSS.eIQC.Handlers.Commands.SiteUserCommand.Add;
using QSS.eIQC.Handlers.Commands.SiteUserCommand.Update;

namespace QSS.eIQC.Handlers.Commands.SiteSmeCommand
{
    /// <summary>
    /// Mapping for SiteUser CRUD operations
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base SiteSme models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SiteUser, SiteUserModel>()
            .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
             .ForMember(dest => dest.SiteName, opt =>
             {
                 opt.MapFrom(src => src.Site.Name);
             })
            .ForMember(dest => dest.Name, opt =>
            {
                opt.MapFrom(src => src.User.Name);
            })
            .ForMember(dest => dest.Email, opt =>
            {
                opt.MapFrom(src => src.User.Email);
            })
             .ForMember(dest => dest.Department, opt =>
             {
                 opt.MapFrom(src => src.User.Department.Name);
             })
            .ForMember(dest => dest.Supervisor, opt =>
            {
                opt.MapFrom(src => src.User.Manager.Name);
            })
            .ForMember(dest => dest.SupervisorEmail, opt =>
            {
                opt.MapFrom(src => src.User.Email);
            })
            .ForMember(dest => dest.User, opt =>
            {
                opt.MapFrom(src => src.User);
            })
            .ForMember(dest => dest.Site, opt =>
            {
                opt.MapFrom(src => src.Site);
            });
            CreateMap<SiteUserModel, SiteUser>().ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<SiteModel, Site>().ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<AddSiteUserModel, SiteUser>()
                    .ForMember(dest => dest.Site, opt => opt.MapFrom(src => src.Site))
                    .ForMember(dest => dest.SiteId, opt => opt.MapFrom(src => src.Site.Id))
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdateSiteUserModel, SiteUser>()
                   .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));


        }

    }
}
