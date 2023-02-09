using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class InspectionTools_PCCode_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hyperlink",
                table: "PCCode");

            migrationBuilder.DropColumn(
                name: "PcCode",
                table: "PCCode");

            migrationBuilder.DropColumn(
                name: "NTID",
                table: "InspectionToolsType");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "InspectionToolsType");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "InspectionTools");

            migrationBuilder.DropColumn(
                name: "IToolsName",
                table: "InspectionTools");

            migrationBuilder.DropColumn(
                name: "LastTime",
                table: "InspectionTools");

            migrationBuilder.DropColumn(
                name: "NTID",
                table: "InspectionTools");

            migrationBuilder.DropColumn(
                name: "Valid",
                table: "InspectionTools");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "PCCode",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "PCCode",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "InspectionToolsType",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "InspectionToolsType",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "InspectionTools",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ValidDate",
                table: "InspectionTools",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InspectionToolsTypePcCode",
                columns: table => new
                {
                    InspectionToolsTypePcCodeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    InspectionToolsTypeId = table.Column<int>(nullable: false),
                    PCCodeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionToolsTypePcCode", x => x.InspectionToolsTypePcCodeId);
                    table.ForeignKey(
                        name: "FK_InspectionToolsTypePcCode_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InspectionToolsTypePcCode_InspectionToolsTypeId",
                        column: x => x.InspectionToolsTypeId,
                        principalTable: "InspectionToolsType",
                        principalColumn: "InspectionToolsTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InspectionToolsTypePcCode_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InspectionToolsTypePcCode_PCCodeId",
                        column: x => x.PCCodeId,
                        principalTable: "PCCode",
                        principalColumn: "PCCodeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UK_PCCode_Code",
                table: "PCCode",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_InspectionToolsType_Type",
                table: "InspectionToolsType",
                column: "Type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_InspectionToolsTypePcCode_CreatedBy",
                table: "InspectionToolsTypePcCode",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionToolsTypePcCode_InspectionToolsTypeId",
                table: "InspectionToolsTypePcCode",
                column: "InspectionToolsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionToolsTypePcCode_LastUpdatedBy",
                table: "InspectionToolsTypePcCode",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionToolsTypePcCode_PCCodeId",
                table: "InspectionToolsTypePcCode",
                column: "PCCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InspectionToolsTypePcCode");

            migrationBuilder.DropIndex(
                name: "UK_PCCode_Code",
                table: "PCCode");

            migrationBuilder.DropIndex(
                name: "UK_InspectionToolsType_Type",
                table: "InspectionToolsType");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "PCCode");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "PCCode");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "InspectionToolsType");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "InspectionToolsType");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "InspectionTools");

            migrationBuilder.DropColumn(
                name: "ValidDate",
                table: "InspectionTools");

            migrationBuilder.AddColumn<string>(
                name: "Hyperlink",
                table: "PCCode",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PcCode",
                table: "PCCode",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NTID",
                table: "InspectionToolsType",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "InspectionToolsType",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "InspectionTools",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "IToolsName",
                table: "InspectionTools",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastTime",
                table: "InspectionTools",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "NTID",
                table: "InspectionTools",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Valid",
                table: "InspectionTools",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
