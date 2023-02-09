using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class PartDateCodeDBSaveMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PartDateCode_PartNo",
                table: "PartDateCode");

            migrationBuilder.DropTable(
                name: "DateCode");

            migrationBuilder.DropIndex(
                name: "IX_PartDateCode_PartNo",
                table: "PartDateCode");

            migrationBuilder.DropColumn(
                name: "MFGDate",
                table: "PartDateCode");

            migrationBuilder.DropColumn(
                name: "PartNo",
                table: "PartDateCode");

            migrationBuilder.DropColumn(
                name: "Requirement",
                table: "PartDateCode");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "PartDateCode");

            migrationBuilder.DropColumn(
                name: "SupplierDC",
                table: "PartDateCode");

            migrationBuilder.AddColumn<int>(
                name: "PartDateCodeId",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "PartDateCode",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.AddColumn<string>(
                name: "DateCodeDetails",
                table: "PartDateCode",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ExpireDate",
                table: "PartDateCode",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManufactureDCWeeks",
                table: "PartDateCode",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManufactureDCYears",
                table: "PartDateCode",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ManufactureDate",
                table: "PartDateCode",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShelfLifeMonths",
                table: "PartDateCode",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "SurfaceFinishingDate",
                table: "PartDateCode",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_PartDateCodeId",
                table: "SAPPartInspectionPlan",
                column: "PartDateCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_PartDateCodeId",
                table: "SAPPartInspectionPlan",
                column: "PartDateCodeId",
                principalTable: "PartDateCode",
                principalColumn: "PartDateCodeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_PartDateCodeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_PartDateCodeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "PartDateCodeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "DateCodeDetails",
                table: "PartDateCode");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "PartDateCode");

            migrationBuilder.DropColumn(
                name: "ManufactureDCWeeks",
                table: "PartDateCode");

            migrationBuilder.DropColumn(
                name: "ManufactureDCYears",
                table: "PartDateCode");

            migrationBuilder.DropColumn(
                name: "ManufactureDate",
                table: "PartDateCode");

            migrationBuilder.DropColumn(
                name: "ShelfLifeMonths",
                table: "PartDateCode");

            migrationBuilder.DropColumn(
                name: "SurfaceFinishingDate",
                table: "PartDateCode");

            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "PartDateCode",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValue: (byte)1);

            migrationBuilder.AddColumn<string>(
                name: "MFGDate",
                table: "PartDateCode",
                type: "character varying(53)",
                maxLength: 53,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartNo",
                table: "PartDateCode",
                type: "character varying(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Requirement",
                table: "PartDateCode",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Result",
                table: "PartDateCode",
                type: "character varying(53)",
                maxLength: 53,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupplierDC",
                table: "PartDateCode",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DateCode",
                columns: table => new
                {
                    DateCodeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    Details = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ExpireDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LastUpdated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    ManufactureDCWeeks = table.Column<int>(type: "integer", nullable: false),
                    ManufactureDCYears = table.Column<int>(type: "integer", nullable: false),
                    ManufactureDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ShelfLifeMonths = table.Column<int>(type: "integer", nullable: false),
                    StatusTypeId = table.Column<byte>(type: "smallint", nullable: false, defaultValue: (byte)1),
                    SurfaceFinishingDate = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateCode", x => x.DateCodeId);
                    table.ForeignKey(
                        name: "FK_DateCode_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DateCode_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartDateCode_PartNo",
                table: "PartDateCode",
                column: "PartNo");

            migrationBuilder.CreateIndex(
                name: "IX_DateCode_CreatedBy",
                table: "DateCode",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DateCode_LastUpdatedBy",
                table: "DateCode",
                column: "LastUpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_PartDateCode_PartNo",
                table: "PartDateCode",
                column: "PartNo",
                principalTable: "Part",
                principalColumn: "PartNo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
