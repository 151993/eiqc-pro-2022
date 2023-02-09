using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand.Add;
using QSS.eIQC.Handlers.Commands.PartTestReportAttachmentCommand.Update;

namespace QSS.eIQC.Handlers.Commands.SupplierTestReportAttachmentCommand
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

			CreateMap<AddPartTestReportAttachmentModel, PartTestReportAttachment>()
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

			CreateMap<UpdatePartTestReportAttachmentModel, PartTestReportAttachment>()
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

		}
	}
}
