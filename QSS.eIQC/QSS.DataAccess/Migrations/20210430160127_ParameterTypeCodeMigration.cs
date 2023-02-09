using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class ParameterTypeCodeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParameterTypeCode",
                columns: table => new
                {
                    ParameterTypeCodeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    ParameterManagementTypeId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterTypeCode", x => x.ParameterTypeCodeId);
                    table.ForeignKey(
                        name: "FK_ParameterTypeCode_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParameterTypeCode_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParameterTypeCode_ParameterManagementType_ParameterManageme~",
                        column: x => x.ParameterManagementTypeId,
                        principalTable: "ParameterManagementType",
                        principalColumn: "ParameterManagementTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParameterTypePcCode",
                columns: table => new
                {
                    ParameterTypePcCodeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    ParameterTypeCodeId = table.Column<int>(nullable: false),
                    PCCodeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParameterTypePcCode", x => x.ParameterTypePcCodeId);
                    table.ForeignKey(
                        name: "FK_ParameterTypePcCode_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParameterTypePcCode_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParameterTypePcCode_PCCodeId",
                        column: x => x.PCCodeId,
                        principalTable: "PCCode",
                        principalColumn: "PCCodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParameterTypeCode_ParameterTypeCodeId",
                        column: x => x.ParameterTypeCodeId,
                        principalTable: "ParameterTypeCode",
                        principalColumn: "ParameterTypeCodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ParameterManagementType",
                columns: new[] { "ParameterManagementTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 5, "FUN", "FUN" },
                    { 6, "MicroSection", "MicroSection" }
                });

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 406, "Admin_ParameterTypeCode_Can_Access", "AdminParameterTypeCodeCanAccess" },
                    { 407, "Admin_ParameterTypeCode_Can_Create", "AdminParameterTypeCodeCanCreate" },
                    { 408, "Admin_ParameterTypeCode_Can_Update", "AdminParameterTypeCodeCanUpdate" },
                    { 409, "Admin_ParameterTypeCode_Can_Delete", "AdminParameterTypeCodeCanDelete" }
                });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "RolePermissionId", "PermissionTypeId", "RoleId" },
                values: new object[,]
                {
                    { 796, 406, 1 },
                    { 797, 407, 1 },
                    { 798, 408, 1 },
                    { 799, 409, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParameterTypeCode_CreatedBy",
                table: "ParameterTypeCode",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterTypeCode_LastUpdatedBy",
                table: "ParameterTypeCode",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterTypeCode_ParameterManagementTypeId",
                table: "ParameterTypeCode",
                column: "ParameterManagementTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterTypePcCode_CreatedBy",
                table: "ParameterTypePcCode",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterTypePcCode_LastUpdatedBy",
                table: "ParameterTypePcCode",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterTypePcCode_PCCodeId",
                table: "ParameterTypePcCode",
                column: "PCCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParameterTypePcCode_ParameterTypeCodeId",
                table: "ParameterTypePcCode",
                column: "ParameterTypeCodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParameterTypePcCode");

            migrationBuilder.DropTable(
                name: "ParameterTypeCode");

            migrationBuilder.DeleteData(
                table: "ParameterManagementType",
                keyColumn: "ParameterManagementTypeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ParameterManagementType",
                keyColumn: "ParameterManagementTypeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 799);
        }
    }
}
