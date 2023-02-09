/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Models;

namespace QSS.eIQC.Handlers.Commands.PartMPositionToleranceCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<PartMPositionToleranceModel, PartMPositionTolerance>()
                 .ForMember(dest => dest.PartDimension, opt => opt.ExplicitExpansion())
                 .ForMember(dest => dest.ParameterManagement, opt => opt.ExplicitExpansion())
                 .ForMember(dest => dest.UOM, opt => opt.ExplicitExpansion())
                 .ForMember(dest => dest.InstrumentType, opt => opt.ExplicitExpansion());

        }
    }
}
