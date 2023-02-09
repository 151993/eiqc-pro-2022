using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class PartTestReportDBChangesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartTestReportAttachment_SAPPartInspectionPlan_SAPPartInspe~",
                table: "PartTestReportAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_PTRParameter_SAPPartInspectionPlanId",
                table: "PartTestReportParameter");

            migrationBuilder.DropIndex(
                name: "IX_PartTestReportAttachment_SAPPartInspectionPlanId",
                table: "PartTestReportAttachment");

            migrationBuilder.DropColumn(
                name: "SAPPartInspectionPlanId",
                table: "PartTestReportAttachment");

            migrationBuilder.AddForeignKey(
                name: "FK_PartTestReportParameter_SAPPartInspectionPlan_SAPPartInspec~",
                table: "PartTestReportParameter",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartTestReportParameter_SAPPartInspectionPlan_SAPPartInspec~",
                table: "PartTestReportParameter");

            migrationBuilder.AddColumn<int>(
                name: "SAPPartInspectionPlanId",
                table: "PartTestReportAttachment",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PartTestReportAttachment_SAPPartInspectionPlanId",
                table: "PartTestReportAttachment",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_PartTestReportAttachment_SAPPartInspectionPlan_SAPPartInspe~",
                table: "PartTestReportAttachment",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PTRParameter_SAPPartInspectionPlanId",
                table: "PartTestReportParameter",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
