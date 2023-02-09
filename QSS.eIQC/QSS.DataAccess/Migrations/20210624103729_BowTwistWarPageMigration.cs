using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class BowTwistWarPageMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WarPageId",
                table: "BowTwistFormula",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WarPage",
                columns: table => new
                {
                    WarPageId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(maxLength: 250, nullable: true),
                    IsEnabled = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarPage", x => x.WarPageId);
                });

            migrationBuilder.InsertData(
                table: "WarPage",
                columns: new[] { "WarPageId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Bow L", "Bow_L" },
                    { 2, "Bow W", "Bow_W" },
                    { 3, "Twist", "Twist" },
                    { 4, "Specific Warpage L", "Specific_Warpage_L" },
                    { 5, "Specific Warpage W", "Specific_Warpage_W" },
                    { 6, "Specific Twist", "Specific_Twist" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BowTwistFormula_WarPageId",
                table: "BowTwistFormula",
                column: "WarPageId");

            migrationBuilder.AddForeignKey(
                name: "FK_BowTwistFormula_WarPage_WarPageId",
                table: "BowTwistFormula",
                column: "WarPageId",
                principalTable: "WarPage",
                principalColumn: "WarPageId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BowTwistFormula_WarPage_WarPageId",
                table: "BowTwistFormula");

            migrationBuilder.DropTable(
                name: "WarPage");

            migrationBuilder.DropIndex(
                name: "IX_BowTwistFormula_WarPageId",
                table: "BowTwistFormula");

            migrationBuilder.DropColumn(
                name: "WarPageId",
                table: "BowTwistFormula");
        }
    }
}
