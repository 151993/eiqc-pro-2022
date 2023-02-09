using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class CommodityReqChangeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PositionToleranceFrom",
                table: "Commodity");

            migrationBuilder.DropColumn(
                name: "PositionToleranceIncrement",
                table: "Commodity");

            migrationBuilder.DropColumn(
                name: "PositionToleranceTo",
                table: "Commodity");

            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "AdminCertification",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(byte),
                oldType: "smallint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PositionToleranceFrom",
                table: "Commodity",
                type: "numeric",
                maxLength: 50,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PositionToleranceIncrement",
                table: "Commodity",
                type: "numeric",
                maxLength: 50,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PositionToleranceTo",
                table: "Commodity",
                type: "numeric",
                maxLength: 50,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "AdminCertification",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValue: (byte)1);
        }
    }
}
