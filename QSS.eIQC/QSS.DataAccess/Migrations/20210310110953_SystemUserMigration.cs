using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SystemUserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Manager",
                columns: new[] { "ManagerId", "Email", "Name" },
                values: new object[] { 3, null, "Katalin Darlaczi" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Email", "EmployeeId", "Name", "UserName" },
                values: new object[] { "system_user@jabil.com", "0", "System User", "0" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Email", "EmployeeId", "Name", "UserName" },
                values: new object[] { "sandip_patil2@jabil.com", "1232922", "Sandip Patil", "1232922" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "AllowNotification", "DepartmentId", "Email", "EmployeeId", "ManagerId", "Name", "UserName" },
                values: new object[] { 7, false, 1, "alok_saste@jabil.com", "2930215", 1, "Alok Saste", "2930215" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "AllowNotification", "DepartmentId", "Email", "EmployeeId", "ManagerId", "Name", "UserName" },
                values: new object[] { 6, false, 1, "Prashanth_Madakatte@jabil.com", "2978245", 3, "Prashanth Madakatte", "2978245" });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleId", "RoleId", "UserId" },
                values: new object[] { 7, 1, 7 });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleId", "RoleId", "UserId" },
                values: new object[] { 6, 1, 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Manager",
                keyColumn: "ManagerId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "Email", "EmployeeId", "Name", "UserName" },
                values: new object[] { "sandip_patil2@jabil.com", "1232922", "Sandip Patil", "1232922" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "Email", "EmployeeId", "Name", "UserName" },
                values: new object[] { "alok_saste@jabil.com", "2930215", "Alok Saste", "2930215" });
        }
    }
}
