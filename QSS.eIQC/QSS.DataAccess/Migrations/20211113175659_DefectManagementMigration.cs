using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class DefectManagementMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataType",
                table: "DefectType");

            migrationBuilder.DropColumn(
                name: "IsValid",
                table: "DefectType");

            migrationBuilder.DropColumn(
                name: "StatusTypeId",
                table: "DefectType");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "DefectType");

            migrationBuilder.AddColumn<int>(
                name: "DefectManagementId",
                table: "DefectType",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DefectTypeName",
                table: "DefectType",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DefectSection",
                columns: table => new
                {
                    DefectSectionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefectSection", x => x.DefectSectionId);
                });

            migrationBuilder.CreateTable(
                name: "DefectManagement",
                columns: table => new
                {
                    DefectManagementId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    DefectSectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefectManagement", x => x.DefectManagementId);
                    table.ForeignKey(
                        name: "FK_DefectManagement_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DefectManagement_DefectSection_DefectSectionId",
                        column: x => x.DefectSectionId,
                        principalTable: "DefectSection",
                        principalColumn: "DefectSectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DefectManagement_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DefectSection",
                columns: new[] { "DefectSectionId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Visual Inspection", "Visual_Inspection" },
                    { 2, "Test Report", "Test_Report" },
                    { 3, "Function Attribute", "Function_Attribute" },
                    { 4, "Function Variable", "Function_Variable" },
                    { 5, "Dimension Measurement", "Dimension_Measurement" },
                    { 6, "Bow-Twist", "Bow_Twist" },
                    { 7, "Date Code", "Date_Code" },
                    { 8, "Spec with MMC", "Spec_with_MMC" },
                    { 9, "Spec with LMC", "Spec_with_LMC" },
                    { 10, "Microsection", "Microsection" },
                    { 11, "SAP BASED", "SAP_BASED" }
                });

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 462, "Admin_DefectManagement_Can_Access", "AdminDefectManagementCanAccess" },
                    { 463, "Admin_DefectManagement_Can_Create", "AdminDefectManagementCanCreate" },
                    { 464, "Admin_DefectManagement_Can_Update", "AdminDefectManagementCanUpdate" },
                    { 465, "Admin_DefectManagement_Can_Delete", "AdminDefectManagementCanDelete" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DefectType_DefectManagementId",
                table: "DefectType",
                column: "DefectManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_DefectManagement_CreatedBy",
                table: "DefectManagement",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DefectManagement_DefectSectionId",
                table: "DefectManagement",
                column: "DefectSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_DefectManagement_LastUpdatedBy",
                table: "DefectManagement",
                column: "LastUpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_DefectType_DefectManagement_DefectManagementId",
                table: "DefectType",
                column: "DefectManagementId",
                principalTable: "DefectManagement",
                principalColumn: "DefectManagementId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DefectType_DefectManagement_DefectManagementId",
                table: "DefectType");

            migrationBuilder.DropTable(
                name: "DefectManagement");

            migrationBuilder.DropTable(
                name: "DefectSection");

            migrationBuilder.DropIndex(
                name: "IX_DefectType_DefectManagementId",
                table: "DefectType");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 465);

            migrationBuilder.DropColumn(
                name: "DefectManagementId",
                table: "DefectType");

            migrationBuilder.DropColumn(
                name: "DefectTypeName",
                table: "DefectType");

            migrationBuilder.AddColumn<string>(
                name: "DataType",
                table: "DefectType",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsValid",
                table: "DefectType",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<byte>(
                name: "StatusTypeId",
                table: "DefectType",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "DefectType",
                type: "text",
                nullable: true);
        }
    }
}
