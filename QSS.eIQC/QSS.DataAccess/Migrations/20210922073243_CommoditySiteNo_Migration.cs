using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class CommoditySiteNo_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SAPCommodityId",
                table: "Commodity",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 5);

            migrationBuilder.AlterColumn<string>(
                name: "FunctionTestItem",
                table: "Commodity",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AppearanceInspectionItem",
                table: "Commodity",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "SiteNo",
                table: "Commodity",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SiteNo",
                table: "Commodity");

            migrationBuilder.AlterColumn<int>(
                name: "SAPCommodityId",
                table: "Commodity",
                type: "integer",
                maxLength: 5,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FunctionTestItem",
                table: "Commodity",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AppearanceInspectionItem",
                table: "Commodity",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 256,
                oldNullable: true);
        }
    }
}
