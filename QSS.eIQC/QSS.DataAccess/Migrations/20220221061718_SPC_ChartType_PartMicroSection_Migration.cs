using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SPC_ChartType_PartMicroSection_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CalculationPoint",
                table: "PartMicrosection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChartTypeId",
                table: "PartMicrosection",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ChartType",
                columns: table => new
                {
                    ChartTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChartType", x => x.ChartTypeId);
                });

            migrationBuilder.InsertData(
                table: "ChartType",
                columns: new[] { "ChartTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Individual Control Chart", "IndividualControlChart" },
                    { 2, "Range Control Chart", "RangeControlChart" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartMicrosection_ChartTypeId",
                table: "PartMicrosection",
                column: "ChartTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PartMicrosection_ChartTypeId",
                table: "PartMicrosection",
                column: "ChartTypeId",
                principalTable: "ChartType",
                principalColumn: "ChartTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartMicrosection_ChartTypeId",
                table: "PartMicrosection");

            migrationBuilder.DropTable(
                name: "ChartType");

            migrationBuilder.DropIndex(
                name: "IX_PartMicrosection_ChartTypeId",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "CalculationPoint",
                table: "PartMicrosection");

            migrationBuilder.DropColumn(
                name: "ChartTypeId",
                table: "PartMicrosection");
        }
    }
}
