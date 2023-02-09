using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.RoleCommand.Add;
using QSS.eIQC.Handlers.Commands.RoleCommand.Update;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.DefectTypeCommand
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
            CreateMap<DefectType, DefectTypeModel>()
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => true))
            .ForMember(dest => dest.EnableRowEdit, opt => opt.MapFrom(src => false))
            .ForMember(dest => dest.enableRowView, opt => opt.MapFrom(src => false))
            .ForMember(dest => dest.enableRowDelete, opt => opt.MapFrom(src => true));
           
        }
    }
}
