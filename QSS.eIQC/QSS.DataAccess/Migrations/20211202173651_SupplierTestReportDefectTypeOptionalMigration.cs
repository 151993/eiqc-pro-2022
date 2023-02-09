using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierTestReportDefectTypeOptionalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierTestReport_DefectType_DefectTypeId",
                table: "SupplierTestReport");

            migrationBuilder.AlterColumn<string>(
                name: "InspectionDetails",
                table: "SupplierTestReport",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DefectTypeId",
                table: "SupplierTestReport",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierTestReport_DefectType_DefectTypeId",
                table: "SupplierTestReport",
                column: "DefectTypeId",
                principalTable: "DefectType",
                principalColumn: "DefectTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierTestReport_DefectType_DefectTypeId",
                table: "SupplierTestReport");

            migrationBuilder.AlterColumn<string>(
                name: "InspectionDetails",
                table: "SupplierTestReport",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DefectTypeId",
                table: "SupplierTestReport",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierTestReport_DefectType_DefectTypeId",
                table: "SupplierTestReport",
                column: "DefectTypeId",
                principalTable: "DefectType",
                principalColumn: "DefectTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
