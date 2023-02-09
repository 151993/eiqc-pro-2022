/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Models;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.SupplierVisualInspectionCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SupplierVisualInspection, SupplierVisualInspectionModel>()
                //.ForMember(dest => dest.PartCountParameter, opt => opt.ExplicitExpansion())
                //.ForMember(dest => dest.InspectionToolsType, opt =>
                //{
                //    opt.MapFrom(src => src.PartCountParameter.InspectionToolsType);
                //})
                //.ForMember(dest => dest.enableRowAddDefectTypes, opt => opt.MapFrom(src => (src.ResultActualId == 2)))
                .ForMember(dest => dest.enableRowAddDefectTypes, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.DefectTypes, opt =>
                {
                    opt.MapFrom(src => src.SupplierVisualInspectionDefectTypes.Select(sd => sd.DefectType));
                    opt.ExplicitExpansion();
                });
        }
    }
}



