using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand;
using QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand.Add;
using QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand.Update;
using QSS.eIQC.Handlers.Common;


namespace QSS.eIQC.Handlers.Commands.AdminCertificationAttachmentCommand
{
	/// <summary>
	/// Mapping for Commodity CRUD Operations
	/// </summary>
	public class MappingProfile: Profile
	{
		/// <summary>
		/// Bootstraps the mapping of base Commodity models
		/// </summary>
		public MappingProfile()
		{
			CreateMap<AdminCertificationAttachment, AdminCertificationAttachmentModel>()
				.ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
				.ForMember(dest => dest.Created, opt => opt.MapFrom(src => src.Created))
				.ForMember(dest => dest.CreatedByUser, opt => opt.MapFrom(src => src.CreatedByUser))
				.ForMember(dest => dest.LastUpdatedByUser, opt => opt.MapFrom(src => src.LastUpdatedByUser));

			CreateMap<AdminCertificationAttachmentModel, AdminCertificationAttachment>()
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

			CreateMap<AddAdminCertificationAttachmentModel, AdminCertificationAttachment>()
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

			CreateMap<UpdateAdminCertificationAttachmentModel, AdminCertificationAttachment>()
				.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

		}
	}
}
