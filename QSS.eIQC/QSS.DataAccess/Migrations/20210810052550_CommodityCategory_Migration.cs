using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class CommodityCategory_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Commodity");

            migrationBuilder.AddColumn<int>(
                name: "CommodityCategoryId",
                table: "Commodity",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CommodityCategoryOptionId",
                table: "Commodity",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CommodityCategoryOption",
                columns: table => new
                {
                    CommodityCategoryOptionId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityCategoryOption", x => x.CommodityCategoryOptionId);
                });

            migrationBuilder.CreateTable(
                name: "CommodityCategoryType",
                columns: table => new
                {
                    CommodityCategoryTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityCategoryType", x => x.CommodityCategoryTypeId);
                });

            migrationBuilder.CreateTable(
                name: "CommodityCategory",
                columns: table => new
                {
                    CommodityCategoryId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    CommodityCategoryTypeId = table.Column<int>(nullable: true),
                    CommodityCategoryOptionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityCategory", x => x.CommodityCategoryId);
                    table.ForeignKey(
                        name: "FK_CommodityCategory_CommodityCategoryOptionId",
                        column: x => x.CommodityCategoryOptionId,
                        principalTable: "CommodityCategoryOption",
                        principalColumn: "CommodityCategoryOptionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommodityCategory_CommodityCategoryTypeId",
                        column: x => x.CommodityCategoryTypeId,
                        principalTable: "CommodityCategoryType",
                        principalColumn: "CommodityCategoryTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommodityCategory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommodityCategory_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CommodityCategoryOption",
                columns: new[] { "CommodityCategoryOptionId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Global", "Global" },
                    { 2, "Site Based", "SiteBased" }
                });

            migrationBuilder.InsertData(
                table: "CommodityCategoryType",
                columns: new[] { "CommodityCategoryTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Electrical", "Electrical" },
                    { 2, "Mechanical", "Mechanical" }
                });

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 430, "Admin_CommodityCategory_Can_Access", "AdminCommodityCategoryCanAccess" },
                    { 431, "Admin_CommodityCategory_Can_Create", "AdminCommodityCategoryCanCreate" },
                    { 432, "Admin_CommodityCategory_Can_Update", "AdminCommodityCategoryCanUpdate" },
                    { 433, "Admin_CommodityCategory_Can_Delete", "AdminCommodityCategoryCanDelete" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_CommodityCategoryId",
                table: "Commodity",
                column: "CommodityCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_CommodityCategoryOptionId",
                table: "Commodity",
                column: "CommodityCategoryOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityCategory_CommodityCategoryOptionId",
                table: "CommodityCategory",
                column: "CommodityCategoryOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityCategory_CommodityCategoryTypeId",
                table: "CommodityCategory",
                column: "CommodityCategoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityCategory_CreatedBy",
                table: "CommodityCategory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityCategory_LastUpdatedBy",
                table: "CommodityCategory",
                column: "LastUpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Commodity_CommodityCategoryId",
                table: "Commodity",
                column: "CommodityCategoryId",
                principalTable: "CommodityCategory",
                principalColumn: "CommodityCategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Commodity_CommodityCategoryOptionId",
                table: "Commodity",
                column: "CommodityCategoryOptionId",
                principalTable: "CommodityCategoryOption",
                principalColumn: "CommodityCategoryOptionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Commodity_CommodityCategoryId",
                table: "Commodity");

            migrationBuilder.DropForeignKey(
                name: "FK_Commodity_CommodityCategoryOptionId",
                table: "Commodity");

            migrationBuilder.DropTable(
                name: "CommodityCategory");

            migrationBuilder.DropTable(
                name: "CommodityCategoryOption");

            migrationBuilder.DropTable(
                name: "CommodityCategoryType");

            migrationBuilder.DropIndex(
                name: "IX_Commodity_CommodityCategoryId",
                table: "Commodity");

            migrationBuilder.DropIndex(
                name: "IX_Commodity_CommodityCategoryOptionId",
                table: "Commodity");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 433);

            migrationBuilder.DropColumn(
                name: "CommodityCategoryId",
                table: "Commodity");

            migrationBuilder.DropColumn(
                name: "CommodityCategoryOptionId",
                table: "Commodity");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Commodity",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
