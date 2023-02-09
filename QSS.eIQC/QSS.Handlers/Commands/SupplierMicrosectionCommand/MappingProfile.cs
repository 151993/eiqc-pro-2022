/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Models;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.SupplierMicrosectionCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SupplierMicrosectionModel, SupplierMicrosection>()
                .ForMember(dest => dest.SupplierMicroSectionActuals, opt => opt.ExplicitExpansion());
        }
    }
}
