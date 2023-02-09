/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.WorkCellUserCommand.Add;
using QSS.eIQC.Handlers.Commands.WorkCellUserCommand.Update;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.WorkCellUserCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<WorkCellUser, WorkCellUserModel>()
                .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.Site, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.WorkCell, opt =>
                 {
                     opt.ExplicitExpansion();
                 })
                .ForMember(dest => dest.JabilUsers, opt =>
                {
                    opt.MapFrom(src => src.WorkCellJabilUsers.Select(sd => sd.User));

                    opt.ExplicitExpansion();
                })
                .ForMember(dest => dest.DccUsers, opt =>
                {
                    opt.MapFrom(src => src.WorkCellDccUsers.Select(sd => sd.User));
                    opt.ExplicitExpansion();
                });
           
            CreateMap<AddWorkCellUserModel, WorkCellUser>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdateWorkCellUserModel, WorkCellUser>()
               .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

           
        }
    }
}
