using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class smsAutoGenerateNoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SMSNo",
                table: "SupplierMeasurementSubmission",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SMSSerialNumber",
                table: "SupplierMeasurementSubmission",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SMSNo",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "SMSSerialNumber",
                table: "SupplierMeasurementSubmission");
        }
    }
}
