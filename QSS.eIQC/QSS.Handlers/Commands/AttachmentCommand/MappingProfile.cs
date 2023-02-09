using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.AttachmentCommand.Add;
using QSS.eIQC.Handlers.Common;

namespace QSS.eIQC.Handlers.Commands.AttachmentCommand
{

	/// <summary>
	/// Mapping for Attachment CRUD operations
	/// </summary>
	public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Attachment models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Attachment, AttachmentModel>()
                .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<AttachmentModel, Attachment>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<AddAttachmentModel, Attachment>()
	            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));
        }
    }
}
