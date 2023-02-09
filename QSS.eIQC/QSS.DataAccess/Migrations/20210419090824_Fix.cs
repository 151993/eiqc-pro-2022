using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "SyncSAPDataType",
                keyColumn: "SyncSAPDataTypeId",
                keyValue: 1,
                column: "Description",
                value: "Last-Sync-Material-Group");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 393);

            migrationBuilder.UpdateData(
                table: "SyncSAPDataType",
                keyColumn: "SyncSAPDataTypeId",
                keyValue: 1,
                column: "Description",
                value: "Last-Sync-Materia-Group");
        }
    }
}
