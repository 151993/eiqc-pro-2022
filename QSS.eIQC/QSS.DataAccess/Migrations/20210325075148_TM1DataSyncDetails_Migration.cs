using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class TM1DataSyncDetails_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "SyncTM1DataType",
                columns: table => new
                {
                    SyncTM1DataTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SyncTM1DataType", x => x.SyncTM1DataTypeId);
                });

            migrationBuilder.CreateTable(
                name: "TM1DataSyncDetails",
                columns: table => new
                {
                    TM1DataSyncDetailsId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    LastSyncDate = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TM1DataSyncDetails", x => x.TM1DataSyncDetailsId);
                });

            migrationBuilder.InsertData(
                table: "SyncTM1DataType",
                columns: new[] { "SyncTM1DataTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Last-Sync-TM1-Division", "Last_Sync_Division" },
                    { 2, "Last-Sync-TM1-Site", "Last_Sync_Site" }
                });

            migrationBuilder.InsertData(
                table: "TM1DataSyncDetails",
                columns: new[] { "TM1DataSyncDetailsId", "LastSyncDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 462, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, 0, 0, 0, 0)), "1" },
                    { 2, new DateTimeOffset(new DateTime(2000, 1, 1, 0, 0, 0, 462, DateTimeKind.Unspecified).AddTicks(9590), new TimeSpan(0, 0, 0, 0, 0)), "2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SyncTM1DataType");

            migrationBuilder.DropTable(
                name: "TM1DataSyncDetails");
        }
    }
}
