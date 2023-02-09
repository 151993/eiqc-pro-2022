using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class DCCConfiguration_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DCCConfiguration",
                columns: table => new
                {
                    DCCConfigurationId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SiteNo = table.Column<string>(maxLength: 50, nullable: false),
                    DeptCode = table.Column<string>(maxLength: 50, nullable: true),
                    DocLevel = table.Column<string>(maxLength: 50, nullable: true),
                    SiteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCCConfiguration", x => x.DCCConfigurationId);
                    table.ForeignKey(
                        name: "FK_DCCConfiguration_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DCCConfiguration_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DCCConfiguration_DCCConfigurationId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "SiteId",
                        onDelete: ReferentialAction.Restrict);
                });

           
            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 426, "Admin_DCCConfiguration_Can_Access", "AdminDCCConfigurationCanAccess" },
                    { 427, "Admin_DCCConfiguration_Can_Create", "AdminDCCConfigurationCanCreate" },
                    { 428, "Admin_DCCConfiguration_Can_Update", "AdminDCCConfigurationCanUpdate" },
                    { 429, "Admin_DCCConfiguration_Can_Delete", "AdminDCCConfigurationCanDelete" }
                });
           
            migrationBuilder.CreateIndex(
                name: "IX_DCCConfiguration_CreatedBy",
                table: "DCCConfiguration",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DCCConfiguration_LastUpdatedBy",
                table: "DCCConfiguration",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DCCConfiguration_SiteId",
                table: "DCCConfiguration",
                column: "SiteId");

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DCCConfiguration");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 429);
           
        }
    }
}
