using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class Part_Function_Attribute_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartResultOrientedParameter_PartNo",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartResultOrientedParameter_PartNo",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropColumn(
                name: "ParameterName",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropColumn(
                name: "PartNo",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropColumn(
                name: "ResultExpected",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropColumn(
                name: "StatusTypeId",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropColumn(
                name: "TestCondition",
                table: "PartResultOrientedParameter");

            migrationBuilder.AlterColumn<string>(
                name: "SpecRevisionNumber",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SpecNumber",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpecDescription",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrawingDescription",
                table: "SAPPartInspectionPlan",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "PartResultOrientedParameter",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "PartResultOrientedParameter",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ParameterManagementId",
                table: "PartResultOrientedParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "PartResultOrientedParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SAPPartInspectionPlanId",
                table: "PartResultOrientedParameter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TestRequirement",
                table: "PartResultOrientedParameter",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartResultOrientedParameter_ParameterManagementId",
                table: "PartResultOrientedParameter",
                column: "ParameterManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_PartResultOrientedParameter_SAPPartInspectionPlanId",
                table: "PartResultOrientedParameter",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_PartResultOrientedParameter_ParameterManagementId",
                table: "PartResultOrientedParameter",
                column: "ParameterManagementId",
                principalTable: "ParameterManagement",
                principalColumn: "ParameterManagementId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartResultOrientedParameter_SAPPartInspectionPlanId",
                table: "PartResultOrientedParameter",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartResultOrientedParameter_ParameterManagementId",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartResultOrientedParameter_SAPPartInspectionPlanId",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartResultOrientedParameter_ParameterManagementId",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartResultOrientedParameter_SAPPartInspectionPlanId",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropColumn(
                name: "ParameterManagementId",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropColumn(
                name: "SAPPartInspectionPlanId",
                table: "PartResultOrientedParameter");

            migrationBuilder.DropColumn(
                name: "TestRequirement",
                table: "PartResultOrientedParameter");

            migrationBuilder.AlterColumn<string>(
                name: "SpecRevisionNumber",
                table: "SAPPartInspectionPlan",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpecNumber",
                table: "SAPPartInspectionPlan",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SpecDescription",
                table: "SAPPartInspectionPlan",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DrawingDescription",
                table: "SAPPartInspectionPlan",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.AddColumn<string>(
                name: "ParameterName",
                table: "PartResultOrientedParameter",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PartNo",
                table: "PartResultOrientedParameter",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ResultExpected",
                table: "PartResultOrientedParameter",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte>(
                name: "StatusTypeId",
                table: "PartResultOrientedParameter",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "TestCondition",
                table: "PartResultOrientedParameter",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartResultOrientedParameter_PartNo",
                table: "PartResultOrientedParameter",
                column: "PartNo");

            migrationBuilder.AddForeignKey(
                name: "FK_PartResultOrientedParameter_PartNo",
                table: "PartResultOrientedParameter",
                column: "PartNo",
                principalTable: "Part",
                principalColumn: "PartNo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
