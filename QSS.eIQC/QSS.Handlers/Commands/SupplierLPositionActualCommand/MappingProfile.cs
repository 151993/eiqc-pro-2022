using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SupplierLPositionActualCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierLPositionActualCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SupplierLPositionActualModel, SupplierLPositionActual>()
               .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive))

                //.ForMember(dest => dest.SupplierMeasurementSubmissions, opt => opt.ExplicitExpansion())

                //.ForMember(dest => dest.SupplierLPositions, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            //CreateMap<AddSupplierLPositionActualModel, SupplierLPositionActual>()
            //    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            //CreateMap<UpdateSupplierLPositionActualModel, SupplierLPositionActual>()
            //    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

        }
    }
}
