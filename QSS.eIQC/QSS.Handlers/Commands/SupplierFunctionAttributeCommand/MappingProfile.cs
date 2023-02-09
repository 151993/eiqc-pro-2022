/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Models;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.SupplierFuntionAttributeCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SupplierFunctionAttribute, SupplierFunctionAttributeModel>()
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.ParameterManagement, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierFunctionAttributeActuals, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.enableRowAddDefectTypes, opt => opt.MapFrom(src => (src.ResultActualId == 2)))
                .ForMember(dest => dest.DefectTypes, opt =>
                {
                    opt.MapFrom(src => src.SupplierFunctionAttributeDefectTypes.Select(sd => sd.DefectType));
                    opt.ExplicitExpansion();
                });

        }
    }
}
