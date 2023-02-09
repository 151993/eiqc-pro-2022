using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.UserCommand.Add;
using QSS.eIQC.Handlers.Commands.UserCommand.Update;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.UserCommand
{
    /// <summary>
    /// Mapping for User CRUD Operations
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Department models
        /// </summary>
        public MappingProfile()
        {

            CreateMap<User, JabilUserModel>()
            .ForMember(dest => dest.DisplayName, opt => opt.MapFrom(src => $"{src.Name} ({src.UserName})"))
            .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
             .ForMember(dest => dest.Department, opt =>
             {
                 opt.ExplicitExpansion();
             })
             .ForMember(dest => dest.Manager, opt =>
             {
                 opt.ExplicitExpansion();
             })
            .ForMember(dest => dest.Roles, opt =>
            {
                opt.MapFrom(src => src.Roles.Select(ur => ur.Role));
                opt.ExplicitExpansion();
            })
             .ForMember(dest => dest.Site, opt =>
             {
                 opt.ExplicitExpansion();
             })
              .ForMember(dest => dest.Supplier, opt =>
              {
                  opt.ExplicitExpansion();
              });
             

            CreateMap<User, UserEmailModel>()
            .ForMember(dest => dest.Roles, opt =>
            {
                opt.MapFrom(src => src.Roles.Select(ur => ur.Role));
                opt.ExplicitExpansion();
            });


            CreateMap<UpdateUserModel, User>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));

            CreateMap<AddUserModel, User>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));
        }
    }
}
