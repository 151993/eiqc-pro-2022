using AutoMapper;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.EmailTemplateCommand.Update;

namespace QSS.eIQC.Handlers.Commands.EmailTemplateCommand
{
    /// <summary>
    /// Mapping for EmailTemplate CRUD operations
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base EmailTemplate models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<EmailTemplate, EmailTemplateModel>()
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<UpdateEmailTemplateModel, EmailTemplate>();
        }
    }
}