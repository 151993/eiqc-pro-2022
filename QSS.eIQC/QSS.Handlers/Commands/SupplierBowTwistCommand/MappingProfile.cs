/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Models;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.SupplierBowTwistCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SupplierBowTwistModel, SupplierBowTwist>()
                .ForMember(dest => dest.PartInspectionBowTwistParameter, opt => opt.ExplicitExpansion())

                .ForMember(dest => dest.SupplierBowTwistActuals, opt => opt.ExplicitExpansion());

            CreateMap<SupplierBowTwist, SupplierBowTwistModel>()
                .ForMember(dest => dest.SupplierBowTwistActuals, opt => opt.ExplicitExpansion())
                 .ForMember(dest => dest.BowTwistFormulas, opt =>
                 {
                     opt.MapFrom(src => src.PartInspectionBowTwistParameter.BowTwistFormula);
                     opt.ExplicitExpansion();
                 });
        }
    }
}
