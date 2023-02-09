using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SMS_PackingInspection_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PackagingQuantity",
                table: "SupplierMeasurementSubmission",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ResultDescription",
                table: "SupplierMeasurementSubmission",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "SupplierMeasurementSubmission",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PackagingQuantity",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "ResultDescription",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "SupplierMeasurementSubmission");
        }
    }
}
