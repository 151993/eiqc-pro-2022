using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class PurchaseOrderAdditionalFieldsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyCode",
                table: "PurchaseOrder",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeliveryComplete",
                table: "PurchaseOrder",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PurchaseGroup",
                table: "PurchaseOrder",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PurchaseOrg",
                table: "PurchaseOrder",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyCode",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "DeliveryComplete",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "PurchaseGroup",
                table: "PurchaseOrder");

            migrationBuilder.DropColumn(
                name: "PurchaseOrg",
                table: "PurchaseOrder");
        }
    }
}
