using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierDateCodeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsChecked",
                table: "SupplierTestReport",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEnabled",
                table: "SupplierTestReport",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SupplierDateCodeId",
                table: "SupplierMeasurementSubmission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DateCodeLimit",
                table: "PartDateCode",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SupplierDateCode",
                columns: table => new
                {
                    SupplierDateCodeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    ManufactureDate = table.Column<DateTimeOffset>(nullable: true),
                    ManufactureDCWeeks = table.Column<int>(nullable: true),
                    ManufactureDCYears = table.Column<int>(nullable: true),
                    SurfaceFinishingDate = table.Column<DateTimeOffset>(nullable: true),
                    RemainingDays = table.Column<int>(nullable: true),
                    AcceptRejectId = table.Column<int>(nullable: true),
                    ShelfLifeMonths = table.Column<int>(nullable: true),
                    DateCodeDetails = table.Column<string>(nullable: true),
                    ExpireDate = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierDateCode", x => x.SupplierDateCodeId);
                    table.ForeignKey(
                        name: "FK_SupplierDateCode_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierDateCode_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementSubmission_SupplierDateCodeId",
                table: "SupplierMeasurementSubmission",
                column: "SupplierDateCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDateCode_CreatedBy",
                table: "SupplierDateCode",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierDateCode_LastUpdatedBy",
                table: "SupplierDateCode",
                column: "LastUpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMeasurementSubmission_SupplierDateCode_SupplierDate~",
                table: "SupplierMeasurementSubmission",
                column: "SupplierDateCodeId",
                principalTable: "SupplierDateCode",
                principalColumn: "SupplierDateCodeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMeasurementSubmission_SupplierDateCode_SupplierDate~",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropTable(
                name: "SupplierDateCode");

            migrationBuilder.DropIndex(
                name: "IX_SupplierMeasurementSubmission_SupplierDateCodeId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "IsChecked",
                table: "SupplierTestReport");

            migrationBuilder.DropColumn(
                name: "IsEnabled",
                table: "SupplierTestReport");

            migrationBuilder.DropColumn(
                name: "SupplierDateCodeId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "DateCodeLimit",
                table: "PartDateCode");
        }
    }
}
