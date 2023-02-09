using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class WorkCellRemoveFKUser_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_SiteId",
                table: "User");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkCell_SiteId",
                table: "WorkCell",
                column: "SiteId",
                principalTable: "Site",
                principalColumn: "SiteId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkCell_SiteId",
                table: "WorkCell");

            migrationBuilder.AddForeignKey(
                name: "FK_User_SiteId",
                table: "User",
                column: "SiteId",
                principalTable: "Site",
                principalColumn: "SiteId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
