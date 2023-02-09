using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.PartInspectionCertificationAttachmentCommand.Add;
using QSS.eIQC.Handlers.Commands.PartInspectionCertificationAttachmentCommand.Update;

namespace QSS.eIQC.Handlers.Commands.PartInspectionCertificationAttachmentCommand
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
			CreateMap<PartInspectionCertificationAttachment, PartInspectionCertificationAttachmentModel>()
				.ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
				.ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
				.ForMember(dest => dest.CreatedByUser, opt => opt.MapFrom(src => src.CreatedByUser))
				.ForMember(dest => dest.LastUpdatedByUser, opt => opt.MapFrom(src => src.LastUpdatedByUser));

			CreateMap<PartInspectionCertificationAttachmentModel, PartInspectionCertificationAttachment>()
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

			CreateMap<AddPartInspectionCertificationAttachmentModel, PartInspectionCertificationAttachment>()
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

			CreateMap<UpdatePartInspectionCertificationAttachmentModel, PartInspectionCertificationAttachment>()
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

		}
	}
}
