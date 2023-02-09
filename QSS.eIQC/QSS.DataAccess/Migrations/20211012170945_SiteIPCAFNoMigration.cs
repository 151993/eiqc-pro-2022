using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SiteIPCAFNoMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CAFNo",
                table: "SAPPartInspectionPlan",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SiteIP",
                table: "SAPPartInspectionPlan",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SiteIPSerialNumber",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SiteIPVersion",
                table: "SAPPartInspectionPlan",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CAFNo",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SiteIP",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SiteIPSerialNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SiteIPVersion",
                table: "SAPPartInspectionPlan");
        }
    }
}
