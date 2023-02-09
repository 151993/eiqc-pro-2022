/* Auto Generated Code By AutoCodeGen Jabil © 2019 */
using AutoMapper;
using QSS.eIQC.Domain.Enums;
using QSS.eIQC.Domain.Models;
using QSS.eIQC.Handlers.Commands.SupplierCommand.Add;
using QSS.eIQC.Handlers.Commands.SupplierCommand.Update;
using QSS.eIQC.SAPHana.Services.Models;
namespace QSS.eIQC.Handlers.Commands.SupplierCommand
{
    /// <summary>
    /// Mapping for Supplier CRUD operations
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// Bootstraps the mapping of base SiteSme models
        /// </summary>
        public MappingProfile()
        {
            CreateMap<Supplier, SupplierModel>()
           .ForMember(dest => dest.IsEnabled, opt => opt.MapFrom(src => src.Status == StatusType.Active))
           .ForMember(dest => dest.CreatedByUser, opt => opt.ExplicitExpansion())
           .ForMember(dest => dest.LastUpdatedByUser, opt => opt.ExplicitExpansion());

            CreateMap<AddSupplierModel, Supplier>()
               .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<UpdateSupplierModel, Supplier>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.IsEnabled ? StatusType.Active : StatusType.Inactive));

            CreateMap<SAPSupplierModel, Supplier>()
                .ForMember(dest => dest.SAPSupplierModel_ID, opt => opt.MapFrom(src => src.SAPSupplierModel_ID))
                .ForMember(dest => dest.SiteCode, opt => opt.MapFrom(src => src.SITE_CODE))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.EMAIL))
                .ForMember(dest => dest.PhoneNo, opt => opt.MapFrom(src => src.PHONE_NO))
                .ForMember(dest => dest.FaxNo, opt => opt.MapFrom(src => src.FAX_NO))
                .ForMember(dest => dest.VendorCode, opt => opt.MapFrom(src => src.VENDOR_CODE))
                .ForMember(dest => dest.VendorName, opt => opt.MapFrom(src => src.VENDOR_NAME))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.ADDRESS_NO))
                .ForMember(dest => dest.StreetNo, opt => opt.MapFrom(src => src.STREET_NO))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.CITY))
                .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.POSTAL_CODE))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.COUNTRY))
                .ForMember(dest => dest.SupplierStatus, opt => opt.MapFrom(src => src.SUPPLIER_STATUS))
                .ForMember(dest => dest.SearchTerm, opt => opt.MapFrom(src => src.SEARCH_TERM))
                .ForMember(dest => dest.ChangedOn, opt => opt.MapFrom(src => src.CHANGED_ON))
                .ForMember(dest => dest.SiteName, opt => opt.MapFrom(src => src.SITE_NAME))
                .ForMember(dest => dest.VendorName2, opt => opt.MapFrom(src => src.VENDOR_NAME2))
                .ForMember(dest => dest.VendorName3, opt => opt.MapFrom(src => src.VENDOR_NAME3))
                .ForMember(dest => dest.VendorName4, opt => opt.MapFrom(src => src.VENDOR_NAME4))
                .ForMember(dest => dest.IcSite, opt => opt.MapFrom(src => src.IC_SITE))
                .ForMember(dest => dest.VendorAcctGrp, opt => opt.MapFrom(src => src.VENDOR_ACCT_GRP))
                .ForMember(dest => dest.PurchaseOrg, opt => opt.MapFrom(src => src.PURCHASE_ORG))
                .ForMember(dest => dest.SalesOrgPoc, opt => opt.MapFrom(src => src.SALES_ORG_POC))
                .ForMember(dest => dest.CompanyCode, opt => opt.MapFrom(src => src.COMPANY_CODE))
                .ForMember(dest => dest.ValuationArea, opt => opt.MapFrom(src => src.VALUATION_AREA))
                .ForMember(dest => dest.IcVendorOfPlant, opt => opt.MapFrom(src => src.IC_VENDOR_OF_PLANT))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CREATED_DATE))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.REGION))
                .ForMember(dest => dest.LandCode, opt => opt.MapFrom(src => src.LAND_CODE));

            CreateMap<SAPSupplierModel, SupplierModel>()
               .ForMember(dest => dest.SAPSupplierModel_ID, opt => opt.MapFrom(src => src.SAPSupplierModel_ID))
               .ForMember(dest => dest.SiteCode, opt => opt.MapFrom(src => src.SITE_CODE))
               .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.EMAIL))
               .ForMember(dest => dest.PhoneNo, opt => opt.MapFrom(src => src.PHONE_NO))
               .ForMember(dest => dest.FaxNo, opt => opt.MapFrom(src => src.FAX_NO))
               .ForMember(dest => dest.VendorCode, opt => opt.MapFrom(src => src.VENDOR_CODE))
               .ForMember(dest => dest.VendorName, opt => opt.MapFrom(src => src.VENDOR_NAME))
               .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.ADDRESS_NO))
               .ForMember(dest => dest.StreetNo, opt => opt.MapFrom(src => src.STREET_NO))
               .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.CITY))
               .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.POSTAL_CODE))
               .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.COUNTRY))
               .ForMember(dest => dest.SupplierStatus, opt => opt.MapFrom(src => src.SUPPLIER_STATUS))
               .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.SUPPLIER_STATUS))
               .ForMember(dest => dest.SearchTerm, opt => opt.MapFrom(src => src.SEARCH_TERM))
               .ForMember(dest => dest.SupplierStatus, opt => opt.MapFrom(src => src.SUPPLIER_STATUS))
               .ForMember(dest => dest.SITE_CODE, opt => opt.MapFrom(src => src.SITE_CODE))
               .ForMember(dest => dest.ChangedOn, opt => opt.MapFrom(src => src.CHANGED_ON))
               .ForMember(dest => dest.SiteName, opt => opt.MapFrom(src => src.SITE_NAME))
                .ForMember(dest => dest.VendorName2, opt => opt.MapFrom(src => src.VENDOR_NAME2))
                .ForMember(dest => dest.VendorName3, opt => opt.MapFrom(src => src.VENDOR_NAME3))
                .ForMember(dest => dest.VendorName4, opt => opt.MapFrom(src => src.VENDOR_NAME4))
                .ForMember(dest => dest.IcSite, opt => opt.MapFrom(src => src.IC_SITE))
                .ForMember(dest => dest.VendorAcctGrp, opt => opt.MapFrom(src => src.VENDOR_ACCT_GRP))
                .ForMember(dest => dest.PurchaseOrg, opt => opt.MapFrom(src => src.PURCHASE_ORG))
                .ForMember(dest => dest.SalesOrgPoc, opt => opt.MapFrom(src => src.SALES_ORG_POC))
                .ForMember(dest => dest.CompanyCode, opt => opt.MapFrom(src => src.COMPANY_CODE))
                .ForMember(dest => dest.ValuationArea, opt => opt.MapFrom(src => src.VALUATION_AREA))
                .ForMember(dest => dest.IcVendorOfPlant, opt => opt.MapFrom(src => src.IC_VENDOR_OF_PLANT))
                .ForMember(dest => dest.CreatedDate, opt => opt.MapFrom(src => src.CREATED_DATE))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.REGION))
                .ForMember(dest => dest.LandCode, opt => opt.MapFrom(src => src.LAND_CODE))
                .ForMember(dest => dest.VALUATION_AREA, opt => opt.MapFrom(src => src.VALUATION_AREA));

        }

    }
}
