using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class ApprovedSupplierMeasurementMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 484, "Admin_SMSApproved_Can_Access", "AdminApprovedSupplierMeasurementCanAccess" },
                    { 485, "Admin_SMSApproved_Can_Create", "AdminApprovedSupplierMeasurementCanCreate" },
                    { 486, "Admin_SMSApproved_Can_Update", "AdminApprovedSupplierMeasurementCanUpdate" },
                    { 487, "Admin_SMSApproved_Can_Delete", "AdminApprovedSupplierMeasurementCanDelete" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 487);
        }
    }
}
