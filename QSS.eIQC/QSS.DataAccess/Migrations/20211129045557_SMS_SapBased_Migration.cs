using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SMS_SapBased_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupplierSapBasedParameter",
                columns: table => new
                {
                    SupplierSapBasedParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    SupplierMeasurementSubmissionId = table.Column<int>(nullable: false),
                    CertificateTypeParameterId = table.Column<int>(nullable: false),
                    MatchId = table.Column<int>(nullable: false),
                    SapRequest = table.Column<string>(nullable: true),
                    PhysicalInspection = table.Column<string>(nullable: true),
                    ResultPassFailId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierSapBasedParameter", x => x.SupplierSapBasedParameterId);
                    table.ForeignKey(
                        name: "FK_SupplierSapBasedParameter_CertificateTypeParameterId",
                        column: x => x.CertificateTypeParameterId,
                        principalTable: "CertificateTypeParameter",
                        principalColumn: "CertificateTypeParameterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierSapBasedParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierSapBasedParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierSapBasedParameter_SupplierMeasurementSubmissionId",
                        column: x => x.SupplierMeasurementSubmissionId,
                        principalTable: "SupplierMeasurementSubmission",
                        principalColumn: "SupplierMeasurementSubmissionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierSapBasedParameterDefectType",
                columns: table => new
                {
                    SupplierSapBasedParameterDefectTypeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    SupplierSapBasedParameterId = table.Column<int>(nullable: false),
                    DefectTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierSapBasedParameterDefectType", x => x.SupplierSapBasedParameterDefectTypeId);
                    table.ForeignKey(
                        name: "FK_SupplierSapBasedParameterDefectType_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierSapBasedParameterDefectType_DefectTypeId",
                        column: x => x.DefectTypeId,
                        principalTable: "DefectType",
                        principalColumn: "DefectTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierSapBasedParameterDefectType_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierSapBasedParameterDefectType_SupplierSapBasedParameterId",
                        column: x => x.SupplierSapBasedParameterId,
                        principalTable: "SupplierSapBasedParameter",
                        principalColumn: "SupplierSapBasedParameterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSapBasedParameter_CertificateTypeParameterId",
                table: "SupplierSapBasedParameter",
                column: "CertificateTypeParameterId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSapBasedParameter_CreatedBy",
                table: "SupplierSapBasedParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSapBasedParameter_LastUpdatedBy",
                table: "SupplierSapBasedParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSapBasedParameter_SupplierMeasurementSubmissionId",
                table: "SupplierSapBasedParameter",
                column: "SupplierMeasurementSubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSapBasedParameterDefectType_CreatedBy",
                table: "SupplierSapBasedParameterDefectType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSapBasedParameterDefectType_DefectTypeId",
                table: "SupplierSapBasedParameterDefectType",
                column: "DefectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSapBasedParameterDefectType_LastUpdatedBy",
                table: "SupplierSapBasedParameterDefectType",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierSapBasedParameterDefectType_SupplierSapBasedParamet~",
                table: "SupplierSapBasedParameterDefectType",
                column: "SupplierSapBasedParameterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierSapBasedParameterDefectType");

            migrationBuilder.DropTable(
                name: "SupplierSapBasedParameter");
        }
    }
}
