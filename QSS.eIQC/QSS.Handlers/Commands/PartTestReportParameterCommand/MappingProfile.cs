using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand;
using QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand.Add;
using QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand.Update;

namespace QSS.eIQC.Handlers.Commands.PartTestReportParameterCommand
{
	/// <summary>
	/// Mapping for Commodity CRUD Operations
	/// </summary>
	public class MappingProfile : Profile
	{
		/// <summary>
		/// Bootstraps the mapping of base 
		/// </summary>
		public MappingProfile()
		{

			CreateMap<PartTestReportParameterModel, PartTestReportParameter>()
		   .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive))		 
		   .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
		   .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
			.ForMember(dest => dest.PartTestReportAttachments, opt => opt.ExplicitExpansion());

			CreateMap<PartTestReportAttachment, PartTestReportAttachmentModel>()
				.ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
				.ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion());

			CreateMap<PartTestReportAttachmentModel, PartTestReportAttachment>()
				.ForMember(dest => dest.Attachment, opt => opt.MapFrom(src => src.Attachment))
				.ForMember(dest => dest.PartTestReportParameter, opt => opt.MapFrom(src => src.PartTestReportParameter));

        }
	}
}
