using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QSS.Common.Utilities.EntityFramework;

namespace QSS.eIQC.Domain.Models.Mappings
{
    public class SupplierMapping : EntityTypeConfigurationWithUpdateUserAuditStatus<Supplier, int>
    {
        public override void Configure(EntityTypeBuilder<Supplier> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("SupplierId");

            builder.Property(p => p.SAPSupplierModel_ID).HasMaxLength(50).IsRequired();
            builder.Property(p => p.SiteCode).HasMaxLength(50);

            builder.Property(p => p.Email).HasMaxLength(250).IsRequired();

            builder.Property(p => p.PhoneNo).HasMaxLength(50);
            builder.Property(p => p.FaxNo).HasMaxLength(50);
            builder.Property(p => p.VendorCode).HasMaxLength(50).IsRequired();
            builder.Property(p => p.VendorName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Address).HasMaxLength(50);
            builder.Property(p => p.StreetNo).HasMaxLength(100);
            builder.Property(p => p.City).HasMaxLength(50);
            builder.Property(p => p.PostalCode).HasMaxLength(50);
            builder.Property(p => p.Country).HasMaxLength(50);
            builder.Property(p => p.SupplierStatus).HasMaxLength(50);
            builder.Property(p => p.SearchTerm).HasMaxLength(50);

            builder.Property(p => p.SiteName).HasMaxLength(30);
            builder.Property(p => p.VendorName2).HasMaxLength(50);
            builder.Property(p => p.VendorName3).HasMaxLength(50);
            builder.Property(p => p.VendorName4).HasMaxLength(50);
            builder.Property(p => p.IcSite).HasMaxLength(10);
            builder.Property(p => p.VendorAcctGrp).HasMaxLength(10);
            builder.Property(p => p.PurchaseOrg).HasMaxLength(10);
            builder.Property(p => p.SalesOrgPoc).HasMaxLength(50);
            builder.Property(p => p.CompanyCode).HasMaxLength(10);
            builder.Property(p => p.ValuationArea).HasMaxLength(10).IsRequired(); 
            builder.Property(p => p.IcVendorOfPlant).HasMaxLength(15);
            builder.Property(p => p.CreatedDate).HasMaxLength(15);
            builder.Property(p => p.Region).HasMaxLength(10);
            builder.Property(p => p.LandCode).HasMaxLength(10);
        }
    }
}
