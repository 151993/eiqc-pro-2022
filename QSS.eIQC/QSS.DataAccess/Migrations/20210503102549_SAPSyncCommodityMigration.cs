using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SAPSyncCommodityMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SAPDataSyncDetails",
                columns: new[] { "SAPDataSyncDetailsId", "LastSyncDate", "Name" },
                values: new object[] { 3, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 462, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, 0, 0, 0, 0)), "3" });

            migrationBuilder.InsertData(
                table: "SyncSAPDataType",
                columns: new[] { "SyncSAPDataTypeId", "Description", "Name" },
                values: new object[] { 3, "Last-Sync-Commodity", "Last_Sync_Commodity" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SAPDataSyncDetails",
                keyColumn: "SAPDataSyncDetailsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SyncSAPDataType",
                keyColumn: "SyncSAPDataTypeId",
                keyValue: 3);
        }
    }
}
