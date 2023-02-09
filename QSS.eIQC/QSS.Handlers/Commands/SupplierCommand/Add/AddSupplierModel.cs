/* Auto Generated Code By AutoCodeGen Jabil © 2019 */


﻿using MediatR;
using QSS.eIQC.Domain.Enums;
using System.Collections.Generic;

namespace QSS.eIQC.Handlers.Commands.SupplierCommand.Add
{
    /// <summary>
    /// Representation model for Add Supplier operation
    /// </summary>
    public class AddSupplierModel : BaseCommand, IRequest<SupplierModel>
    {
        /// <summary>
        /// Get or set SAPSupplierModel_ID property
        /// </summary>        
        public string SAPSupplierModel_ID { get; set; }

        /// <summary>
        /// Get or set SiteCode property
        /// </summary>        
        public string SiteCode { get; set; }

        /// <summary>
        /// Get or set Email property
        /// </summary>        
        public string Email { get; set; }

        /// <summary>
        /// Get or set PhoneNo property
        /// </summary>        
        public string? PhoneNo { get; set; }

        /// <summary>
        /// Get or set FaxNo property
        /// </summary>        
        public string? FaxNo { get; set; }

        /// <summary>
        /// Get or set VendorCode property
        /// </summary>        
        public string VendorCode { get; set; }

        /// <summary>
        /// Get or set VendorName property
        /// </summary>        
        public string VendorName { get; set; }

        /// <summary>
        /// Get or set Address property
        /// </summary>        
        public string? Address { get; set; }

        /// <summary>
        /// Get or set StreetNo property
        /// </summary>        
        public string? StreetNo { get; set; }

        /// <summary>
        /// Get or set City property
        /// </summary>        
        public string? City { get; set; }

        /// <summary>
        /// Get or set PostalCode property
        /// </summary>        
        public string? PostalCode { get; set; }

        /// <summary>
        /// Get or set Country property
        /// </summary>        
        public string? Country { get; set; }

        /// <summary>
        /// Get or set SupplierStatus property
        /// </summary>        
        public string? SupplierStatus { get; set; }

        /// <summary>
        /// Get or set SearchTerm property
        /// </summary>        
        public string? SearchTerm { get; set; }

        /// <summary>
        /// Get or set ChangedOn property
        /// </summary>        
        public string? ChangedOn { get; set; }

        public string SiteName { get; set; }
        public string VendorName2 { get; set; }
        public string VendorName3 { get; set; }
        public string VendorName4 { get; set; }
        public string IcSite { get; set; }
        public string VendorAcctGrp { get; set; }
        public string PurchaseOrg { get; set; }
        public string SalesOrgPoc { get; set; }
        public string CompanyCode { get; set; }
        public string ValuationArea { get; set; }
        public string IcVendorOfPlant { get; set; }
        public string CreatedDate { get; set; }
        public string Region { get; set; }
        public string LandCode { get; set; }

    }
}
