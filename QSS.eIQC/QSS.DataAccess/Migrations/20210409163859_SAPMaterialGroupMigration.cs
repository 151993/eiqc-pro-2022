using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SAPMaterialGroupMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MaterialGroup",
                columns: table => new
                {
                    MaterialGroupId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SiteName = table.Column<string>(maxLength: 50, nullable: false),
                    MaterialGroupName = table.Column<string>(maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialGroup", x => x.MaterialGroupId);
                    table.ForeignKey(
                        name: "FK_MaterialGroup_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialGroup_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SAPDataSyncDetails",
                columns: table => new
                {
                    SAPDataSyncDetailsId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    LastSyncDate = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SAPDataSyncDetails", x => x.SAPDataSyncDetailsId);
                });

            migrationBuilder.CreateTable(
                name: "SyncSAPDataType",
                columns: table => new
                {
                    SyncSAPDataTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SyncSAPDataType", x => x.SyncSAPDataTypeId);
                });

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                
                    { 394, "Admin_MaterialGroup_Can_Access", "AdminMaterialGroupCanAccess" },
                    { 395, "Admin_MaterialGroup_Can_Create", "AdminMaterialGroupCanCreate" },
                    { 396, "Admin_MaterialGroup_Can_Update", "AdminMaterialGroupCanUpdate" },
                    { 397, "Admin_MaterialGroup_Can_Delete", "AdminMaterialGroupCanDelete" }
                });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "RolePermissionId", "PermissionTypeId", "RoleId" },
                values: new object[,]
                {
                     { 784,394, 1 },
                     { 785,395, 1 },
                     { 786,396, 1 },                
                     { 787,397,1 }
                   
                });

            migrationBuilder.InsertData(
                table: "SAPDataSyncDetails",
                columns: new[] { "SAPDataSyncDetailsId", "LastSyncDate", "Name" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 462, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, 0, 0, 0, 0)), "1" });

            migrationBuilder.InsertData(
                table: "SyncSAPDataType",
                columns: new[] { "SyncSAPDataTypeId", "Description", "Name" },
                values: new object[] { 1, "Last-Sync-Materia-Group", "Last_Sync_MaterialGroup" });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialGroup_CreatedBy",
                table: "MaterialGroup",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialGroup_LastUpdatedBy",
                table: "MaterialGroup",
                column: "LastUpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialGroup");

            migrationBuilder.DropTable(
                name: "SAPDataSyncDetails");

            migrationBuilder.DropTable(
                name: "SyncSAPDataType");           

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 397);
        }
    }
}
