using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class NonJabilUserPermissionMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserType",
                table: "User");

            migrationBuilder.AddColumn<int>(
                name: "UserTypeId",
                table: "User",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    UserTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.UserTypeId);
                });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 437,
                column: "Description",
                value: "Admin_Supplier_Can_Delete");

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 438, "Admin_NonJabilUser_Can_Access", "AdminNonJabilUserCanAccess" },
                    { 439, "Admin_NonJabilUser_Can_Create", "AdminNonJabilUserCanCreate" },
                    { 440, "Admin_NonJabilUser_Can_Update", "AdminNonJabilUserCanUpdate" },
                    { 441, "Admin_NonJabilUser_Can_Delete", "AdminNonJabilUserCanDelete" }
                });

            migrationBuilder.InsertData(
                table: "UserType",
                columns: new[] { "UserTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Supplier", "Supplier" },
                    { 2, "Customer", "Customer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserType");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 441);

            migrationBuilder.DropColumn(
                name: "UserTypeId",
                table: "User");

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "User",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 437,
                column: "Description",
                value: "Admin_CommodityCategory_Can_Delete");
        }
    }
}
