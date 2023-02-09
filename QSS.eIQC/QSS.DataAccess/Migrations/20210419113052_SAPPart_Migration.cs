using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SAPPart_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManufacturerCode",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "ManufacturerType",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "MaterialGroup",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "ValidFrom",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "ValidTo",
                table: "Part");

            migrationBuilder.AddColumn<string>(
                name: "PartDescription",
                table: "Part",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Part",
                nullable: true);

            migrationBuilder.InsertData(
                table: "SAPDataSyncDetails",
                columns: new[] { "SAPDataSyncDetailsId", "LastSyncDate", "Name" },
                values: new object[] { 2, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 462, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, 0, 0, 0, 0)), "2" });

            migrationBuilder.InsertData(
                table: "SyncSAPDataType",
                columns: new[] { "SyncSAPDataTypeId", "Description", "Name" },
                values: new object[] { 2, "Last-Sync-Part", "Last_Sync_Part" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SAPDataSyncDetails",
                keyColumn: "SAPDataSyncDetailsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SyncSAPDataType",
                keyColumn: "SyncSAPDataTypeId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "PartDescription",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Part");

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerCode",
                table: "Part",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerType",
                table: "Part",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaterialGroup",
                table: "Part",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ValidFrom",
                table: "Part",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ValidTo",
                table: "Part",
                type: "timestamp with time zone",
                nullable: true);
        }
    }
}
