using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SAPPartInspectionManufactureNumberMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PartInspectionManufacturePartNumber",
                columns: table => new
                {
                    PartInspectionManufacturePartNumberId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SAPPartInspectionPlanId = table.Column<int>(nullable: false),
                    PartManufacturePartNumberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartInspectionManufacturePartNumber", x => x.PartInspectionManufacturePartNumberId);
                    table.ForeignKey(
                        name: "FK_PartInspectionManufacturePartNumber_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionManufacturePartNumber_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAPMPN_PMPNId",
                        column: x => x.PartManufacturePartNumberId,
                        principalTable: "PartManufacturePartNumber",
                        principalColumn: "PartManufacturePartNumberId");
                    table.ForeignKey(
                        name: "FK_SAPMPN_SAPPartInspectionPlanId",
                        column: x => x.SAPPartInspectionPlanId,
                        principalTable: "SAPPartInspectionPlan",
                        principalColumn: "SAPPartInspectionPlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionManufacturePartNumber_CreatedBy",
                table: "PartInspectionManufacturePartNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionManufacturePartNumber_LastUpdatedBy",
                table: "PartInspectionManufacturePartNumber",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionManufacturePartNumber_PartManufacturePartNumb~",
                table: "PartInspectionManufacturePartNumber",
                column: "PartManufacturePartNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionManufacturePartNumber_SAPPartInspectionPlanId",
                table: "PartInspectionManufacturePartNumber",
                column: "SAPPartInspectionPlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartInspectionManufacturePartNumber");
        }
    }
}
