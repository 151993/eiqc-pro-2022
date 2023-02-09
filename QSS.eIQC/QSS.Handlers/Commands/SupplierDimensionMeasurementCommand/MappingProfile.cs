/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Models;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.SupplierDimensionMeasurementCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SupplierDimensionMeasurementModel, SupplierDimensionMeasurement>()
                .ForMember(dest => dest.SupplierDimensionMeasurementActuals, opt => opt.ExplicitExpansion());

            CreateMap<SupplierDimensionMeasurement, SupplierDimensionMeasurementModel>()
                .ForMember(dest => dest.SupplierDimensionMeasurementActuals, opt => opt.ExplicitExpansion());
        }
    }
}
