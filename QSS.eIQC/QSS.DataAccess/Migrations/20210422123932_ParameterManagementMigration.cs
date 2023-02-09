using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class ParameterManagementMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "AdminCertification",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.CreateTable(
                name: "ParameterManagementType",
                columns: table => new
                {
                    ParameterManagementTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterManagementType", x => x.ParameterManagementTypeId);
                });

            migrationBuilder.CreateTable(
                name: "ParameterManagement",
                columns: table => new
                {
                    ParameterManagementId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: true),
                    ParameterManagementTypeId = table.Column<int>(nullable: false),
                    PCCodeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterManagement", x => x.ParameterManagementId);
                    table.ForeignKey(
                        name: "FK_ParameterManagement_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParameterManagement_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParameterManagement_PCCode_PCCodeId",
                        column: x => x.PCCodeId,
                        principalTable: "PCCode",
                        principalColumn: "PCCodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParameterManagement_ParameterManagementType_ParameterManage~",
                        column: x => x.ParameterManagementTypeId,
                        principalTable: "ParameterManagementType",
                        principalColumn: "ParameterManagementTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParameterManagementCommodity",
                columns: table => new
                {
                    ParameterManagementCommodityId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    ParameterManagementId = table.Column<int>(nullable: false),
                    CommodityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterManagementCommodity", x => x.ParameterManagementCommodityId);
                    table.ForeignKey(
                        name: "FK_ParameterManagementCommodity_CommodityId",
                        column: x => x.CommodityId,
                        principalTable: "Commodity",
                        principalColumn: "CommodityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParameterManagementCommodity_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParameterManagementCommodity_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParameterManagementCommodity_ParameterManagementId",
                        column: x => x.ParameterManagementId,
                        principalTable: "ParameterManagement",
                        principalColumn: "ParameterManagementId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ParameterManagementType",
                columns: new[] { "ParameterManagementTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Count", "Count" },
                    { 2, "Result-Oriented", "ResultOriented" },
                    { 3, "Measurement", "Measurement" },
                    { 4, "Text-Prepared", "TextPrepared" }
                });

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 398, "Admin_ParameterManagement_Can_Access", "AdminParameterManagementCanAccess" },
                    { 399, "Admin_ParameterManagement_Can_Create", "AdminParameterManagementCanCreate" },
                    { 400, "Admin_ParameterManagement_Can_Update", "AdminParameterManagementCanUpdate" },
                    { 401, "Admin_ParameterManagement_Can_Delete", "AdminParameterManagementCanDelete" }
                });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "RolePermissionId", "PermissionTypeId", "RoleId" },
                values: new object[,]
                {
                    { 788, 398, 1 },
                    { 789, 399, 1 },
                    { 790, 400, 1 },
                    { 791, 401, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParameterManagement_CreatedBy",
                table: "ParameterManagement",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterManagement_LastUpdatedBy",
                table: "ParameterManagement",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterManagement_PCCodeId",
                table: "ParameterManagement",
                column: "PCCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterManagement_ParameterManagementTypeId",
                table: "ParameterManagement",
                column: "ParameterManagementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterManagementCommodity_CommodityId",
                table: "ParameterManagementCommodity",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterManagementCommodity_CreatedBy",
                table: "ParameterManagementCommodity",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterManagementCommodity_LastUpdatedBy",
                table: "ParameterManagementCommodity",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterManagementCommodity_ParameterManagementId",
                table: "ParameterManagementCommodity",
                column: "ParameterManagementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParameterManagementCommodity");

            migrationBuilder.DropTable(
                name: "ParameterManagement");

            migrationBuilder.DropTable(
                name: "ParameterManagementType");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 791);

            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "AdminCertification",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValue: (byte)1);
        }
    }
}
