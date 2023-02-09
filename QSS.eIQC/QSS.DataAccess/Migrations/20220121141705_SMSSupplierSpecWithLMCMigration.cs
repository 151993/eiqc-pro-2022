using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SMSSupplierSpecWithLMCMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_SupplierMPositionActual_SupplierMPosition_SupplierMPosition~",
            //    table: "SupplierMPositionActual");

            //migrationBuilder.DropUniqueConstraint(
            //    name: "AK_SupplierMPosition_TempId",
            //    table: "SupplierMPosition");

            //migrationBuilder.DropColumn(
            //    name: "TempId",
            //    table: "SupplierMPosition");

            migrationBuilder.CreateTable(
                name: "SupplierLPosition",
                columns: table => new
                {
                    SupplierLPositionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SupplierMeasurementSubmissionId = table.Column<int>(nullable: false),
                    PartLPositionToleranceId = table.Column<int>(nullable: true),
                    ParameterManagementId = table.Column<int>(nullable: true),
                    PartDimensionId = table.Column<int>(nullable: true),
                    DimensionDefaultId = table.Column<int>(nullable: true),
                    AssociatedDimensionNumberId = table.Column<int>(nullable: true),
                    UOMId = table.Column<int>(nullable: true),
                    InstrumentId = table.Column<int>(nullable: true),
                    InstrumentTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierLPosition", x => x.SupplierLPositionId);
                    table.ForeignKey(
                        name: "FK_SupplierLPosition_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierLPosition_DimensionDefault_DimensionDefaultId",
                        column: x => x.DimensionDefaultId,
                        principalTable: "DimensionDefault",
                        principalColumn: "DimensionDefaultId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierLPosition_Instrument_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instrument",
                        principalColumn: "InstrumentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierLPosition_InstrumentType_InstrumentTypeId",
                        column: x => x.InstrumentTypeId,
                        principalTable: "InstrumentType",
                        principalColumn: "InstrumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierLPosition_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierLPosition_ParameterManagement_ParameterManagementId",
                        column: x => x.ParameterManagementId,
                        principalTable: "ParameterManagement",
                        principalColumn: "ParameterManagementId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierLPosition_PartDimension_PartDimensionId",
                        column: x => x.PartDimensionId,
                        principalTable: "PartDimension",
                        principalColumn: "PartDimensionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierLPosition_PartLPositionTolerance_PartLPositionToler~",
                        column: x => x.PartLPositionToleranceId,
                        principalTable: "PartLPositionTolerance",
                        principalColumn: "PartLPositionToleranceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierLPosition_SupplierMeasurementSubmissionId",
                        column: x => x.SupplierMeasurementSubmissionId,
                        principalTable: "SupplierMeasurementSubmission",
                        principalColumn: "SupplierMeasurementSubmissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierLPosition_UOM_UOMId",
                        column: x => x.UOMId,
                        principalTable: "UOM",
                        principalColumn: "UOMId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierLPositionActual",
                columns: table => new
                {
                    SupplierLPositionActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SupplierLPositionId = table.Column<int>(nullable: false),
                    ActualText = table.Column<string>(maxLength: 256, nullable: true),
                    ActualValue = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierLPositionActual", x => x.SupplierLPositionActualId);
                    table.ForeignKey(
                        name: "FK_SupplierLPositionActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierLPositionActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierLPositionActual_SupplierLPositionId",
                        column: x => x.SupplierLPositionId,
                        principalTable: "SupplierLPosition",
                        principalColumn: "SupplierLPositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLPosition_CreatedBy",
                table: "SupplierLPosition",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLPosition_DimensionDefaultId",
                table: "SupplierLPosition",
                column: "DimensionDefaultId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLPosition_InstrumentId",
                table: "SupplierLPosition",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLPosition_InstrumentTypeId",
                table: "SupplierLPosition",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLPosition_LastUpdatedBy",
                table: "SupplierLPosition",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLPosition_ParameterManagementId",
                table: "SupplierLPosition",
                column: "ParameterManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLPosition_PartDimensionId",
                table: "SupplierLPosition",
                column: "PartDimensionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLPosition_PartLPositionToleranceId",
                table: "SupplierLPosition",
                column: "PartLPositionToleranceId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLPosition_SupplierMeasurementSubmissionId",
                table: "SupplierLPosition",
                column: "SupplierMeasurementSubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLPosition_UOMId",
                table: "SupplierLPosition",
                column: "UOMId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLPositionActual_CreatedBy",
                table: "SupplierLPositionActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLPositionActual_LastUpdatedBy",
                table: "SupplierLPositionActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierLPositionActual_SupplierLPositionId",
                table: "SupplierLPositionActual",
                column: "SupplierLPositionId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_SupplierMPositionActual_SupplierMPosition_SupplierMPosition~",
            //    table: "SupplierMPositionActual",
            //    column: "SupplierMPositionId",
            //    principalTable: "SupplierMPosition",
            //    principalColumn: "SupplierMPositionId",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_SupplierMPositionActual_SupplierMPosition_SupplierMPosition~",
            //    table: "SupplierMPositionActual");

            migrationBuilder.DropTable(
                name: "SupplierLPositionActual");

            migrationBuilder.DropTable(
                name: "SupplierLPosition");

            //migrationBuilder.AddColumn<int>(
            //    name: "TempId",
            //    table: "SupplierMPosition",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AddUniqueConstraint(
            //    name: "AK_SupplierMPosition_TempId",
            //    table: "SupplierMPosition",
            //    column: "TempId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_SupplierMPositionActual_SupplierMPosition_SupplierMPosition~",
            //    table: "SupplierMPositionActual",
            //    column: "SupplierMPositionId",
            //    principalTable: "SupplierMPosition",
            //    principalColumn: "TempId",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}
