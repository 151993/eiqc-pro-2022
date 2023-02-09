using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SPC_ChartType_Dimensonal_Measurment_Migraton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CalculationPoint",
                table: "PartMeasurementParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChartTypeId",
                table: "PartMeasurementParameter",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartMeasurementParameter_ChartTypeId",
                table: "PartMeasurementParameter",
                column: "ChartTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PartMeasurementParameters_ChartTypeId",
                table: "PartMeasurementParameter",
                column: "ChartTypeId",
                principalTable: "ChartType",
                principalColumn: "ChartTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartMeasurementParameters_ChartTypeId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartMeasurementParameter_ChartTypeId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "CalculationPoint",
                table: "PartMeasurementParameter");

            migrationBuilder.DropColumn(
                name: "ChartTypeId",
                table: "PartMeasurementParameter");
        }
    }
}
