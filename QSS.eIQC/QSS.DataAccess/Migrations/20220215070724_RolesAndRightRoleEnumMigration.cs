using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class RolesAndRightRoleEnumMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleEnumId",
                table: "Role",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RoleEnum",
                columns: table => new
                {
                    RoleEnumId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleEnum", x => x.RoleEnumId);
                });

            migrationBuilder.InsertData(
                table: "RoleEnum",
                columns: new[] { "RoleEnumId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Global Admin", "Global_Admin" },
                    { 2, "Site SME", "Site_SME" },
                    { 3, "Jabil SQE", "Jabil_SQE" },
                    { 4, "Jabil IQC", "Jabil_IQC" },
                    { 5, "DCC", "DCC_User" },
                    { 6, "Supplier", "Supplier" },
                    { 7, "Jabil Default User", "Jabil_Default_User" },
                    { 8, "Customer", "Customer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Role_RoleEnumId",
                table: "Role",
                column: "RoleEnumId");

            migrationBuilder.AddForeignKey(
                name: "FK_Role_RoleEnum_RoleEnumId",
                table: "Role",
                column: "RoleEnumId",
                principalTable: "RoleEnum",
                principalColumn: "RoleEnumId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Role_RoleEnum_RoleEnumId",
                table: "Role");

            migrationBuilder.DropTable(
                name: "RoleEnum");

            migrationBuilder.DropIndex(
                name: "IX_Role_RoleEnumId",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "RoleEnumId",
                table: "Role");
        }
    }
}
