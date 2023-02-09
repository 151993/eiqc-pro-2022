using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class DeleteConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Country_RegionId",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_CountryId",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Site_Location_LocationId",
                table: "Site");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteDivision_DivisionId",
                table: "SiteDivision");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_RegionId",
                table: "Country",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "RegionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_CountryId",
                table: "Location",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Site_LocationId",
                table: "Site",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteDivision_DivisionId",
                table: "SiteDivision",
                column: "DivisionId",
                principalTable: "Division",
                principalColumn: "DivisionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Country_RegionId",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Location_CountryId",
                table: "Location");

            migrationBuilder.DropForeignKey(
                name: "FK_Site_LocationId",
                table: "Site");

            migrationBuilder.DropForeignKey(
                name: "FK_SiteDivision_DivisionId",
                table: "SiteDivision");

            migrationBuilder.AddForeignKey(
                name: "FK_Country_RegionId",
                table: "Country",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "RegionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Location_CountryId",
                table: "Location",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Site_Location_LocationId",
                table: "Site",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SiteDivision_DivisionId",
                table: "SiteDivision",
                column: "DivisionId",
                principalTable: "Division",
                principalColumn: "DivisionId");
        }
    }
}
