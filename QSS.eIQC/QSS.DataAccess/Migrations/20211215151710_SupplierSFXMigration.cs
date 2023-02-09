using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierSFXMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyCode",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedDate",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcSite",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcVendorOfPlant",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LandCode",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PurchaseOrg",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SalesOrgPoc",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SiteName",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ValuationArea",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VendorAcctGrp",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VendorName2",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VendorName3",
                table: "Supplier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VendorName4",
                table: "Supplier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyCode",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "IcSite",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "IcVendorOfPlant",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "LandCode",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "PurchaseOrg",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "SalesOrgPoc",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "SiteName",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "ValuationArea",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "VendorAcctGrp",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "VendorName2",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "VendorName3",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "VendorName4",
                table: "Supplier");
        }
    }
}
