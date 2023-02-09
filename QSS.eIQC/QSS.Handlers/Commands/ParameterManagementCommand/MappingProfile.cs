/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.EnumModels;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand.Add;
using QSS.eIQC.Handlers.Commands.ParameterManagementCommand.Update;
using QSS.eIQC.Handlers.Commands.PCCodeCommand;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.ParameterManagementCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<ParameterManagement, ParameterManagementModel>()
                .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))

                .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.Commodities, opt => opt.ExplicitExpansion())
                .ForMember(dest => dest.ParameterTypeCode, opt => opt.ExplicitExpansion())
                 .ForMember(dest => dest.ParameterManagementTypeId, opt =>
                 {
                     opt.MapFrom(src => src.ParameterTypeCode.ParameterManagementTypeId);
                 })
                .ForMember(dest => dest.Commodities, opt =>
                 {
                    opt.MapFrom(src => src.ParameterManagementCommodity.Select(sd => sd.Commodity));
                    opt.ExplicitExpansion();
                 });


            CreateMap<AddParameterManagementModel, ParameterManagement>()
               .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));


            CreateMap<UpdateParameterManagementModel, ParameterManagement>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<ParameterManagement, PCCodeModel>()
                .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active));


            CreateMap<ParameterManagementTypeModel, QSS.eIQC.Handlers.Commands.ParameterManagementTypeCommand.ParameterManagementTypeModel>();
            CreateMap<ParameterManagementCommodity, ParameterManagementModel>();


        }
    }
}
