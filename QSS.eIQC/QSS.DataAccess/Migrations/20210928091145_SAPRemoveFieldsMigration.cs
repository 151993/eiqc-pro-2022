using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SAPRemoveFieldsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManufacturerRevisionPartNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "PartRevisionNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "SAPPartInspectionPlan",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "SAPPartInspectionPlan");

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerRevisionPartNumber",
                table: "SAPPartInspectionPlan",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartRevisionNumber",
                table: "SAPPartInspectionPlan",
                type: "text",
                nullable: true);
        }
    }
}
