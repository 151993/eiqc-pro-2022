using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class RoleAccessDCCSQESupplierMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 468, "Admin_SupplierTask_Can_Access", "AdminSupplierTaskCanAccess" },
                    { 469, "Admin_SupplierTask_Can_Create", "AdminSupplierTaskCanCreate" },
                    { 470, "Admin_SupplierTask_Can_Update", "AdminSupplierTaskCanUpdate" },
                    { 471, "Admin_SupplierTask_Can_Delete", "AdminSupplierTaskCanDelete" },
                    { 472, "Admin_DCCTask_Can_Access", "AdminDCCTaskCanAccess" },
                    { 473, "Admin_DCCTask_Can_Create", "AdminDCCTaskCanCreate" },
                    { 474, "Admin_DCCTask_Can_Update", "AdminDCCTaskCanUpdate" },
                    { 475, "Admin_DCCTask_Can_Delete", "AdminDCCTaskCanDelete" },
                    { 476, "Admin_SQETask_Can_Access", "AdminSQETaskCanAccess" },
                    { 477, "Admin_SQETask_Can_Create", "AdminSQETaskCanCreate" },
                    { 478, "Admin_SQETask_Can_Update", "AdminSQETaskCanUpdate" },
                    { 479, "Admin_SQETask_Can_Delete", "AdminSQETaskCanDelete" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 479);
        }
    }
}
