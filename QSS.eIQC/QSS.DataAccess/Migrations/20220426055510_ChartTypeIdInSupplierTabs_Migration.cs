using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class ChartTypeIdInSupplierTabs_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ChartTypeId",
                table: "SupplierMicrosection",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChartTypeId",
                table: "SupplierFunctionVariable",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ChartTypeId",
                table: "SupplierDimensionMeasurement",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMicrosection_ChartTypeId",
                table: "SupplierMicrosection",
                column: "ChartTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionVariable_ChartTypeId",
                table: "SupplierFunctionVariable",
                column: "ChartTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDimensionMeasurement_ChartTypeId",
                table: "SupplierDimensionMeasurement",
                column: "ChartTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMicrosection_ChartTypeId",
                table: "SupplierDimensionMeasurement",
                column: "ChartTypeId",
                principalTable: "ChartType",
                principalColumn: "ChartTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMicrosection_ChartTypeId",
                table: "SupplierFunctionVariable",
                column: "ChartTypeId",
                principalTable: "ChartType",
                principalColumn: "ChartTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMicrosection_ChartTypeId",
                table: "SupplierMicrosection",
                column: "ChartTypeId",
                principalTable: "ChartType",
                principalColumn: "ChartTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMicrosection_ChartTypeId",
                table: "SupplierDimensionMeasurement");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMicrosection_ChartTypeId",
                table: "SupplierFunctionVariable");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMicrosection_ChartTypeId",
                table: "SupplierMicrosection");

            migrationBuilder.DropIndex(
                name: "IX_SupplierMicrosection_ChartTypeId",
                table: "SupplierMicrosection");

            migrationBuilder.DropIndex(
                name: "IX_SupplierFunctionVariable_ChartTypeId",
                table: "SupplierFunctionVariable");

            migrationBuilder.DropIndex(
                name: "IX_SupplierDimensionMeasurement_ChartTypeId",
                table: "SupplierDimensionMeasurement");

            migrationBuilder.DropColumn(
                name: "ChartTypeId",
                table: "SupplierMicrosection");

            migrationBuilder.DropColumn(
                name: "ChartTypeId",
                table: "SupplierFunctionVariable");

            migrationBuilder.DropColumn(
                name: "ChartTypeId",
                table: "SupplierDimensionMeasurement");
        }
    }
}
