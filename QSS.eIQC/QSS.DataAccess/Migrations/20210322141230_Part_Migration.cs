using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class Part_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Part_Customer_CustomerId",
                table: "Part");

            migrationBuilder.DropIndex(
                name: "IX_Part_CustomerId",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "LowerLimit1",
                table: "PartLPositionTolerance");

            migrationBuilder.DropColumn(
                name: "BackupSoftcopy",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "CAF",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "CAF_Backup",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "DCCTime",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "DCCUser",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "Division",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "GENWI",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "IPVersion",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "LPositionType",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "LastCAFName",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "LastIPVersion",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "LastTime",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "MPositionType",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "RefDoc",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "Remark",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "SafePartFlag",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "Supervisor",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "SupervisorTime",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Part");

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "PartTestReportParameter",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(25)");

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "PartResultOrientedParameter",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(25)");

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "PartMPositionTolerance",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(25)");

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "PartMicrosection",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(25)");

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "PartLPositionTolerance",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(25)");

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "PartCountParameter",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(25)");

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "Part",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "Commodity",
                table: "Part",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MPNMaterial",
                table: "Part",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Part",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerCode",
                table: "Part",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerPartNumber",
                table: "Part",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerType",
                table: "Part",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaskedMPN",
                table: "Part",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaterialGroup",
                table: "Part",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mediacode",
                table: "Part",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Site",
                table: "Part",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ValidFrom",
                table: "Part",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ValidTo",
                table: "Part",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "GRS",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(25)");

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "RolePermissionId", "PermissionTypeId", "RoleId" },
                values: new object[,]
                {
                    { 47, 46, 1 },
                    { 48, 47, 1 },
                    { 49, 48, 1 },
                    { 50, 49, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 50);

            migrationBuilder.DropColumn(
                name: "MPNMaterial",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "ManufacturerCode",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "ManufacturerPartNumber",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "ManufacturerType",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "MaskedMPN",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "MaterialGroup",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "Mediacode",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "Site",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "ValidFrom",
                table: "Part");

            migrationBuilder.DropColumn(
                name: "ValidTo",
                table: "Part");

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "PartTestReportParameter",
                type: "character varying(25)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "PartResultOrientedParameter",
                type: "character varying(25)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "PartMPositionTolerance",
                type: "character varying(25)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "PartMicrosection",
                type: "character varying(25)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "PartLPositionTolerance",
                type: "character varying(25)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<double>(
                name: "LowerLimit1",
                table: "PartLPositionTolerance",
                type: "double precision",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "PartCountParameter",
                type: "character varying(25)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "Part",
                type: "character varying(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Commodity",
                table: "Part",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BackupSoftcopy",
                table: "Part",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CAF",
                table: "Part",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CAF_Backup",
                table: "Part",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Part",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DCCTime",
                table: "Part",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DCCUser",
                table: "Part",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Division",
                table: "Part",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GENWI",
                table: "Part",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IPVersion",
                table: "Part",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LPositionType",
                table: "Part",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastCAFName",
                table: "Part",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastIPVersion",
                table: "Part",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastTime",
                table: "Part",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MPositionType",
                table: "Part",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RefDoc",
                table: "Part",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "Part",
                type: "character varying(350)",
                maxLength: 350,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SafePartFlag",
                table: "Part",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Supervisor",
                table: "Part",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "SupervisorTime",
                table: "Part",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Part",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PartNo",
                table: "GRS",
                type: "character varying(25)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Part_CustomerId",
                table: "Part",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Part_Customer_CustomerId",
                table: "Part",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
