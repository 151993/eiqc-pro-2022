/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SupplierTestReportAttachmentCommand;

namespace QSS.eIQC.Handlers.Commands.SupplierTestReportCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SupplierTestReportModel, SupplierTestReport>()

            .ForMember(dest => dest.PartTestReportParameter, opt => opt.ExplicitExpansion());

            CreateMap<SupplierTestReportAttachment, SupplierTestReportAttachmentModel>()
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<SupplierTestReportAttachmentModel, SupplierTestReportAttachment>()
                .ForMember(dest => dest.Attachment, opt => opt.MapFrom(src => src.Attachment))
                .ForMember(dest => dest.SupplierTestReport, opt => opt.MapFrom(src => src.SupplierTestReport));

        }
    }
}
