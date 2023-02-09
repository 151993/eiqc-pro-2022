using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierFunctionAttributeActual_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupplierFunctionAttributeActual",
                columns: table => new
                {
                    SupplierFunctionAttributeActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierFunctionAttributeId = table.Column<int>(nullable: false),
                    ActualTextName = table.Column<string>(nullable: true),
                    ActualTextValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierFunctionAttributeActual", x => x.SupplierFunctionAttributeActualId);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionAttributeActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionAttributeActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierFunctionAttributeActual_SupplierFunctionAttributeId",
                        column: x => x.SupplierFunctionAttributeId,
                        principalTable: "SupplierFunctionAttribute",
                        principalColumn: "SupplierFunctionAttributeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionAttributeActual_CreatedBy",
                table: "SupplierFunctionAttributeActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionAttributeActual_LastUpdatedBy",
                table: "SupplierFunctionAttributeActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierFunctionAttributeActual_SupplierFunctionAttributeId",
                table: "SupplierFunctionAttributeActual",
                column: "SupplierFunctionAttributeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierFunctionAttributeActual");
        }
    }
}
