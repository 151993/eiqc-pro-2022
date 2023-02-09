using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierDimensionMeasurmentFunctionVariableMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupplierDimensionMeasurement",
                columns: table => new
                {
                    SupplierDimensionMeasurementId = table.Column<int>(nullable: false)
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
                    InstrumentId = table.Column<int>(nullable: true),
                    DataTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierDimensionMeasurement", x => x.SupplierDimensionMeasurementId);
                    table.ForeignKey(
                        name: "FK_SupplierDimensionMeasurement_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierDimensionMeasurement_DataTypeId",
                        column: x => x.DataTypeId,
                        principalTable: "DataType",
                        principalColumn: "DataTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierDimensionMeasurement_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instrument",
                        principalColumn: "InstrumentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierDimensionMeasurement_InstrumentTypeId",
                        column: x => x.InstrumentTypeId,
                        principalTable: "InstrumentType",
                        principalColumn: "InstrumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierDimensionMeasurement_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierDimensionMeasurement_ParameterManagementId",
                        column: x => x.ParameterManagementId,
                        principalTable: "ParameterManagement",
                        principalColumn: "ParameterManagementId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierDimensionMeasurement_SupplierMeasurementSubmissionId",
                        column: x => x.SupplierMeasurementSubmissionId,
                        principalTable: "SupplierMeasurementSubmission",
                        principalColumn: "SupplierMeasurementSubmissionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierDimensionMeasurement_UOMId",
                        column: x => x.UOMId,
                        principalTable: "UOM",
                        principalColumn: "UOMId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierFunctionVariable",
                columns: table => new
                {
                    SupplierFunctionVariableId = table.Column<int>(nullable: false)
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
                    InstrumentId = table.Column<int>(nullable: true),
                    DataTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFunctionVariable", x => x.SupplierFunctionVariableId);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionVariable_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionVariable_DataTypeId",
                        column: x => x.DataTypeId,
                        principalTable: "DataType",
                        principalColumn: "DataTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionVariable_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instrument",
                        principalColumn: "InstrumentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionVariable_InstrumentTypeId",
                        column: x => x.InstrumentTypeId,
                        principalTable: "InstrumentType",
                        principalColumn: "InstrumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionVariable_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionVariable_ParameterManagementId",
                        column: x => x.ParameterManagementId,
                        principalTable: "ParameterManagement",
                        principalColumn: "ParameterManagementId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionVariable_SupplierMeasurementSubmissionId",
                        column: x => x.SupplierMeasurementSubmissionId,
                        principalTable: "SupplierMeasurementSubmission",
                        principalColumn: "SupplierMeasurementSubmissionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionVariable_UOMId",
                        column: x => x.UOMId,
                        principalTable: "UOM",
                        principalColumn: "UOMId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDimensionMeasurement_CreatedBy",
                table: "SupplierDimensionMeasurement",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDimensionMeasurement_DataTypeId",
                table: "SupplierDimensionMeasurement",
                column: "DataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDimensionMeasurement_InstrumentId",
                table: "SupplierDimensionMeasurement",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDimensionMeasurement_InstrumentTypeId",
                table: "SupplierDimensionMeasurement",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDimensionMeasurement_LastUpdatedBy",
                table: "SupplierDimensionMeasurement",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDimensionMeasurement_ParameterManagementId",
                table: "SupplierDimensionMeasurement",
                column: "ParameterManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDimensionMeasurement_SupplierMeasurementSubmissionId",
                table: "SupplierDimensionMeasurement",
                column: "SupplierMeasurementSubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDimensionMeasurement_UOMId",
                table: "SupplierDimensionMeasurement",
                column: "UOMId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionVariable_CreatedBy",
                table: "SupplierFunctionVariable",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionVariable_DataTypeId",
                table: "SupplierFunctionVariable",
                column: "DataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionVariable_InstrumentId",
                table: "SupplierFunctionVariable",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionVariable_InstrumentTypeId",
                table: "SupplierFunctionVariable",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionVariable_LastUpdatedBy",
                table: "SupplierFunctionVariable",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionVariable_ParameterManagementId",
                table: "SupplierFunctionVariable",
                column: "ParameterManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionVariable_SupplierMeasurementSubmissionId",
                table: "SupplierFunctionVariable",
                column: "SupplierMeasurementSubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionVariable_UOMId",
                table: "SupplierFunctionVariable",
                column: "UOMId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierDimensionMeasurement");

            migrationBuilder.DropTable(
                name: "SupplierFunctionVariable");
        }
    }
}
