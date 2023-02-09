using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class cps_chart_function_variable_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CalculationPoint",
                table: "PartFunParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChartTypeId",
                table: "PartFunParameter",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartFunParameter_ChartTypeId",
                table: "PartFunParameter",
                column: "ChartTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PartFunParameter_ChartTypeId",
                table: "PartFunParameter",
                column: "ChartTypeId",
                principalTable: "ChartType",
                principalColumn: "ChartTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartFunParameter_ChartTypeId",
                table: "PartFunParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartFunParameter_ChartTypeId",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "CalculationPoint",
                table: "PartFunParameter");

            migrationBuilder.DropColumn(
                name: "ChartTypeId",
                table: "PartFunParameter");
        }
    }
}
