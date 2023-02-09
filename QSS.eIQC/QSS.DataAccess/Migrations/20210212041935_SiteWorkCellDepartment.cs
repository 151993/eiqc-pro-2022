using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SiteWorkCellDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SiteDepartment",
                columns: table => new
                {
                    SiteDepartmentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    SiteId = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteDepartment", x => x.SiteDepartmentId);
                    table.ForeignKey(
                        name: "FK_SiteDepartment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteDepartment_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SiteDepartment_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteDepartment_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "SiteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiteWorkCell",
                columns: table => new
                {
                    SiteWorkCellId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    SiteId = table.Column<int>(nullable: false),
                    WorkCellId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteWorkCell", x => x.SiteWorkCellId);
                    table.ForeignKey(
                        name: "FK_SiteWorkCell_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteWorkCell_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteWorkCell_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "SiteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiteWorkCell_WorkCellId",
                        column: x => x.WorkCellId,
                        principalTable: "WorkCell",
                        principalColumn: "WorkCellId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SiteDepartment_CreatedBy",
                table: "SiteDepartment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SiteDepartment_DepartmentId",
                table: "SiteDepartment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteDepartment_LastUpdatedBy",
                table: "SiteDepartment",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SiteDepartment_SiteId",
                table: "SiteDepartment",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteWorkCell_CreatedBy",
                table: "SiteWorkCell",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SiteWorkCell_LastUpdatedBy",
                table: "SiteWorkCell",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SiteWorkCell_SiteId",
                table: "SiteWorkCell",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_SiteWorkCell_WorkCellId",
                table: "SiteWorkCell",
                column: "WorkCellId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiteDepartment");

            migrationBuilder.DropTable(
                name: "SiteWorkCell");
        }
    }
}
