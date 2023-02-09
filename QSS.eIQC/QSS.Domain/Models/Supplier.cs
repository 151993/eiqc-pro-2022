using System.Collections.Generic;

namespace QSS.eIQC.Domain.Models
{
    public class Supplier : PersistentObjectWithUpdateAuditLogStatus<int>
    {
        public Supplier()
        {
            User = new HashSet<User>();
            SAPPartInspectionPlan = new HashSet<SAPPartInspectionPlan>();
            SupplierMeasurementSubmission = new HashSet<SupplierMeasurementSubmission>();
        }

        
        //[AuditLog]
        public string SAPSupplierModel_ID { get; set; }

        //[AuditLog]
        public string SiteCode { get; set; }

        //[AuditLog]
        //[Unique]
        public string Email { get; set; }

        //[AuditLog]
        public string PhoneNo { get; set; }

        //[AuditLog]
        public string FaxNo { get; set; }

        //[AuditLog]
        public string VendorCode { get; set; }

        //[AuditLog]
        public string VendorName { get; set; }

        //[AuditLog]
        public string Address { get; set; }

        //[AuditLog]
        public string StreetNo { get; set; }

        //[AuditLog]
        public string City { get; set; }

        //[AuditLog]
        public string PostalCode { get; set; }

        //[AuditLog]
        public string Country { get; set; }

        //[AuditLog]
        public string SupplierStatus { get; set; }

        //[AuditLog]
        public string SearchTerm { get; set; }

        //[AuditLog]
        public string ChangedOn { get; set; }
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
        public virtual ICollection<User> User { get; set; }

        public virtual ICollection<SAPPartInspectionPlan> SAPPartInspectionPlan { get; set; }

        public virtual ICollection<SupplierMeasurementSubmission> SupplierMeasurementSubmission { get; set; }
    }
}
