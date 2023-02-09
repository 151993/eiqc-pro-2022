using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierBowTwistActual_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupplierBowTwist",
                columns: table => new
                {
                    SupplierBowTwistId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierMeasurementSubmissionId = table.Column<int>(nullable: false),
                    PartBowTwistParameterId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierBowTwist", x => x.SupplierBowTwistId);
                    table.ForeignKey(
                        name: "FK_SupplierBowTwist_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierBowTwist_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierBowTwist_PartBowTwistParameterId",
                        column: x => x.PartBowTwistParameterId,
                        principalTable: "PartInspectionBowTwistParameter",
                        principalColumn: "PartBowTwistParameterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierBowTwist_SupplierMeasurementSubmissionId",
                        column: x => x.SupplierMeasurementSubmissionId,
                        principalTable: "SupplierMeasurementSubmission",
                        principalColumn: "SupplierMeasurementSubmissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierBowTwistActual",
                columns: table => new
                {
                    SupplierBowTwistActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    SupplierBowTwistId = table.Column<int>(nullable: false),
                    ActualTextName = table.Column<string>(nullable: true),
                    ActualTextValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierBowTwistActual", x => x.SupplierBowTwistActualId);
                    table.ForeignKey(
                        name: "FK_SupplierBowTwistActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierBowTwistActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierBowTwistActual_SupplierBowTwistId",
                        column: x => x.SupplierBowTwistId,
                        principalTable: "SupplierBowTwist",
                        principalColumn: "SupplierBowTwistId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierBowTwist_CreatedBy",
                table: "SupplierBowTwist",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierBowTwist_LastUpdatedBy",
                table: "SupplierBowTwist",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierBowTwist_PartBowTwistParameterId",
                table: "SupplierBowTwist",
                column: "PartBowTwistParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierBowTwist_SupplierMeasurementSubmissionId",
                table: "SupplierBowTwist",
                column: "SupplierMeasurementSubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierBowTwistActual_CreatedBy",
                table: "SupplierBowTwistActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierBowTwistActual_LastUpdatedBy",
                table: "SupplierBowTwistActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierBowTwistActual_SupplierBowTwistId",
                table: "SupplierBowTwistActual",
                column: "SupplierBowTwistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierBowTwistActual");

            migrationBuilder.DropTable(
                name: "SupplierBowTwist");
        }
    }
}
