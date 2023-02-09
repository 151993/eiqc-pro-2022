using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class Instrument_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "InstrumentType");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Instrument");

            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Instrument");

            migrationBuilder.DropColumn(
                name: "ExpireDate",
                table: "Instrument");

            migrationBuilder.DropColumn(
                name: "LastTime",
                table: "Instrument");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Instrument");

           

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "InstrumentType",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "InstrumentType",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Instrument",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstrumentNo",
                table: "Instrument",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ValidDate",
                table: "Instrument",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.CreateIndex(
                name: "UK_InstrumentType_Code",
                table: "InstrumentType",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_Instrument_InstrumentNo",
                table: "Instrument",
                column: "InstrumentNo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UK_InstrumentType_Code",
                table: "InstrumentType");

            migrationBuilder.DropIndex(
                name: "UK_Instrument_InstrumentNo",
                table: "Instrument");
           

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Instrument");

            migrationBuilder.DropColumn(
                name: "InstrumentNo",
                table: "Instrument");

            migrationBuilder.DropColumn(
                name: "ValidDate",
                table: "Instrument");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "InstrumentType",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "InstrumentType",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "InstrumentType",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Instrument",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Instrument",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ExpireDate",
                table: "Instrument",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastTime",
                table: "Instrument",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Instrument",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }
    }
}
