using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class PartInsectionPlanDefine_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_PCCode_PCCodeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_Part_PartId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_PCCodeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_PartId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "CertificateType",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "InspectionCharac",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "MstrChar",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "PCCodeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "PartId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "QMControlKey",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SamplingProc",
                table: "SAPPartInspectionPlan");

            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.AddColumn<int>(
                name: "AdminCertificationId",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CommodityId",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DataTypeId",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DivisionModelNumber",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrawingDescription",
                table: "SAPPartInspectionPlan",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DrawingNumber",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DrawingRevisionNumber",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GenWI",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IP",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsSafePart",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "JabilOwnerContact",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerPartNumber",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManufacturerRevisionPartNumber",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartDescription",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PartRevisionNumber",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductLifeCycleStageId",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RefDoc",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecDescription",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecRevisionNumber",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SupplierEmail",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupplierName",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SupplierPhoneNumber",
                table: "SAPPartInspectionPlan",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkCellId",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "Part",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.CreateTable(
                name: "DataType",
                columns: table => new
                {
                    DataTypeId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataType", x => x.DataTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PartInspectionDrawingAttachment",
                columns: table => new
                {
                    PartInspectionDrawingAttachmentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SAPPartInspectionPlanId = table.Column<int>(nullable: false),
                    AttachmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartInspectionDrawingAttachment", x => x.PartInspectionDrawingAttachmentId);
                    table.ForeignKey(
                        name: "FK_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalTable: "Attachment",
                        principalColumn: "AttachmentId");
                    table.ForeignKey(
                        name: "FK_PartInspectionDrawingAttachment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionDrawingAttachment_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlan_SAPPartInspectionPlanId",
                        column: x => x.SAPPartInspectionPlanId,
                        principalTable: "SAPPartInspectionPlan",
                        principalColumn: "SAPPartInspectionPlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartInspectionSpecAttachment",
                columns: table => new
                {
                    PartInspectionSpecAttachmentId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    SAPPartInspectionPlanId = table.Column<int>(nullable: false),
                    AttachmentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartInspectionSpecAttachment", x => x.PartInspectionSpecAttachmentId);
                    table.ForeignKey(
                        name: "FK_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalTable: "Attachment",
                        principalColumn: "AttachmentId");
                    table.ForeignKey(
                        name: "FK_PartInspectionSpecAttachment_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionSpecAttachment_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SAPPartInspectionPlan_SAPPartInspectionPlanId",
                        column: x => x.SAPPartInspectionPlanId,
                        principalTable: "SAPPartInspectionPlan",
                        principalColumn: "SAPPartInspectionPlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductLifeCycleStage",
                columns: table => new
                {
                    ProductLifeCycleStageId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLifeCycleStage", x => x.ProductLifeCycleStageId);
                });

            migrationBuilder.InsertData(
                table: "DataType",
                columns: new[] { "DataTypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "CTQ", "CTQ" },
                    { 2, "NON CTQ", "NON_CTQ" }
                });

            migrationBuilder.InsertData(
                table: "ProductLifeCycleStage",
                columns: new[] { "ProductLifeCycleStageId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Prototype", "Prototype" },
                    { 2, "NPI", "NPI" },
                    { 3, "Product Part Qualification", "Product_Part_Qualification" },
                    { 4, "Production Ramp Up", "Production_Ramp_Up" },
                    { 5, "Mass Production", "Mass_Production" },
                    { 6, "Product_Phase_Out", "Product_Phase_Out" },
                    { 7, "Other", "Other" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_AdminCertificationId",
                table: "SAPPartInspectionPlan",
                column: "AdminCertificationId");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_CommodityId",
                table: "SAPPartInspectionPlan",
                column: "CommodityId");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_WorkCellId",
                table: "SAPPartInspectionPlan",
                column: "WorkCellId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionDrawingAttachment_AttachmentId",
                table: "PartInspectionDrawingAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionDrawingAttachment_CreatedBy",
                table: "PartInspectionDrawingAttachment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionDrawingAttachment_LastUpdatedBy",
                table: "PartInspectionDrawingAttachment",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionDrawingAttachment_SAPPartInspectionPlanId",
                table: "PartInspectionDrawingAttachment",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionSpecAttachment_AttachmentId",
                table: "PartInspectionSpecAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionSpecAttachment_CreatedBy",
                table: "PartInspectionSpecAttachment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionSpecAttachment_LastUpdatedBy",
                table: "PartInspectionSpecAttachment",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionSpecAttachment_SAPPartInspectionPlanId",
                table: "PartInspectionSpecAttachment",
                column: "SAPPartInspectionPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_AdminCertificationId",
                table: "SAPPartInspectionPlan",
                column: "AdminCertificationId",
                principalTable: "AdminCertification",
                principalColumn: "AdminCertificationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_CommodityId",
                table: "SAPPartInspectionPlan",
                column: "CommodityId",
                principalTable: "Commodity",
                principalColumn: "CommodityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_WorkCellId",
                table: "SAPPartInspectionPlan",
                column: "WorkCellId",
                principalTable: "WorkCell",
                principalColumn: "WorkCellId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_AttachmentId",
                table: "AdminCertificationAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_AdminCertificationId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_CommodityId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropForeignKey(
                name: "FK_SAPPartInspectionPlan_WorkCellId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropTable(
                name: "DataType");

            migrationBuilder.DropTable(
                name: "PartInspectionDrawingAttachment");

            migrationBuilder.DropTable(
                name: "PartInspectionSpecAttachment");

            migrationBuilder.DropTable(
                name: "ProductLifeCycleStage");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_AdminCertificationId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_CommodityId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropIndex(
                name: "IX_SAPPartInspectionPlan_WorkCellId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "AdminCertificationId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "CommodityId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "DataTypeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "DivisionModelNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "DrawingDescription",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "DrawingNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "DrawingRevisionNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "GenWI",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "IP",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "IsSafePart",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "JabilOwnerContact",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "ManufacturerPartNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "ManufacturerRevisionPartNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "PartDescription",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "PartRevisionNumber",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "ProductLifeCycleStageId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "RefDoc",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SpecDescription",
                table: "SAPPartInspectionPlan");

            migrationBuilder.DropColumn(
                name: "SpecRevisionNumber",
                table: "SAPPartInspectionPlan");

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
                name: "WorkCellId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "SAPPartInspectionPlan",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValue: (byte)1);

            migrationBuilder.AddColumn<string>(
                name: "CertificateType",
                table: "SAPPartInspectionPlan",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InspectionCharac",
                table: "SAPPartInspectionPlan",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MstrChar",
                table: "SAPPartInspectionPlan",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PCCodeId",
                table: "SAPPartInspectionPlan",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PartId",
                table: "SAPPartInspectionPlan",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "QMControlKey",
                table: "SAPPartInspectionPlan",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SamplingProc",
                table: "SAPPartInspectionPlan",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "StatusTypeId",
                table: "Part",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldDefaultValue: (byte)1);

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_PCCodeId",
                table: "SAPPartInspectionPlan",
                column: "PCCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_SAPPartInspectionPlan_PartId",
                table: "SAPPartInspectionPlan",
                column: "PartId");

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_PCCode_PCCodeId",
                table: "SAPPartInspectionPlan",
                column: "PCCodeId",
                principalTable: "PCCode",
                principalColumn: "PCCodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SAPPartInspectionPlan_Part_PartId",
                table: "SAPPartInspectionPlan",
                column: "PartId",
                principalTable: "Part",
                principalColumn: "PartId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
