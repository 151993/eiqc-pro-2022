using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class CertificateTypeParameterMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CertificateTypeParameter",
                columns: table => new
                {
                    CertificateTypeParameterId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    CertificateTypeId = table.Column<int>(nullable: false),
                    ParameterName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateTypeParameter", x => x.CertificateTypeParameterId);
                    table.ForeignKey(
                        name: "FK_CertificateTypeParameter_CertificateTypeId",
                        column: x => x.CertificateTypeId,
                        principalTable: "CertificateType",
                        principalColumn: "CertificateTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CertificateTypeParameter_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CertificateTypeParameter_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CertificateTypeParameter_CertificateTypeId",
                table: "CertificateTypeParameter",
                column: "CertificateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CertificateTypeParameter_CreatedBy",
                table: "CertificateTypeParameter",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CertificateTypeParameter_LastUpdatedBy",
                table: "CertificateTypeParameter",
                column: "LastUpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificateTypeParameter");
        }
    }
}
