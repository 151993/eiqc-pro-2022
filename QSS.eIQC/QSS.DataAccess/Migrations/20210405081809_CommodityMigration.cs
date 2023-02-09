using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class CommodityMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        { 
            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "Attachment",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.AlterColumn<int>(
                name: "LastUpdatedBy",
                table: "Attachment",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastUpdated",
                table: "Attachment",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Attachment",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Attachment",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTimeOffset),
                oldType: "timestamp with time zone");


            migrationBuilder.AddColumn<string>(
                name: "TempSavePath",
                table: "Attachment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Template",
                table: "Attachment",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Commodity",
                columns: table => new
                {
                    CommodityId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    PartNumber = table.Column<string>(maxLength: 50, nullable: false),
                    SAPCommodityId = table.Column<int>(maxLength: 5, nullable: false),
                    CommodityValidFrom = table.Column<DateTimeOffset>(nullable: false),
                    CommodityValidTo = table.Column<DateTimeOffset>(nullable: false),
                    PositionToleranceFrom = table.Column<decimal>(maxLength: 50, nullable: false),
                    PositionToleranceTo = table.Column<decimal>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Category = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 150, nullable: false),
                    AppearanceInspectionItem = table.Column<string>(maxLength: 20, nullable: false),
                    FunctionTestItem = table.Column<string>(maxLength: 20, nullable: true),
                    PositionToleranceIncrement = table.Column<decimal>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodity", x => x.CommodityId);
                    table.ForeignKey(
                        name: "FK_Commodity_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Commodity_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PermissionType",
                columns: new[] { "PermissionTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 386, "Admin_Commodity_Can_Access", "AdminCommodityCanAccess" },
                    { 387, "Admin_Commodity_Can_Create", "AdminCommodityCanCreate" },
                    { 388, "Admin_Commodity_Can_Update", "AdminCommodityCanUpdate" },
                    { 389, "Admin_Commodity_Can_Delete", "AdminCommodityCanDelete" }
                });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "RolePermissionId", "PermissionTypeId", "RoleId" },
                values: new object[,]
                {
                    { 776, 386, 1 },
                    { 777, 387, 1 },
                    { 778, 388, 1 },
                    { 779, 389, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_CreatedBy",
                table: "Commodity",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Commodity_LastUpdatedBy",
                table: "Commodity",
                column: "LastUpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Commodity");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 389);

            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "Attachment",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValue: (byte)1);

            migrationBuilder.AlterColumn<int>(
                name: "LastUpdatedBy",
                table: "Attachment",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastUpdated",
                table: "Attachment",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Attachment",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Created",
                table: "Attachment",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldDefaultValueSql: "CURRENT_TIMESTAMP");
          
        }
    }
}
