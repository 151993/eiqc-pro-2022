using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SMSSupplierSpecWithMMCMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
               name: "SupplierMeasurementManufacturePartNumber");

            migrationBuilder.DropTable(
                name: "PartInspectionManufacturePartNumber");           

            //migrationBuilder.DropTable(
            //    name: "PartManufacturePartNumber");

            //migrationBuilder.DropColumn(
            //    name: "PartId",
            //    table: "SupplierMeasurementSubmission");

            //migrationBuilder.DropColumn(
            //    name: "ResultId",
            //    table: "PartTestReportParameter");

            //migrationBuilder.AddColumn<int>(
            //    name: "ResultId",
            //    table: "SupplierTestReport",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.AlterColumn<string>(
            //    name: "ResultDescription",
            //    table: "SupplierMeasurementSubmission",
            //    maxLength: 1000,
            //    nullable: true,
            //    oldClrType: typeof(string),
            //    oldType: "character varying(256)",
            //    oldMaxLength: 256,
            //    oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturePartNumber",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DimensionDefault",
                columns: table => new
                {
                    DimensionDefaultId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    DimensionName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionDefault", x => x.DimensionDefaultId);
                    table.ForeignKey(
                        name: "FK_DimensionDefault_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DimensionDefault_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SupplierMPosition",
                columns: table => new
                {
                    SupplierMPositionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SupplierMeasurementSubmissionId = table.Column<int>(nullable: false),
                    PartMPositionToleranceId = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_SupplierMPosition", x => x.SupplierMPositionId);
                    table.ForeignKey(
                        name: "FK_SupplierMPosition_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMPosition_DimensionDefault_DimensionDefaultId",
                        column: x => x.DimensionDefaultId,
                        principalTable: "DimensionDefault",
                        principalColumn: "DimensionDefaultId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierMPosition_Instrument_InstrumentId",
                        column: x => x.InstrumentId,
                        principalTable: "Instrument",
                        principalColumn: "InstrumentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierMPosition_InstrumentType_InstrumentTypeId",
                        column: x => x.InstrumentTypeId,
                        principalTable: "InstrumentType",
                        principalColumn: "InstrumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierMPosition_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMPosition_ParameterManagement_ParameterManagementId",
                        column: x => x.ParameterManagementId,
                        principalTable: "ParameterManagement",
                        principalColumn: "ParameterManagementId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierMPosition_PartDimension_PartDimensionId",
                        column: x => x.PartDimensionId,
                        principalTable: "PartDimension",
                        principalColumn: "PartDimensionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierMPosition_PartMPositionTolerance_PartMPositionToler~",
                        column: x => x.PartMPositionToleranceId,
                        principalTable: "PartMPositionTolerance",
                        principalColumn: "PartMPositionToleranceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SupplierMPosition_SupplierMeasurementSubmission_SupplierMea~",
                        column: x => x.SupplierMeasurementSubmissionId,
                        principalTable: "SupplierMeasurementSubmission",
                        principalColumn: "SupplierMeasurementSubmissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMPosition_UOM_UOMId",
                        column: x => x.UOMId,
                        principalTable: "UOM",
                        principalColumn: "UOMId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SupplierMPositionActual",
                columns: table => new
                {
                    SupplierMPositionActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SupplierMPositionId = table.Column<int>(nullable: false),
                    ActualText = table.Column<string>(maxLength: 256, nullable: true),
                    ActualValue = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierMPositionActual", x => x.SupplierMPositionActualId);
                    table.ForeignKey(
                        name: "FK_SupplierMPositionActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMPositionActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMPositionActual_SupplierMPosition_SupplierMPosition~",
                        column: x => x.SupplierMPositionId,
                        principalTable: "SupplierMPosition",
                        principalColumn: "SupplierMPositionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DimensionDefault_CreatedBy",
                table: "DimensionDefault",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DimensionDefault_LastUpdatedBy",
                table: "DimensionDefault",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMPosition_CreatedBy",
                table: "SupplierMPosition",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMPosition_DimensionDefaultId",
                table: "SupplierMPosition",
                column: "DimensionDefaultId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMPosition_InstrumentId",
                table: "SupplierMPosition",
                column: "InstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMPosition_InstrumentTypeId",
                table: "SupplierMPosition",
                column: "InstrumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMPosition_LastUpdatedBy",
                table: "SupplierMPosition",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMPosition_ParameterManagementId",
                table: "SupplierMPosition",
                column: "ParameterManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMPosition_PartDimensionId",
                table: "SupplierMPosition",
                column: "PartDimensionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMPosition_PartMPositionToleranceId",
                table: "SupplierMPosition",
                column: "PartMPositionToleranceId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMPosition_SupplierMeasurementSubmissionId",
                table: "SupplierMPosition",
                column: "SupplierMeasurementSubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMPosition_UOMId",
                table: "SupplierMPosition",
                column: "UOMId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMPositionActual_CreatedBy",
                table: "SupplierMPositionActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMPositionActual_LastUpdatedBy",
                table: "SupplierMPositionActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMPositionActual_SupplierMPositionId",
                table: "SupplierMPositionActual",
                column: "SupplierMPositionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierMPositionActual");

            migrationBuilder.DropTable(
                name: "SupplierMPosition");

            migrationBuilder.DropTable(
                name: "DimensionDefault");

            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "SupplierTestReport");

            migrationBuilder.DropColumn(
                name: "ManufacturePartNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.AlterColumn<string>(
                name: "ResultDescription",
                table: "SupplierMeasurementSubmission",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PartId",
                table: "SupplierMeasurementSubmission",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "PartTestReportParameter",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PartManufacturePartNumber",
                columns: table => new
                {
                    PartManufacturePartNumberId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    MPN = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    PartId = table.Column<int>(type: "integer", nullable: false),
                    StatusTypeId = table.Column<byte>(type: "smallint", nullable: false, defaultValue: (byte)1)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartManufacturePartNumber", x => x.PartManufacturePartNumberId);
                    table.ForeignKey(
                        name: "FK_PartManufacturePartNumber_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartManufacturePartNumber_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartManufacturePartNumber_PartId",
                        column: x => x.PartId,
                        principalTable: "Part",
                        principalColumn: "PartId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PartInspectionManufacturePartNumber",
                columns: table => new
                {
                    PartInspectionManufacturePartNumberId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    PartManufacturePartNumberId = table.Column<int>(type: "integer", nullable: false),
                    SAPPartInspectionPlanId = table.Column<int>(type: "integer", nullable: false),
                    StatusTypeId = table.Column<byte>(type: "smallint", nullable: false, defaultValue: (byte)1)
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

            migrationBuilder.CreateTable(
                name: "SupplierMeasurementManufacturePartNumber",
                columns: table => new
                {
                    SMSManufacturePartNumberId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    PartManufacturePartNumberId = table.Column<int>(type: "integer", nullable: false),
                    StatusTypeId = table.Column<byte>(type: "smallint", nullable: false, defaultValue: (byte)1),
                    SupplierMeasurementSubmissionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierMeasurementManufacturePartNumber", x => x.SMSManufacturePartNumberId);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementManufacturePartNumber_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementManufacturePartNumber_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementManufacturePartNumber_PartManufacturePar~",
                        column: x => x.PartManufacturePartNumberId,
                        principalTable: "PartManufacturePartNumber",
                        principalColumn: "PartManufacturePartNumberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMeasurementManufacturePartNumber_SupplierMeasuremen~",
                        column: x => x.SupplierMeasurementSubmissionId,
                        principalTable: "SupplierMeasurementSubmission",
                        principalColumn: "SupplierMeasurementSubmissionId",
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

            migrationBuilder.CreateIndex(
                name: "IX_PartManufacturePartNumber_CreatedBy",
                table: "PartManufacturePartNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartManufacturePartNumber_LastUpdatedBy",
                table: "PartManufacturePartNumber",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartManufacturePartNumber_PartId",
                table: "PartManufacturePartNumber",
                column: "PartId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementManufacturePartNumber_CreatedBy",
                table: "SupplierMeasurementManufacturePartNumber",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementManufacturePartNumber_LastUpdatedBy",
                table: "SupplierMeasurementManufacturePartNumber",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementManufacturePartNumber_PartManufacturePar~",
                table: "SupplierMeasurementManufacturePartNumber",
                column: "PartManufacturePartNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementManufacturePartNumber_SupplierMeasuremen~",
                table: "SupplierMeasurementManufacturePartNumber",
                column: "SupplierMeasurementSubmissionId");
        }
    }
}
