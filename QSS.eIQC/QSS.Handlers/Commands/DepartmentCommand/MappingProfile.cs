using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.DepartmentCommand.Add;
using QSS.eIQC.Handlers.Commands.DepartmentCommand.Update;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.DepartmentCommand
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

            CreateMap<Department, DepartmentModel>()
            .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<UpdateDepartmentModel, Department>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));

            CreateMap<AddDepartmentModel, Department>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));
        }
    }
}
