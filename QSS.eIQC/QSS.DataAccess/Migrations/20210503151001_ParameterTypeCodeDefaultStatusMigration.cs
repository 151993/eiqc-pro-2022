using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class ParameterTypeCodeDefaultStatusMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "ParameterTypePcCode",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "ParameterTypeCode",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(byte),
                oldType: "smallint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "ParameterTypePcCode",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValue: (byte)1);

            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "ParameterTypeCode",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValue: (byte)1);
        }
    }
}
