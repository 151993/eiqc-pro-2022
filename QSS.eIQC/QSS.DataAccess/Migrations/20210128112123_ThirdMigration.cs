using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserRoleId",
                table: "UserRole",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:IdentitySequenceOptions", "'6', '1', '', '', 'False', '1'")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "User",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:IdentitySequenceOptions", "'6', '1', '', '', 'False', '1'")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "RolePermissionId",
                table: "RolePermission",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:IdentitySequenceOptions", "'40', '1', '', '', 'False', '1'")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Role",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:IdentitySequenceOptions", "'2', '1', '', '', 'False', '1'")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    DivisionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.DivisionId);
                    table.ForeignKey(
                        name: "FK_Division_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Division_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    RegionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.RegionId);
                    table.ForeignKey(
                        name: "FK_Region_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Region_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkCell",
                columns: table => new
                {
                    WorkCellId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkCell", x => x.WorkCellId);
                    table.ForeignKey(
                        name: "FK_WorkCell_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkCell_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_Country_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Country_User_LastUpdatedBy",
                        column: x => x.LastUpdatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Country_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Created = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTimeOffset>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<int>(nullable: false, defaultValueSql: "1"),
                    StatusTypeId = table.Column<byte>(nullable: false, defaultValue: (byte)1),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Location_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Location_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Location_User_LastUpdatedBy",
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
                    { 16, "Admin_WorkCell_Can_Access", "AdminWorkCellCanAccess" },
                    { 39, "Admin_Location_Can_Delete", "AdminLocationCanDelete" },
                    { 38, "Admin_Location_Can_Update", "AdminLocationCanUpdate" },
                    { 37, "Admin_Location_Can_Create", "AdminLocationCanCreate" },
                    { 36, "Admin_Location_Can_Access", "AdminLocationCanAccess" },
                    { 34, "Admin_Division_Can_Update", "AdminDivisionCanUpdate" },
                    { 33, "Admin_Division_Can_Create", "AdminDivisionCanCreate" },
                    { 32, "Admin_Division_Can_Access", "AdminDivisionCanAccess" },
                    { 31, "Admin_Country_Can_Delete", "AdminCountryCanDelete" },
                    { 30, "Admin_Country_Can_Update", "AdminCountryCanUpdate" },
                    { 35, "Admin_Division_Can_Delete", "AdminDivisionCanDelete" },
                    { 28, "Admin_Country_Can_Access", "AdminCountryCanAccess" },
                    { 23, "Admin_Region_Can_Delete", "AdminRegionCanDelete" },
                    { 22, "Admin_Region_Can_Update", "AdminRegionCanUpdate" },
                    { 21, "Admin_Region_Can_Create", "AdminRegionCanCreate" },
                    { 20, "Admin_Region_Can_Access", "AdminRegionCanAccess" },
                    { 19, "Admin_WorkCell_Can_Delete", "AdminWorkCellCanDelete" },
                    { 18, "Admin_WorkCell_Can_Update", "AdminWorkCellCanUpdate" },
                    { 17, "Admin_WorkCell_Can_Create", "AdminWorkCellCanCreate" },
                    { 29, "Admin_Country_Can_Create", "AdminCountryCanCreate" }
                });

            migrationBuilder.InsertData(
                table: "RolePermission",
                columns: new[] { "RolePermissionId", "PermissionTypeId", "RoleId" },
                values: new object[,]
                {
                    { 30, 30, 1 },
                    { 31, 31, 1 },
                    { 32, 32, 1 },
                    { 33, 33, 1 },
                    { 34, 34, 1 },
                    { 38, 38, 1 },
                    { 36, 36, 1 },
                    { 37, 37, 1 },
                    { 39, 39, 1 },
                    { 29, 29, 1 },
                    { 35, 35, 1 },
                    { 28, 28, 1 },
                    { 19, 19, 1 },
                    { 26, 26, 1 },
                    { 25, 25, 1 },
                    { 24, 24, 1 },
                    { 23, 23, 1 },
                    { 22, 22, 1 },
                    { 21, 21, 1 },
                    { 20, 20, 1 },
                    { 18, 18, 1 },
                    { 17, 17, 1 },
                    { 16, 16, 1 },
                    { 27, 27, 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "AllowNotification", "Email", "EmployeeId", "Name", "UserName" },
                values: new object[,]
                {
                    { 4, false, "viknes_rajinran@jabil.com", "2932913", "Viknes Rajinran", "2932913" },
                    { 3, false, "NurShazwani_Md.Akhir@Jabil.com", "2925872", "NurShazwani Md.Akhir", "2925872" },
                    { 5, false, "Amol_Gaikwad@Jabil.com", "2930217", "Amol Gaikwad", "2930217" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "UserRoleId", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Country_CreatedBy",
                table: "Country",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Country_LastUpdatedBy",
                table: "Country",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Country_RegionId",
                table: "Country",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Division_CreatedBy",
                table: "Division",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Division_LastUpdatedBy",
                table: "Division",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Location_CountryId",
                table: "Location",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Location_CreatedBy",
                table: "Location",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Location_LastUpdatedBy",
                table: "Location",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Region_CreatedBy",
                table: "Region",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Region_LastUpdatedBy",
                table: "Region",
                column: "LastUpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCell_CreatedBy",
                table: "WorkCell",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WorkCell_LastUpdatedBy",
                table: "WorkCell",
                column: "LastUpdatedBy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Division");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "WorkCell");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PermissionType",
                keyColumn: "PermissionTypeId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "RolePermission",
                keyColumn: "RolePermissionId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "UserId",
                keyValue: 5);

            migrationBuilder.AlterColumn<int>(
                name: "UserRoleId",
                table: "UserRole",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:IdentitySequenceOptions", "'6', '1', '', '', 'False', '1'")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "User",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:IdentitySequenceOptions", "'6', '1', '', '', 'False', '1'")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "RolePermissionId",
                table: "RolePermission",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:IdentitySequenceOptions", "'40', '1', '', '', 'False', '1'")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Role",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:IdentitySequenceOptions", "'2', '1', '', '', 'False', '1'")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }
    }
}
