using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SMSSapBasedPassFailFields_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResultPassFailId",
                table: "SupplierSapBasedParameter");

            migrationBuilder.AddColumn<string>(
                name: "MaskedMPN",
                table: "SupplierMeasurementSubmission",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MediaCode",
                table: "SupplierMeasurementSubmission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SapBasedResultPassFailId",
                table: "SupplierMeasurementSubmission",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaskedMPN",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MediaCode",
                table: "SAPPartInspectionPlan",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaskedMPN",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "MediaCode",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "SapBasedResultPassFailId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "MaskedMPN",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "MediaCode",
                table: "SAPPartInspectionPlan");

            migrationBuilder.AddColumn<int>(
                name: "ResultPassFailId",
                table: "SupplierSapBasedParameter",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
