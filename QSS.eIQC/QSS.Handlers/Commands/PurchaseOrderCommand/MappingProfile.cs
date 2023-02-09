using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.SAPHana.Services.Models;

namespace QSS.eIQC.Handlers.Commands.PurchaseOrderCommand
{
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base PurchaseOrder model
        /// </summary>
        public MappingProfile()
        {

            CreateMap<PurchaseOrder, PurchaseOrderModel>()
            .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
            .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
            .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<SAPPurchaseOrderModel, PurchaseOrder>()
              .ForMember(dest => dest.SAPPurchaseOrderId, opt => opt.MapFrom(src => src.PurchaseOrderId))
              .ForMember(dest => dest.Site, opt => opt.MapFrom(src => src.SITE))
              .ForMember(dest => dest.PartNo, opt => opt.MapFrom(src => src.PART_NO))
              .ForMember(dest => dest.MPNMaterial, opt => opt.MapFrom(src => src.MPN_MATERIAL))
              .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CREATED_DATE))
              .ForMember(dest => dest.PurchaseOrderNo, opt => opt.MapFrom(src => src.PO_NO))
              .ForMember(dest => dest.PurchaseOrderLineNo, opt => opt.MapFrom(src => src.PO_LINE_NO))
              .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.QUANTITY))
              .ForMember(dest => dest.VendorCode, opt => opt.MapFrom(src => src.VENDOR_CODE))
              .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.MANUFACTURER))
              .ForMember(dest => dest.ManufacturerPartNo, opt => opt.MapFrom(src => src.MANUF_PART_NO))
              .ForMember(dest => dest.PurchaseOrderStatus, opt => opt.MapFrom(src => src.PO_STATUS))
              .ForMember(dest => dest.Deleted, opt => opt.MapFrom(src => src.DELETED))
              .ForMember(dest => dest.QuantityDelivered, opt => opt.MapFrom(src => src.QTY_DELIVERED))
              .ForMember(dest => dest.LastModifiedDate, opt => opt.MapFrom(src => src.LAST_MODIFIED_DATE))
              .ForMember(dest => dest.PurchaseOrg, opt => opt.MapFrom(src => src.PURCHASE_ORG))
              .ForMember(dest => dest.PurchaseGroup, opt => opt.MapFrom(src => src.PURCHASE_GROUP))
              .ForMember(dest => dest.CompanyCode, opt => opt.MapFrom(src => src.COMPANY_CODE))
              .ForMember(dest => dest.DeliveryComplete, opt => opt.MapFrom(src => src.DELIVERY_COMPLETE));




            CreateMap<SAPPurchaseOrderModel, PurchaseOrderModel>()
                .ForMember(dest => dest.SAPPurchaseOrderId, opt => opt.MapFrom(src => src.PurchaseOrderId))
                .ForMember(dest => dest.Site, opt => opt.MapFrom(src => src.SITE))
                .ForMember(dest => dest.PartNo, opt => opt.MapFrom(src => src.PART_NO))
                .ForMember(dest => dest.MPNMaterial, opt => opt.MapFrom(src => src.MPN_MATERIAL))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CREATED_DATE))
                .ForMember(dest => dest.PurchaseOrderNo, opt => opt.MapFrom(src => src.PO_NO))
                .ForMember(dest => dest.PurchaseOrderLineNo, opt => opt.MapFrom(src => src.PO_LINE_NO))
                .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.QUANTITY))
                .ForMember(dest => dest.VendorCode, opt => opt.MapFrom(src => src.VENDOR_CODE))
                .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.MANUFACTURER))
                .ForMember(dest => dest.ManufacturerPartNo, opt => opt.MapFrom(src => src.MANUF_PART_NO))
                .ForMember(dest => dest.PurchaseOrderStatus, opt => opt.MapFrom(src => src.PO_STATUS))
                .ForMember(dest => dest.Deleted, opt => opt.MapFrom(src => src.DELETED))
                .ForMember(dest => dest.QuantityDelivered, opt => opt.MapFrom(src => src.QTY_DELIVERED))
                .ForMember(dest => dest.LAST_MODIFIED_DATE, opt => opt.MapFrom(src => src.LAST_MODIFIED_DATE))
                .ForMember(dest => dest.PurchaseOrg, opt => opt.MapFrom(src => src.PURCHASE_ORG))
                .ForMember(dest => dest.PurchaseGroup, opt => opt.MapFrom(src => src.PURCHASE_GROUP))
                .ForMember(dest => dest.CompanyCode, opt => opt.MapFrom(src => src.COMPANY_CODE))
                .ForMember(dest => dest.DeliveryComplete, opt => opt.MapFrom(src => src.DELIVERY_COMPLETE));
        }
    }
}
