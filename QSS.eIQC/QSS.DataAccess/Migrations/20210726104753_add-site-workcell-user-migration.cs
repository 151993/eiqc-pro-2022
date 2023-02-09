using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class addsiteworkcellusermigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "WorkCell",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SiteId",
                table: "User",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkCell_SiteId",
                table: "WorkCell",
                column: "SiteId");

            migrationBuilder.CreateIndex(
                name: "IX_User_SiteId",
                table: "User",
                column: "SiteId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_SiteId",
                table: "User",
                column: "SiteId",
                principalTable: "Site",
                principalColumn: "SiteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_SiteId",
                table: "WorkCell",
                column: "SiteId",
                principalTable: "Site",
                principalColumn: "SiteId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_SiteId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_SiteId",
                table: "WorkCell");

            migrationBuilder.DropIndex(
                name: "IX_WorkCell_SiteId",
                table: "WorkCell");

            migrationBuilder.DropIndex(
                name: "IX_User_SiteId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "WorkCell");

            migrationBuilder.DropColumn(
                name: "SiteId",
                table: "User");
        }
    }
}
