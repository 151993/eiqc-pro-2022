using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class ApprovedInspectionPlanMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 454, "Admin_ApprovedPartInspectionPlan_Can_Access", "AdminApprovedPartInspectionPlanCanAccess" },
                    { 455, "Admin_ApprovedPartInspectionPlan_Can_Create", "AdminApprovedPartInspectionPlanCanCreate" },
                    { 456, "Admin_ApprovedPartInspectionPlan_Can_Update", "AdminApprovedPartInspectionPlanCanUpdate" },
                    { 457, "Admin_ApprovedPartInspectionPlan_Can_Delete", "AdminApprovedPartInspectionPlanCanDelete" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 457);
        }
    }
}
