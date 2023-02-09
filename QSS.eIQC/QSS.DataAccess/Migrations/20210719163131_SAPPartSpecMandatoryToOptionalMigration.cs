using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SAPPartSpecMandatoryToOptionalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartInspectionBowTwistParameter_DataType_DataTypeId",
                table: "PartInspectionBowTwistParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartInspectionBowTwistParameter_DataTypeId",
                table: "PartInspectionBowTwistParameter");

            migrationBuilder.DropColumn(
                name: "DataTypeId",
                table: "PartInspectionBowTwistParameter");

            migrationBuilder.AlterColumn<string>(
                name: "SpecNumber",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SpecDescription",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "DataTypeId",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataTypeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.AlterColumn<string>(
                name: "SpecNumber",
                table: "SAPPartInspectionPlan",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpecDescription",
                table: "SAPPartInspectionPlan",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataTypeId",
                table: "PartInspectionBowTwistParameter",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionBowTwistParameter_DataTypeId",
                table: "PartInspectionBowTwistParameter",
                column: "DataTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PartInspectionBowTwistParameter_DataType_DataTypeId",
                table: "PartInspectionBowTwistParameter",
                column: "DataTypeId",
                principalTable: "DataType",
                principalColumn: "DataTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
