/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Models;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.SupplierDimensionMeasurementActualCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SupplierDimensionMeasurementActualModel, SupplierDimensionMeasurementActual>()
               .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
               .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());
        }
    }
}
