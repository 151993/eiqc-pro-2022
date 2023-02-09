using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class IPSerialAndIPVersion_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IP",
                table: "SAPPartInspectionPlan",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "IPSerialNumber",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IPVersion",
                table: "SAPPartInspectionPlan",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IPSerialNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "IPVersion",
                table: "SAPPartInspectionPlan");

            migrationBuilder.AlterColumn<string>(
                name: "IP",
                table: "SAPPartInspectionPlan",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);
        }
    }
}
