using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class BowTwistFormulaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BowTwistFormula",
                columns: table => new
                {
                    BowTwistFormulaId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Equation = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BowTwistFormula", x => x.BowTwistFormulaId);
                    table.ForeignKey(
                        name: "FK_BowTwistFormula_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BowTwistFormula_User_LastUpdatedBy",
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
                    { 422, "Admin_BowTwistFormula_Can_Access", "AdminBowTwistFormulaCanAccess" },
                    { 423, "Admin_BowTwistFormula_Can_Create", "AdminBowTwistFormulaCanCreate" },
                    { 424, "Admin_BowTwistFormula_Can_Update", "AdminBowTwistFormulaCanUpdate" },
                    { 425, "Admin_BowTwistFormula_Can_Delete", "AdminBowTwistFormulaCanDelete" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BowTwistFormula_CreatedBy",
                table: "BowTwistFormula",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BowTwistFormula_LastUpdatedBy",
                table: "BowTwistFormula",
                column: "LastUpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BowTwistFormula");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 425);
        }
    }
}
