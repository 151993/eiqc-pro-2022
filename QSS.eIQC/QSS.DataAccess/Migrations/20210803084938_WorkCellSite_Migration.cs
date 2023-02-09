using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class WorkCellSite_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkCell_SiteId",
                table: "WorkCell");

            migrationBuilder.DropIndex(
                name: "IX_WorkCell_SiteId",
                table: "WorkCell");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "WorkCell");

            migrationBuilder.CreateTable(
                name: "WorkCellSite",
                columns: table => new
                {
                    WorkCellSiteId = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_WorkCellSite", x => x.WorkCellSiteId);
                    table.ForeignKey(
                        name: "FK_WorkCellSite_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkCellSite_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkCellSite_SiteId",
                        column: x => x.SiteId,
                        principalTable: "Site",
                        principalColumn: "SiteId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkCellSite_WorkCellId",
                        column: x => x.WorkCellId,
                        principalTable: "WorkCell",
                        principalColumn: "WorkCellId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellSite_CreatedBy",
                table: "WorkCellSite",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellSite_LastUpdatedBy",
                table: "WorkCellSite",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellSite_SiteId",
                table: "WorkCellSite",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCellSite_WorkCellId",
                table: "WorkCellSite",
                column: "WorkCellId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkCellSite");

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "WorkCell",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkCell_SiteId",
                table: "WorkCell",
                column: "SiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkCell_SiteId",
                table: "WorkCell",
                column: "SiteId",
                principalTable: "Site",
                principalColumn: "SiteId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
