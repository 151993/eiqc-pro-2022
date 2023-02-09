using AutoMapper;
using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.RoleCommand.Add;
using QSS.eIQC.Handlers.Commands.RoleCommand.Update;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.RoleCommand
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
            CreateMap<Role, RoleModel>()
            .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.RoleEnum, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.PermissionTypeIds, opt => opt.MapFrom(src => src.Permissions.Select(d => (int)d.PermissionType)));
            
            CreateMap<AddRoleModel, Role>()
                    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive))
                    .ForMember(dest => dest.Permissions, opt => opt.Ignore());

            CreateMap<UpdateRoleModel, Role>()
                   .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                   .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<RoleEnumModel, QSS.eIQC.Handlers.Commands.RoleEnumCommand.RoleEnumModel>();
        }
    }
}
