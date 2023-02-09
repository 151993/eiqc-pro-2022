using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class Parameter_PT_PC_code_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParameterManagement_PCCode_PCCodeId",
                table: "ParameterManagement");

            migrationBuilder.DropForeignKey(
                name: "FK_ParameterManagement_ParameterManagementType_ParameterManage~",
                table: "ParameterManagement");

            migrationBuilder.DropIndex(
                name: "IX_ParameterManagement_PCCodeId",
                table: "ParameterManagement");

            migrationBuilder.DropIndex(
                name: "IX_ParameterManagement_ParameterManagementTypeId",
                table: "ParameterManagement");

            migrationBuilder.DropColumn(
                name: "PCCodeId",
                table: "ParameterManagement");

            migrationBuilder.DropColumn(
                name: "ParameterManagementTypeId",
                table: "ParameterManagement");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ParameterTypeCode",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParameterTypeCodeId",
                table: "ParameterManagement",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ParameterManagement_ParameterTypeCodeId",
                table: "ParameterManagement",
                column: "ParameterTypeCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParameterManagement_ParameterTypeCode_ParameterTypeCodeId",
                table: "ParameterManagement",
                column: "ParameterTypeCodeId",
                principalTable: "ParameterTypeCode",
                principalColumn: "ParameterTypeCodeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ParameterManagement_ParameterTypeCode_ParameterTypeCodeId",
                table: "ParameterManagement");

            migrationBuilder.DropIndex(
                name: "IX_ParameterManagement_ParameterTypeCodeId",
                table: "ParameterManagement");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ParameterTypeCode");

            migrationBuilder.DropColumn(
                name: "ParameterTypeCodeId",
                table: "ParameterManagement");

            migrationBuilder.AddColumn<int>(
                name: "PCCodeId",
                table: "ParameterManagement",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParameterManagementTypeId",
                table: "ParameterManagement",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ParameterManagement_PCCodeId",
                table: "ParameterManagement",
                column: "PCCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterManagement_ParameterManagementTypeId",
                table: "ParameterManagement",
                column: "ParameterManagementTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ParameterManagement_PCCode_PCCodeId",
                table: "ParameterManagement",
                column: "PCCodeId",
                principalTable: "PCCode",
                principalColumn: "PCCodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParameterManagement_ParameterManagementType_ParameterManage~",
                table: "ParameterManagement",
                column: "ParameterManagementTypeId",
                principalTable: "ParameterManagementType",
                principalColumn: "ParameterManagementTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
