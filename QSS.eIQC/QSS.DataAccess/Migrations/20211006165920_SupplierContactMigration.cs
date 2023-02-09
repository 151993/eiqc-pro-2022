using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierContactMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupplierEmail",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SupplierName",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SupplierPhoneNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "PartNumber",
                table: "Commodity");

            migrationBuilder.DropColumn(
                name: "SiteNo",
                table: "Commodity");

            migrationBuilder.AddColumn<int>(
                name: "SupplierContactId",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CommodityPartNumberSite",
                columns: table => new
                {
                    CommodityPartNumberSiteId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    CommodityId = table.Column<int>(nullable: false),
                    PartNumber = table.Column<string>(maxLength: 100, nullable: false),
                    SiteNo = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommodityPartNumberSite", x => x.CommodityPartNumberSiteId);
                    table.ForeignKey(
                        name: "FK_Commodity_CommodityPartNumberSiteId",
                        column: x => x.CommodityId,
                        principalTable: "Commodity",
                        principalColumn: "CommodityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CommodityPartNumberSite_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommodityPartNumberSite_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "New Inspection Plan Submission Required By Supplier", "New_Inspection_Plan_Submission_Required_By_Supplier" });

            migrationBuilder.UpdateData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Pending approval By Jabil", "Pending_Approval_By_Jabil" });

            migrationBuilder.UpdateData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Approved By Jabil ", "Approved_By_Jabil" });

            migrationBuilder.InsertData(
                table: "StateType",
                columns: new[] { "StateTypeId", "Description", "Name" },
                values: new object[] { 5, "Rejected By Jabil", "Rejected_By_Jabil" });

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_SupplierContactId",
                table: "SAPPartInspectionPlan",
                column: "SupplierContactId");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_SupplierId",
                table: "SAPPartInspectionPlan",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityPartNumberSite_CommodityId",
                table: "CommodityPartNumberSite",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityPartNumberSite_CreatedBy",
                table: "CommodityPartNumberSite",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CommodityPartNumberSite_LastUpdatedBy",
                table: "CommodityPartNumberSite",
                column: "LastUpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_SupplierContactId",
                table: "SAPPartInspectionPlan",
                column: "SupplierContactId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_SupplierId",
                table: "SAPPartInspectionPlan",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_SupplierContactId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_SupplierId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropTable(
                name: "CommodityPartNumberSite");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_SupplierContactId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_SupplierId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DeleteData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "SupplierContactId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.AddColumn<string>(
                name: "SupplierEmail",
                table: "SAPPartInspectionPlan",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupplierName",
                table: "SAPPartInspectionPlan",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupplierPhoneNumber",
                table: "SAPPartInspectionPlan",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartNumber",
                table: "Commodity",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SiteNo",
                table: "Commodity",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Pending for approval", "Pending_For_Approval" });

            migrationBuilder.UpdateData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Approved", "Approved" });

            migrationBuilder.UpdateData(
                table: "StateType",
                keyColumn: "StateTypeId",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Rejected", "Rejected" });
        }
    }
}
