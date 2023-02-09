using AutoMapper;
using QSS.Models;
using QSS.eIQC.Domain;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Domain.Enums;

namespace QSS.eIQC.Handlers.Commands
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AuditLog, AuditLogModel>()
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<AuditData, AuditDataModel>();

            CreateMap<AuditMetadata, AuditMetadataModel>();

            CreateMap<AuditLogData, AuditLogDataModel>();

            CreateMap<AuditMetadataEntity, AuditMetadataEntityModel>();

            CreateMap<AuditLogModifiedField, AuditLogModifiedFieldModel>();
        }
    }
}
