using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class supplierVisualInspectionParameterManagementInspectionToolTypeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DetailsDefine",
                table: "SupplierVisualInspection",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InspectionToolsTypeId",
                table: "SupplierVisualInspection",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "SupplierVisualInspection",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "SupplierVisualInspection",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ParameterManagementId",
                table: "SupplierVisualInspection",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierVisualInspection_InspectionToolsTypeId",
                table: "SupplierVisualInspection",
                column: "InspectionToolsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierVisualInspection_ParameterManagementId",
                table: "SupplierVisualInspection",
                column: "ParameterManagementId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierVisualInspection_InspectionToolsTypeId",
                table: "SupplierVisualInspection",
                column: "InspectionToolsTypeId",
                principalTable: "InspectionToolsType",
                principalColumn: "InspectionToolsTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierVisualInspection_ParameterManagementId",
                table: "SupplierVisualInspection",
                column: "ParameterManagementId",
                principalTable: "ParameterManagement",
                principalColumn: "ParameterManagementId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierVisualInspection_InspectionToolsTypeId",
                table: "SupplierVisualInspection");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierVisualInspection_ParameterManagementId",
                table: "SupplierVisualInspection");

            migrationBuilder.DropIndex(
                name: "IX_SupplierVisualInspection_InspectionToolsTypeId",
                table: "SupplierVisualInspection");

            migrationBuilder.DropIndex(
                name: "IX_SupplierVisualInspection_ParameterManagementId",
                table: "SupplierVisualInspection");

            migrationBuilder.DropColumn(
                name: "DetailsDefine",
                table: "SupplierVisualInspection");

            migrationBuilder.DropColumn(
                name: "InspectionToolsTypeId",
                table: "SupplierVisualInspection");

            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "SupplierVisualInspection");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "SupplierVisualInspection");

            migrationBuilder.DropColumn(
                name: "ParameterManagementId",
                table: "SupplierVisualInspection");
        }
    }
}
