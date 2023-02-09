using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class DefaultAccess : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[] { 44, "Home_Can_Access", "HomeCanAccess" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "Name" },
                values: new object[] { 2, "DefaultAccess" });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "RolePermissionId", "PermissionTypeId", "RoleId" },
                values: new object[] { 44, 44, 1 });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "RolePermissionId", "PermissionTypeId", "RoleId" },
                values: new object[] { 45, 44, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "RoleId",
                keyValue: 2);
        }
    }
}
