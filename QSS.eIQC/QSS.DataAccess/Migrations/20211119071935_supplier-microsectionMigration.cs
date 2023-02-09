using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class suppliermicrosectionMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupplierMicrosection",
                columns: table => new
                {
                    SupplierMicrosectionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    NormalValue = table.Column<double>(nullable: true),
                    UpperTolerance = table.Column<double>(nullable: true),
                    LowerTolerance = table.Column<double>(nullable: true),
                    Accuracy = table.Column<int>(nullable: true),
                    SupplierMeasurementSubmissionId = table.Column<int>(nullable: false),
                    ParameterManagementId = table.Column<int>(nullable: false),
                    UOMId = table.Column<int>(nullable: false),
                    InstrumentTypeId = table.Column<int>(nullable: false),
                    InstrumentId = table.Column<int>(nullable: false),
                    DataTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierMicrosection", x => x.SupplierMicrosectionId);
                    table.ForeignKey(
                        name: "FK_SupplierMicrosection_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMicrosection_DataTypeId",
                        column: x => x.DataTypeId,
                        principalTable: "DataType",
                        principalColumn: "DataTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierMicrosection_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instrument",
                        principalColumn: "InstrumentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierMicrosection_InstrumentTypeId",
                        column: x => x.InstrumentTypeId,
                        principalTable: "InstrumentType",
                        principalColumn: "InstrumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierMicrosection_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMicrosection_ParameterManagementId",
                        column: x => x.ParameterManagementId,
                        principalTable: "ParameterManagement",
                        principalColumn: "ParameterManagementId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierMicrosection_SupplierMeasurementSubmissionId",
                        column: x => x.SupplierMeasurementSubmissionId,
                        principalTable: "SupplierMeasurementSubmission",
                        principalColumn: "SupplierMeasurementSubmissionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierMicrosection_UOMId",
                        column: x => x.UOMId,
                        principalTable: "UOM",
                        principalColumn: "UOMId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMicrosection_CreatedBy",
                table: "SupplierMicrosection",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMicrosection_DataTypeId",
                table: "SupplierMicrosection",
                column: "DataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMicrosection_InstrumentId",
                table: "SupplierMicrosection",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMicrosection_InstrumentTypeId",
                table: "SupplierMicrosection",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMicrosection_LastUpdatedBy",
                table: "SupplierMicrosection",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMicrosection_ParameterManagementId",
                table: "SupplierMicrosection",
                column: "ParameterManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMicrosection_SupplierMeasurementSubmissionId",
                table: "SupplierMicrosection",
                column: "SupplierMeasurementSubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMicrosection_UOMId",
                table: "SupplierMicrosection",
                column: "UOMId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierMicrosection");
        }
    }
}
