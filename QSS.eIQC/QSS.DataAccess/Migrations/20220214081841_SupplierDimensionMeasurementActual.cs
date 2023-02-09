using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierDimensionMeasurementActual : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupplierDimensionMeasurementActual",
                columns: table => new
                {
                    SupplierDimensionMeasurementActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    SupplierDimensionMeasurementId = table.Column<int>(nullable: false),
                    ActualTextName = table.Column<string>(nullable: true),
                    ActualTextValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierDimensionMeasurementActual", x => x.SupplierDimensionMeasurementActualId);
                    table.ForeignKey(
                        name: "FK_SupplierDimensionMeasurementActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierDimensionMeasurementActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierDimensionMeasurementAcutal_SupplierDimensionMeasurementId",
                        column: x => x.SupplierDimensionMeasurementId,
                        principalTable: "SupplierDimensionMeasurement",
                        principalColumn: "SupplierDimensionMeasurementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDimensionMeasurementActual_CreatedBy",
                table: "SupplierDimensionMeasurementActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDimensionMeasurementActual_LastUpdatedBy",
                table: "SupplierDimensionMeasurementActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDimensionMeasurementActual_SupplierDimensionMeasure~",
                table: "SupplierDimensionMeasurementActual",
                column: "SupplierDimensionMeasurementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierDimensionMeasurementActual");
        }
    }
}
