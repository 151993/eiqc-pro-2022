using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class PartInspectionBowTwistParametersMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartBowTwistParameter");

            migrationBuilder.AlterColumn<string>(
                name: "SpecRevisionNumber",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SpecNumber",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpecDescription",
                table: "SAPPartInspectionPlan",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DrawingDescription",
                table: "SAPPartInspectionPlan",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SpecTypeId",
                table: "SAPPartInspectionPlan",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PartInspectionBowTwistParameter",
                columns: table => new
                {
                    PartBowTwistParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SAPPartInspectionPlanId = table.Column<int>(nullable: false),
                    DataTypeId = table.Column<int>(nullable: false),
                    BowTwistFormulaId = table.Column<int>(nullable: false),
                    Spec = table.Column<decimal>(maxLength: 50, nullable: false),
                    Length = table.Column<decimal>(maxLength: 50, nullable: false),
                    Width = table.Column<decimal>(maxLength: 50, nullable: false),
                    Unit = table.Column<int>(maxLength: 50, nullable: false),
                    UpperLimit = table.Column<decimal>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartInspectionBowTwistParameter", x => x.PartBowTwistParameterId);
                    table.ForeignKey(
                        name: "FK_PIBowTwist_BowTwistFormulaId",
                        column: x => x.BowTwistFormulaId,
                        principalTable: "BowTwistFormula",
                        principalColumn: "BowTwistFormulaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionBowTwistParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionBowTwistParameter_DataType_DataTypeId",
                        column: x => x.DataTypeId,
                        principalTable: "DataType",
                        principalColumn: "DataTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartInspectionBowTwistParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PIBowTwist_SAPPartInspectionPlanId",
                        column: x => x.SAPPartInspectionPlanId,
                        principalTable: "SAPPartInspectionPlan",
                        principalColumn: "SAPPartInspectionPlanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionBowTwistParameter_BowTwistFormulaId",
                table: "PartInspectionBowTwistParameter",
                column: "BowTwistFormulaId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionBowTwistParameter_CreatedBy",
                table: "PartInspectionBowTwistParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionBowTwistParameter_DataTypeId",
                table: "PartInspectionBowTwistParameter",
                column: "DataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionBowTwistParameter_LastUpdatedBy",
                table: "PartInspectionBowTwistParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartInspectionBowTwistParameter_SAPPartInspectionPlanId",
                table: "PartInspectionBowTwistParameter",
                column: "SAPPartInspectionPlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PartInspectionBowTwistParameter");

            migrationBuilder.DropColumn(
                name: "SpecTypeId",
                table: "SAPPartInspectionPlan");

            migrationBuilder.AlterColumn<string>(
                name: "SpecRevisionNumber",
                table: "SAPPartInspectionPlan",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SpecNumber",
                table: "SAPPartInspectionPlan",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "SpecDescription",
                table: "SAPPartInspectionPlan",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "DrawingDescription",
                table: "SAPPartInspectionPlan",
                type: "character varying(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 256);

            migrationBuilder.CreateTable(
                name: "PartBowTwistParameter",
                columns: table => new
                {
                    PartBowTwistParameterId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "1"),
                    Length = table.Column<string>(type: "character varying(53)", maxLength: 53, nullable: true),
                    PartNo = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    Spec = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    StatusTypeId = table.Column<byte>(type: "smallint", nullable: false),
                    Unit = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    UpperLimit = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    WarpType = table.Column<int>(type: "integer", nullable: true),
                    Width = table.Column<string>(type: "character varying(53)", maxLength: 53, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartBowTwistParameter", x => x.PartBowTwistParameterId);
                    table.ForeignKey(
                        name: "FK_PartBowTwistParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartBowTwistParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartBowTwistParameter_PartNo",
                        column: x => x.PartNo,
                        principalTable: "Part",
                        principalColumn: "PartNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartBowTwistParameter_CreatedBy",
                table: "PartBowTwistParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartBowTwistParameter_LastUpdatedBy",
                table: "PartBowTwistParameter",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PartBowTwistParameter_PartNo",
                table: "PartBowTwistParameter",
                column: "PartNo");
        }
    }
}
