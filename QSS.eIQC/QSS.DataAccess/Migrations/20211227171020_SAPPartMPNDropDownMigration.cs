using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SAPPartMPNDropDownMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SAPMPN_PMPNId",
                table: "PartInspectionManufacturePartNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMeasurementManufacturePartNumber_PartManufacturePar~",
                table: "SupplierMeasurementManufacturePartNumber");

            migrationBuilder.DropTable(
                name: "PartManufacturePartNumber");

            migrationBuilder.DropIndex(
                name: "IX_SupplierMeasurementManufacturePartNumber_PartManufacturePar~",
                table: "SupplierMeasurementManufacturePartNumber");

            migrationBuilder.DropIndex(
                name: "IX_PartInspectionManufacturePartNumber_PartManufacturePartNumb~",
                table: "PartInspectionManufacturePartNumber");

            migrationBuilder.DropColumn(
                name: "PartId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "PartManufacturePartNumberId",
                table: "SupplierMeasurementManufacturePartNumber");

            migrationBuilder.DropColumn(
                name: "PartManufacturePartNumberId",
                table: "PartInspectionManufacturePartNumber");

            migrationBuilder.AddColumn<int>(
                name: "PartInspectionManufacturePartNumberId",
                table: "SupplierMeasurementManufacturePartNumber",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MPN",
                table: "PartInspectionManufacturePartNumber",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementManufacturePartNumber_PartInspectionManu~",
                table: "SupplierMeasurementManufacturePartNumber",
                column: "PartInspectionManufacturePartNumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMeasurementManufacturePartNumber_PartInspectionManu~",
                table: "SupplierMeasurementManufacturePartNumber",
                column: "PartInspectionManufacturePartNumberId",
                principalTable: "PartInspectionManufacturePartNumber",
                principalColumn: "PartInspectionManufacturePartNumberId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMeasurementManufacturePartNumber_PartInspectionManu~",
                table: "SupplierMeasurementManufacturePartNumber");

            migrationBuilder.DropIndex(
                name: "IX_SupplierMeasurementManufacturePartNumber_PartInspectionManu~",
                table: "SupplierMeasurementManufacturePartNumber");

            migrationBuilder.DropColumn(
                name: "PartInspectionManufacturePartNumberId",
                table: "SupplierMeasurementManufacturePartNumber");

            migrationBuilder.DropColumn(
                name: "MPN",
                table: "PartInspectionManufacturePartNumber");

            migrationBuilder.AddColumn<int>(
                name: "PartId",
                table: "SupplierMeasurementSubmission",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartManufacturePartNumberId",
                table: "SupplierMeasurementManufacturePartNumber",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartManufacturePartNumberId",
                table: "PartInspectionManufacturePartNumber",
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

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementManufacturePartNumber_PartManufacturePar~",
                table: "SupplierMeasurementManufacturePartNumber",
                column: "PartManufacturePartNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionManufacturePartNumber_PartManufacturePartNumb~",
                table: "PartInspectionManufacturePartNumber",
                column: "PartManufacturePartNumberId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SAPMPN_PMPNId",
                table: "PartInspectionManufacturePartNumber",
                column: "PartManufacturePartNumberId",
                principalTable: "PartManufacturePartNumber",
                principalColumn: "PartManufacturePartNumberId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMeasurementManufacturePartNumber_PartManufacturePar~",
                table: "SupplierMeasurementManufacturePartNumber",
                column: "PartManufacturePartNumberId",
                principalTable: "PartManufacturePartNumber",
                principalColumn: "PartManufacturePartNumberId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
