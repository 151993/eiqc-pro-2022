using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.RoleCommand.Add;
using QSS.eIQC.Handlers.Commands.RoleCommand.Update;
using QSS.eIQC.Handlers.Commands.SupplierVisualInspectionCommand;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.SupplierVisualInspectionDefectTypeCommand
{
    /// <summary>
    /// Mapping for Role CRUD operations
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<SupplierVisualInspectionModel, SupplierVisualInspection>()
                .ForMember(dest => dest.InspectionTools, opt => opt.ExplicitExpansion())
                // .ForMember(dest => dest.PartCountParameter, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierVisualInspectionDefectTypes, opt => opt.ExplicitExpansion());

            CreateMap<SupplierVisualInspection, SupplierVisualInspectionModel>()
                .ForMember(dest => dest.PartCountParameter, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.SupplierVisualInspectionDefectTypes, opt => opt.ExplicitExpansion());

            CreateMap<SupplierVisualInspectionDefectTypeModel, SupplierVisualInspectionDefectType>()
              .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
              .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

        }
    }
}

