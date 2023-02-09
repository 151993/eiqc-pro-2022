/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Models;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.SupplierSapBasedParameterCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SupplierSapBasedParameter, SupplierSapBasedParameterModel>()
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.CertificateTypeParameter, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.enableRowAddDefectTypes, opt => opt.MapFrom(src => (src.MatchId==0)))
                .ForMember(dest => dest.DefectTypes, opt =>
                {
                    opt.MapFrom(src => src.SupplierSapBasedParameterDefectTypes.Select(sd => sd.DefectType));
                    opt.ExplicitExpansion();
                }); ;

        }
    }
}
