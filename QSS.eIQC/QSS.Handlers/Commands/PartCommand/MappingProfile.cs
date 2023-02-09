/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.PartCommand.Add;
using QSS.eIQC.Handlers.Commands.PartCommand.Update;
using QSS.eIQC.SAPHana.Services.Models;
using System;
using System.Linq;

namespace QSS.eIQC.Handlers.Commands.PartCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base Role models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Part, PartModel>()
                 .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
                 .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
                 .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<AddPartModel, Part>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdatePartModel, Part>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));


            //CreateMap<SAPPartModel, Part>()
            //    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive))
            //    .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            //    .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion())
            //.ForMember(dest => dest.PartManufacturePartNumbers, opt =>
            // {
            //     opt.MapFrom(src => src.PartManufacturePartNumbers);
            //     opt.ExplicitExpansion();
            // });

            CreateMap<PartNumberBySiteModel, SAPPartModel>()
               .ForMember(dest => dest.PartNo, opt =>
               {
                   opt.MapFrom(src => src.JABIL_PART_NO);
               })
               .ForMember(dest => dest.PartDescription, opt =>
               {
                   opt.MapFrom(src => src.MATERIAL_DESC);
               })
               .ForMember(dest => dest.Site, opt =>
               {
                   opt.MapFrom(src => src.SITE);
               })
               .ForMember(dest => dest.ManufacturerPartNumber, opt =>
               {
                   opt.MapFrom(src => src.MANUF_PART_NO);
               })
              .ForMember(dest => dest.MPNMaterialHers, opt =>
               {
                   opt.MapFrom(src => src.MPN_MTRL_HERS);
               })
               .ForMember(dest => dest.Manufacturer, opt =>
               {
                   opt.MapFrom(src => src.MANUFACTURER);
               })
               .ForMember(dest => dest.PartValidFrom, opt =>
               {
                   opt.MapFrom(src => src.PART_VALID_FROM);
               })
               .ForMember(dest => dest.PartValidTo, opt =>
               {
                   opt.MapFrom(src => src.PART_VALID_TO);
               })
               .ForMember(dest => dest.MediaCode, opt =>
               {
                   opt.MapFrom(src => src.MEDIACODE);
               })
               .ForMember(dest => dest.ManufacturerPartNumber, opt =>
               {
                   opt.MapFrom(src => src.MANUF_PART_NO);
               })
               .ForMember(dest => dest.MaskedMPN, opt =>
               {
                   opt.MapFrom(src => src.MASKED_MPN);
               }).ForMember(dest => dest.PartDescription, opt =>
               {
                   opt.MapFrom(src => src.MATERIAL_DESC);
               })
               .ForMember(dest => dest.JabilOwnerContact, opt =>
               {
                   opt.MapFrom(src => src.JABIL_OWNER_CONTACT);
               })
               .ForMember(dest => dest.MaterialGroup, opt =>
               {
                   opt.MapFrom(src => src.MATERIAL_GROUP);
               })
               .ForMember(dest => dest.IsEnabled, opt =>
               {
                   opt.MapFrom(src => Convert.ToDateTime(src.PART_VALID_TO) > DateTime.Now ? true : false );
               })
               .ForMember(dest => dest.Commodity, opt =>
               {
                   opt.MapFrom(src => src.JABIL_PART_NO );
               });

        }
    }
}
