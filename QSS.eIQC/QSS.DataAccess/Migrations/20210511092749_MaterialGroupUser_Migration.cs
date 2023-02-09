using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class MaterialGroupUser_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MaterialGroupUser",
                columns: table => new
                {
                    MaterialGroupUserId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    IsDccApproval = table.Column<bool>(nullable: true),
                    MaterialGroupId = table.Column<int>(nullable: false),
                    SiteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialGroupUser", x => x.MaterialGroupUserId);
                    table.ForeignKey(
                        name: "FK_MaterialGroupUser_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialGroupUser_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialGroupUser_MaterialGroup_MaterialGroupId",
                        column: x => x.MaterialGroupId,
                        principalTable: "MaterialGroup",
                        principalColumn: "MaterialGroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialGroupUser_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "SiteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialGroupDccUser",
                columns: table => new
                {
                    MaterialGroupDccUserId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    MaterialGroupUserId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialGroupDccUser", x => x.MaterialGroupDccUserId);
                    table.ForeignKey(
                        name: "FK_MaterialGroupDccUser_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialGroupDccUser_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialGroupDccUser_MaterialGroupUserId",
                        column: x => x.MaterialGroupUserId,
                        principalTable: "MaterialGroupUser",
                        principalColumn: "MaterialGroupUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialGroupDccUser_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaterialGroupJabilUser",
                columns: table => new
                {
                    MaterialGroupJabilUserId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    MaterialGroupUserId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialGroupJabilUser", x => x.MaterialGroupJabilUserId);
                    table.ForeignKey(
                        name: "FK_MaterialGroupJabilUser_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialGroupJabilUser_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialGroupJabilUser_MaterialGroupUserId",
                        column: x => x.MaterialGroupUserId,
                        principalTable: "MaterialGroupUser",
                        principalColumn: "MaterialGroupUserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialGroupJabilUser_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 414, "Admin_MaterialGroupUser_Can_Access", "AdminMaterialGroupUserCanAccess" },
                    { 415, "Admin_MaterialGroupUser_Can_Create", "AdminMaterialGroupUserCanCreate" },
                    { 416, "Admin_MaterialGroupUser_Can_Update", "AdminMaterialGroupUserCanUpdate" },
                    { 417, "Admin_MaterialGroupUser_Can_Delete", "AdminMaterialGroupUserCanDelete" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialGroupDccUser_CreatedBy",
                table: "MaterialGroupDccUser",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialGroupDccUser_LastUpdatedBy",
                table: "MaterialGroupDccUser",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialGroupDccUser_MaterialGroupUserId",
                table: "MaterialGroupDccUser",
                column: "MaterialGroupUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialGroupDccUser_UserId",
                table: "MaterialGroupDccUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialGroupJabilUser_CreatedBy",
                table: "MaterialGroupJabilUser",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialGroupJabilUser_LastUpdatedBy",
                table: "MaterialGroupJabilUser",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialGroupJabilUser_MaterialGroupUserId",
                table: "MaterialGroupJabilUser",
                column: "MaterialGroupUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialGroupJabilUser_UserId",
                table: "MaterialGroupJabilUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialGroupUser_CreatedBy",
                table: "MaterialGroupUser",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialGroupUser_LastUpdatedBy",
                table: "MaterialGroupUser",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialGroupUser_MaterialGroupId",
                table: "MaterialGroupUser",
                column: "MaterialGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialGroupUser_SiteId",
                table: "MaterialGroupUser",
                column: "SiteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialGroupDccUser");

            migrationBuilder.DropTable(
                name: "MaterialGroupJabilUser");

            migrationBuilder.DropTable(
                name: "MaterialGroupUser");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 417);
        }
    }
}
