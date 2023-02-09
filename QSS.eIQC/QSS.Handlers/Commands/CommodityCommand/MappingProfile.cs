using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.CommodityCommand.Add;
using QSS.eIQC.Handlers.Commands.CommodityCommand.Update;
using QSS.eIQC.SAPHana.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QSS.eIQC.Handlers.Commands.CommodityCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Commodity model
        /// </summary>
        public MappingProfile()
        {

            CreateMap<Commodity, CommodityModel>()
            .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.CommodityCategory, opt =>
            {
                opt.ExplicitExpansion();
            })
            .ForMember(dest => dest.CommodityPartNumberSite, opt =>
            {
                opt.ExplicitExpansion();
            })
 
             .ForMember(dest => dest.Category, opt =>
             {
                 opt.MapFrom(src => src.CommodityCategoryOption.Description);
             });
            CreateMap<CommodityClassification, SAPCommodity>()
             .ForMember(dest => dest.PartNumber, opt =>
             {
                 opt.MapFrom(src => src.PART_NO);
             })
             .ForMember(dest => dest.SiteNo, opt =>
             {
                 opt.MapFrom(src => src.SITE_NO);
             })
            .ForMember(dest => dest.Name, opt =>
            {
                opt.MapFrom(src => src.COMMODITY_NAME);
            })
            .ForMember(dest => dest.Description, opt =>
            {
                opt.MapFrom(src => src.COMMODITY_DESC);
            })
             .ForMember(dest => dest.SAPCommodityId, opt =>
             {
                 opt.MapFrom(src => src.COMMODITY_ID);
             })
            .ForMember(dest => dest.CommodityValidFrom, opt =>
            {
                opt.MapFrom(src => src.VALID_FROM);
            })
            .ForMember(dest => dest.CommodityValidTo, opt =>
            {
                opt.MapFrom(src => src.VALID_TO);
            })
            .ForMember(dest => dest.Status, opt =>
            {
                opt.MapFrom(src => src.STATUS);
            });

            CreateMap<UpdateCommodityModel, Commodity>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));

            CreateMap<AddCommodityModel, Commodity>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? Domain.Enums.StatusType.Active : Domain.Enums.StatusType.Inactive));

            CreateMap<SAPCommodity, Commodity>()
                .ForMember(dest => dest.CommodityValidFrom, opt => opt.MapFrom(src => src.ValidFrom))
                .ForMember(dest => dest.CommodityValidTo, opt => opt.MapFrom(src => src.ValidTo))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.SAPCommodityId, opt => opt.MapFrom(src => src.SAPCommodityId))
                .ForMember(dest => dest.AppearanceInspectionItem, opt => opt.MapFrom(src => src.AppearanceInspectionItem))
                .ForMember(dest => dest.FunctionTestItem, opt => opt.MapFrom(src => src.FunctionTestItem))
                .ForMember(dest => dest.CommodityValidFrom, opt => opt.MapFrom(src => src.CommodityValidFrom))
                .ForMember(dest => dest.CommodityValidTo, opt => opt.MapFrom(src => src.CommodityValidTo));

            CreateMap<SAPCommodityWithoutPart, SAPCommodity>()
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.SAPCommodityId, opt => opt.MapFrom(src => src.SAPCommodityId))
               .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
               .ForMember(dest => dest.CommodityValidFrom, opt => opt.MapFrom(src => src.CommodityValidFrom))
               .ForMember(dest => dest.CommodityValidTo, opt => opt.MapFrom(src => src.CommodityValidTo));

            CreateMap<SAPCommodityPartSite, CommodityPartNumberSite>()
             .ForMember(dest => dest.PartNumber, opt => opt.MapFrom(src => src.PartNumber))
             .ForMember(dest => dest.SiteNo, opt => opt.MapFrom(src => src.SiteNo))
             .ForMember(dest => dest.CommodityId, opt => opt.MapFrom(src => src.CommodityId));

            CreateMap<CommodityModel, CommodityModel>();
        }
    }
}
