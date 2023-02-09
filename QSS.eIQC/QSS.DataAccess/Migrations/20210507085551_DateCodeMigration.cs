using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class DateCodeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DateCode",
                columns: table => new
                {
                    DateCodeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    ManufactureDate = table.Column<DateTimeOffset>(nullable: false),
                    ShelfLifeMonths = table.Column<int>(nullable: false),
                    ManufactureDCWeeks = table.Column<int>(nullable: false),
                    ManufactureDCYears = table.Column<int>(nullable: false),
                    SurfaceFinishingDate = table.Column<DateTimeOffset>(nullable: true),
                    Details = table.Column<string>(maxLength: 50, nullable: true),
                    ExpireDate = table.Column<DateTimeOffset>(nullable: true)
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
                name: "IX_DateCode_CreatedBy",
                table: "DateCode",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DateCode_LastUpdatedBy",
                table: "DateCode",
                column: "LastUpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateCode");

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
