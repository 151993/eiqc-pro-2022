using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SiteCommand;
using QSS.eIQC.Handlers.Commands.WorkCellCommand.Add;
using QSS.eIQC.Handlers.Commands.WorkCellCommand.Update;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.WorkCellCommand
{
    /// <summary>
    /// Mapping for WorkCell CRUD Operations
    /// </summary>
    public class MappingProfile: Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base WorkCell models
        /// </summary>
        public MappingProfile()
        {

            CreateMap<WorkCell, WorkCellModel>()
            .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.Sites, opt =>
            {
                opt.MapFrom(src => src.WorkCellSites.Select(sd => sd.Site));
                opt.ExplicitExpansion();
            });

            CreateMap<AddWorkCellModel, WorkCell>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));

            CreateMap<UpdateWorkCellModel, WorkCell>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));

            CreateMap<WorkCellModel, WorkCellModel>();


        }


    }
}
