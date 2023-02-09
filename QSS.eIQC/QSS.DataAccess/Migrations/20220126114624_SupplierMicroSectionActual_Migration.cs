using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SupplierMicroSectionActual_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "SupplierMicroSectionActual",
                columns: table => new
                {
                    SupplierMicroSectionActualId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false),
                    SupplierMicrosectionId = table.Column<int>(nullable: false),
                    ActualTextName = table.Column<string>(nullable: true),
                    ActualTextValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierMicroSectionActual", x => x.SupplierMicroSectionActualId);
                    table.ForeignKey(
                        name: "FK_SupplierMicroSectionActual_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMicroSectionActual_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SupplierMicroSectionActual_SupplierMicrosectionId",
                        column: x => x.SupplierMicrosectionId,
                        principalTable: "SupplierMicrosection",
                        principalColumn: "SupplierMicrosectionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMicroSectionActual_CreatedBy",
                table: "SupplierMicroSectionActual",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMicroSectionActual_LastUpdatedBy",
                table: "SupplierMicroSectionActual",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMicroSectionActual_SupplierMicrosectionId",
                table: "SupplierMicroSectionActual",
                column: "SupplierMicrosectionId");

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DropTable(
                name: "SupplierMicroSectionActual");

            
        }
    }
}
