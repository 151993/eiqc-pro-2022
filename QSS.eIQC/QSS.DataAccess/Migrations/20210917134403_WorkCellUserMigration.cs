using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class WorkCellUserMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialGroupDccUser");

            migrationBuilder.DropTable(
                name: "MaterialGroupJabilUser");

            migrationBuilder.DropTable(
                name: "MaterialGroupUser");

            migrationBuilder.CreateTable(
                name: "WorkCellUser",
                columns: table => new
                {
                    WorkCellUserId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    IsDccApproval = table.Column<bool>(nullable: true),
                    WorkCellId = table.Column<int>(nullable: false),
                    SiteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCellUser", x => x.WorkCellUserId);
                    table.ForeignKey(
                        name: "FK_WorkCellUser_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkCellUser_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkCellUser_Site_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "SiteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkCellUser_WorkCell_WorkCellId",
                        column: x => x.WorkCellId,
                        principalTable: "WorkCell",
                        principalColumn: "WorkCellId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkCellDccUser",
                columns: table => new
                {
                    WorkCellDccUserId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    WorkCellUserId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCellDccUser", x => x.WorkCellDccUserId);
                    table.ForeignKey(
                        name: "FK_WorkCellDccUser_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkCellDccUser_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkCellDccUser_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkCellDccUser_WorkCellUserId",
                        column: x => x.WorkCellUserId,
                        principalTable: "WorkCellUser",
                        principalColumn: "WorkCellUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkCellJabilUser",
                columns: table => new
                {
                    WorkCellJabilUserId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    WorkCellUserId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCellJabilUser", x => x.WorkCellJabilUserId);
                    table.ForeignKey(
                        name: "FK_WorkCellJabilUser_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkCellJabilUser_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkCellJabilUser_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkCellJabilUser_WorkCellUserId",
                        column: x => x.WorkCellUserId,
                        principalTable: "WorkCellUser",
                        principalColumn: "WorkCellUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 414,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_WorkCellUser_Can_Access", "AdminWorkCellUserCanAccess" });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 415,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_WorkCellUser_Can_Create", "AdminWorkCellUserCanCreate" });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 416,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_WorkCellUser_Can_Update", "AdminWorkCellUserCanUpdate" });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 417,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_WorkCellUser_Can_Delete", "AdminWorkCellUserCanDelete" });

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellDccUser_CreatedBy",
                table: "WorkCellDccUser",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellDccUser_LastUpdatedBy",
                table: "WorkCellDccUser",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellDccUser_UserId",
                table: "WorkCellDccUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellDccUser_WorkCellUserId",
                table: "WorkCellDccUser",
                column: "WorkCellUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellJabilUser_CreatedBy",
                table: "WorkCellJabilUser",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellJabilUser_LastUpdatedBy",
                table: "WorkCellJabilUser",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellJabilUser_UserId",
                table: "WorkCellJabilUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellJabilUser_WorkCellUserId",
                table: "WorkCellJabilUser",
                column: "WorkCellUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellUser_CreatedBy",
                table: "WorkCellUser",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellUser_LastUpdatedBy",
                table: "WorkCellUser",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellUser_SiteId",
                table: "WorkCellUser",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellUser_WorkCellId",
                table: "WorkCellUser",
                column: "WorkCellId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkCellDccUser");

            migrationBuilder.DropTable(
                name: "WorkCellJabilUser");

            migrationBuilder.DropTable(
                name: "WorkCellUser");

            migrationBuilder.CreateTable(
                name: "MaterialGroupUser",
                columns: table => new
                {
                    MaterialGroupUserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    IsDccApproval = table.Column<bool>(type: "boolean", nullable: true),
                    LastUpdated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    MaterialGroupId = table.Column<int>(type: "integer", nullable: false),
                    SiteId = table.Column<int>(type: "integer", nullable: false),
                    StatusTypeId = table.Column<byte>(type: "smallint", nullable: false, defaultValue: (byte)1)
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
                    MaterialGroupDccUserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    MaterialGroupUserId = table.Column<int>(type: "integer", nullable: false),
                    StatusTypeId = table.Column<byte>(type: "smallint", nullable: false, defaultValue: (byte)1),
                    UserId = table.Column<int>(type: "integer", nullable: false)
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
                    MaterialGroupJabilUserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    MaterialGroupUserId = table.Column<int>(type: "integer", nullable: false),
                    StatusTypeId = table.Column<byte>(type: "smallint", nullable: false, defaultValue: (byte)1),
                    UserId = table.Column<int>(type: "integer", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 414,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_MaterialGroupUser_Can_Access", "AdminMaterialGroupUserCanAccess" });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 415,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_MaterialGroupUser_Can_Create", "AdminMaterialGroupUserCanCreate" });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 416,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_MaterialGroupUser_Can_Update", "AdminMaterialGroupUserCanUpdate" });

            migrationBuilder.UpdateData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 417,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Admin_MaterialGroupUser_Can_Delete", "AdminMaterialGroupUserCanDelete" });

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
    }
}
