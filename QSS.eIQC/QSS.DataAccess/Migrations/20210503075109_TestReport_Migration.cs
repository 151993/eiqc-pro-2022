using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class TestReport_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestReport",
                columns: table => new
                {
                    TestReportId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestReport", x => x.TestReportId);
                    table.ForeignKey(
                        name: "FK_TestReport_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestReport_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestReportCommodity",
                columns: table => new
                {
                    TestReportCommodityId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    TestReportId = table.Column<int>(nullable: false),
                    CommodityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestReportCommodity", x => x.TestReportCommodityId);
                    table.ForeignKey(
                        name: "FK_TestReportCommodity_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodity",
                        principalColumn: "CommodityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TestReportCommodity_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestReportCommodity_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestReportCommodity_TestReportId",
                        column: x => x.TestReportId,
                        principalTable: "TestReport",
                        principalColumn: "TestReportId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 402, "Admin_TestReport_Can_Access", "AdminTestReportCanAccess" },
                    { 403, "Admin_TestReport_Can_Create", "AdminTestReportCanCreate" },
                    { 404, "Admin_TestReport_Can_Update", "AdminTestReportCanUpdate" },
                    { 405, "Admin_TestReport_Can_Delete", "AdminTestReportCanDelete" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestReport_CreatedBy",
                table: "TestReport",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TestReport_LastUpdatedBy",
                table: "TestReport",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TestReportCommodity_CommodityId",
                table: "TestReportCommodity",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_TestReportCommodity_CreatedBy",
                table: "TestReportCommodity",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TestReportCommodity_LastUpdatedBy",
                table: "TestReportCommodity",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TestReportCommodity_TestReportId",
                table: "TestReportCommodity",
                column: "TestReportId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestReportCommodity");

            migrationBuilder.DropTable(
                name: "TestReport");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 405);
        }
    }
}
