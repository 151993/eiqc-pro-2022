/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SupplierLPositionCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierLPositionCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SupplierLPositionModel, SupplierLPosition>()

                     .ForMember(dest => dest.PartDimension, opt => opt.ExplicitExpansion())
                 .ForMember(dest => dest.ParameterManagement, opt => opt.ExplicitExpansion())
                 .ForMember(dest => dest.InstrumentType, opt => opt.ExplicitExpansion())
                  .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive))
                  .ForMember(dest => dest.SupplierLPositionActuals, opt => opt.ExplicitExpansion())
               .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

        }
    }
}
