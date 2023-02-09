using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SMSMyTaskPermission_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 480, "Admin_SMSMyTask_Can_Access", "AdminSMSMyTaskCanAccess" },
                    { 481, "Admin_SMSMyTask_Can_Create", "AdminSMSMyTaskCanCreate" },
                    { 482, "Admin_SMSMyTask_Can_Update", "AdminSMSMyTaskCanUpdate" },
                    { 483, "Admin_SMSMyTask_Can_Delete", "AdminSMSMyTaskCanDelete" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 483);
        }
    }
}
