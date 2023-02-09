using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class RemoveCreatedLastUpdatedCommdityPartNumberSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommodityPartNumberSite_User_CreatedBy",
                table: "CommodityPartNumberSite");

            migrationBuilder.DropForeignKey(
                name: "FK_CommodityPartNumberSite_User_LastUpdatedBy",
                table: "CommodityPartNumberSite");

            migrationBuilder.DropIndex(
                name: "IX_CommodityPartNumberSite_CreatedBy",
                table: "CommodityPartNumberSite");

            migrationBuilder.DropIndex(
                name: "IX_CommodityPartNumberSite_LastUpdatedBy",
                table: "CommodityPartNumberSite");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "CommodityPartNumberSite");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CommodityPartNumberSite");

            migrationBuilder.DropColumn(
                name: "LastUpdated",
                table: "CommodityPartNumberSite");

            migrationBuilder.DropColumn(
                name: "LastUpdatedBy",
                table: "CommodityPartNumberSite");

            migrationBuilder.DropColumn(
                name: "StatusTypeId",
                table: "CommodityPartNumberSite");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "Created",
                table: "CommodityPartNumberSite",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "CommodityPartNumberSite",
                type: "integer",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastUpdated",
                table: "CommodityPartNumberSite",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<int>(
                name: "LastUpdatedBy",
                table: "CommodityPartNumberSite",
                type: "integer",
                nullable: false,
                defaultValueSql: "1");

            migrationBuilder.AddColumn<byte>(
                name: "StatusTypeId",
                table: "CommodityPartNumberSite",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)1);

            migrationBuilder.CreateIndex(
                name: "IX_CommodityPartNumberSite_CreatedBy",
                table: "CommodityPartNumberSite",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityPartNumberSite_LastUpdatedBy",
                table: "CommodityPartNumberSite",
                column: "LastUpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_CommodityPartNumberSite_User_CreatedBy",
                table: "CommodityPartNumberSite",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CommodityPartNumberSite_User_LastUpdatedBy",
                table: "CommodityPartNumberSite",
                column: "LastUpdatedBy",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
