using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class IPDeleteChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartFunParameter_SAPPartInspectionPlanId",
                table: "PartFunParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMeasurementParameter_SAPPartInspectionPlanId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMicrosection_SAPPartInspectionPlanId",
                table: "PartMicrosection");

            migrationBuilder.AddForeignKey(
                name: "FK_PartFunParameter_SAPPartInspectionPlanId",
                table: "PartFunParameter",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMeasurementParameter_SAPPartInspectionPlanId",
                table: "PartMeasurementParameter",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMicrosection_SAPPartInspectionPlanId",
                table: "PartMicrosection",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartFunParameter_SAPPartInspectionPlanId",
                table: "PartFunParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMeasurementParameter_SAPPartInspectionPlanId",
                table: "PartMeasurementParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_PartMicrosection_SAPPartInspectionPlanId",
                table: "PartMicrosection");

            migrationBuilder.AddForeignKey(
                name: "FK_PartFunParameter_SAPPartInspectionPlanId",
                table: "PartFunParameter",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMeasurementParameter_SAPPartInspectionPlanId",
                table: "PartMeasurementParameter",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PartMicrosection_SAPPartInspectionPlanId",
                table: "PartMicrosection",
                column: "SAPPartInspectionPlanId",
                principalTable: "SAPPartInspectionPlan",
                principalColumn: "SAPPartInspectionPlanId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
