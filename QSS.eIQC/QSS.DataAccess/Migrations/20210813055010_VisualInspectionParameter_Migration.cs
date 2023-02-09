using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class VisualInspectionParameter_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartCountParameter_InspectionToolsType_InspectionToolsTypeId",
                table: "PartCountParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartCountParameter_PartNo",
                table: "PartCountParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartCountParameter_PartNo",
                table: "PartCountParameter");

            migrationBuilder.DropColumn(
                name: "FailedQTYExpected",
                table: "PartCountParameter");

            migrationBuilder.DropColumn(
                name: "ParameterName",
                table: "PartCountParameter");

            migrationBuilder.DropColumn(
                name: "PartNo",
                table: "PartCountParameter");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "PartCountParameter");

            migrationBuilder.AlterColumn<int>(
                name: "InspectionToolsTypeId",
                table: "PartCountParameter",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailsDefine",
                table: "PartCountParameter",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "PartCountParameter",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "PartCountParameter",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ParameterManagementId",
                table: "PartCountParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SAPPartInspectionPlanId",
                table: "PartCountParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PartCountParameter_ParameterManagementId",
                table: "PartCountParameter",
                column: "ParameterManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_PartCountParameter_SAPPartInspectionPlanId",
                table: "PartCountParameter",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_PartCountParameter_InspectionToolsTypeId",
                table: "PartCountParameter",
                column: "InspectionToolsTypeId",
                principalTable: "InspectionToolsType",
                principalColumn: "InspectionToolsTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartCountParameter_ParameterManagementId",
                table: "PartCountParameter",
                column: "ParameterManagementId",
                principalTable: "ParameterManagement",
                principalColumn: "ParameterManagementId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartCountParameter_SAPPartInspectionPlanId",
                table: "PartCountParameter",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartCountParameter_InspectionToolsTypeId",
                table: "PartCountParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartCountParameter_ParameterManagementId",
                table: "PartCountParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartCountParameter_SAPPartInspectionPlanId",
                table: "PartCountParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartCountParameter_ParameterManagementId",
                table: "PartCountParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartCountParameter_SAPPartInspectionPlanId",
                table: "PartCountParameter");

            migrationBuilder.DropColumn(
                name: "DetailsDefine",
                table: "PartCountParameter");

            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "PartCountParameter");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "PartCountParameter");

            migrationBuilder.DropColumn(
                name: "ParameterManagementId",
                table: "PartCountParameter");

            migrationBuilder.DropColumn(
                name: "SAPPartInspectionPlanId",
                table: "PartCountParameter");

            migrationBuilder.AlterColumn<int>(
                name: "InspectionToolsTypeId",
                table: "PartCountParameter",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "FailedQTYExpected",
                table: "PartCountParameter",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ParameterName",
                table: "PartCountParameter",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PartNo",
                table: "PartCountParameter",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "PartCountParameter",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartCountParameter_PartNo",
                table: "PartCountParameter",
                column: "PartNo");

            migrationBuilder.AddForeignKey(
                name: "FK_PartCountParameter_InspectionToolsType_InspectionToolsTypeId",
                table: "PartCountParameter",
                column: "InspectionToolsTypeId",
                principalTable: "InspectionToolsType",
                principalColumn: "InspectionToolsTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartCountParameter_PartNo",
                table: "PartCountParameter",
                column: "PartNo",
                principalTable: "Part",
                principalColumn: "PartNo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
