using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SiteSme_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    ManagerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.ManagerId);
                    table.ForeignKey(
                        name: "FK_Manager_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Manager_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteUser",
                columns: table => new
                {
                    SiteUserId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SiteId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteUser", x => x.SiteUserId);
                    table.ForeignKey(
                        name: "FK_SiteUser_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteUser_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteUser_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "SiteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteUser_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId");
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId",  "Description",  "Name" },
                values: new object[] { 1, "Information Technology", "Information Technology" });

            migrationBuilder.InsertData(
                table: "Manager",
                columns: new[] { "ManagerId", "Email", "Name" },
                values: new object[,]
                {
                    { 1, null, "Mario Munoz" },
                    { 2, null, "JengHow Tan" }
                });

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 40, "Admin_SiteUser_Can_Access", "AdminSiteUserCanAccess" },
                    { 41, "Admin_SiteUser_Can_Create", "AdminSiteUserCanCreate" },
                    { 42, "Admin_SiteUser_Can_Update", "AdminSiteUserCanUpdate" },
                    { 43, "Admin_SiteUser_Can_Delete", "AdminSiteUserCanDelete" }
                });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DepartmentId", "ManagerId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DepartmentId", "ManagerId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DepartmentId", "ManagerId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DepartmentId", "ManagerId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "DepartmentId", "ManagerId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_User_DepartmentId",
                table: "User",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_User_ManagerId",
                table: "User",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Manager_CreatedBy",
                table: "Manager",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Manager_LastUpdatedBy",
                table: "Manager",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SiteUser_CreatedBy",
                table: "SiteUser",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SiteUser_LastUpdatedBy",
                table: "SiteUser",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SiteUser_SiteId",
                table: "SiteUser",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteUser_UserId",
                table: "SiteUser",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_DepartmentId",
                table: "User",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_ManagerId",
                table: "User",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "ManagerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_DepartmentId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_ManagerId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "SiteUser");

            migrationBuilder.DropIndex(
                name: "IX_User_DepartmentId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ManagerId",
                table: "User");

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 43);
           

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                table: "User");
        }
    }
}
