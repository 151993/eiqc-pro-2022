using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class AddSMSRemoveIPResultColumnTestReport_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "PartTestReportParameter");

            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "SupplierTestReport",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "ResultDescription",
                table: "SupplierMeasurementSubmission",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "SupplierTestReport");

            migrationBuilder.AlterColumn<string>(
                name: "ResultDescription",
                table: "SupplierMeasurementSubmission",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "PartTestReportParameter",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
