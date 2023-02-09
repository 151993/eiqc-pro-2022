using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QSS.eIQC.DataAccess.Migrations
{
    public partial class SMSSaveDraftSubmitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMeasurementSubmission_User_InspectorId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMeasurementSubmission_User_SupplierContactId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "ApproveRejectedDate",
                table: "SupplierMeasurementSubmission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApproveRejectedId",
                table: "SupplierMeasurementSubmission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StateTypeId",
                table: "SupplierMeasurementSubmission",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubmittedByUserId",
                table: "SupplierMeasurementSubmission",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "SubmittedDate",
                table: "SupplierMeasurementSubmission",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementSubmission_ApproveRejectedId",
                table: "SupplierMeasurementSubmission",
                column: "ApproveRejectedId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementSubmission_StateTypeId",
                table: "SupplierMeasurementSubmission",
                column: "StateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplierMeasurementSubmission_SubmittedByUserId",
                table: "SupplierMeasurementSubmission",
                column: "SubmittedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMeasurementSubmission_ApproveRejectedId",
                table: "SupplierMeasurementSubmission",
                column: "ApproveRejectedId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMeasurementSubmission_InspectorId",
                table: "SupplierMeasurementSubmission",
                column: "InspectorId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMeasurementSubmission_StateType_StateTypeId",
                table: "SupplierMeasurementSubmission",
                column: "StateTypeId",
                principalTable: "StateType",
                principalColumn: "StateTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMeasurementSubmission_SubmittedByUserId",
                table: "SupplierMeasurementSubmission",
                column: "SubmittedByUserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMeasurementSubmission_SupplierContactId",
                table: "SupplierMeasurementSubmission",
                column: "SupplierContactId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMeasurementSubmission_ApproveRejectedId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMeasurementSubmission_InspectorId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMeasurementSubmission_StateType_StateTypeId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMeasurementSubmission_SubmittedByUserId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropForeignKey(
                name: "FK_SupplierMeasurementSubmission_SupplierContactId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropIndex(
                name: "IX_SupplierMeasurementSubmission_ApproveRejectedId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropIndex(
                name: "IX_SupplierMeasurementSubmission_StateTypeId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropIndex(
                name: "IX_SupplierMeasurementSubmission_SubmittedByUserId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "ApproveRejectedDate",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "ApproveRejectedId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "StateTypeId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "SubmittedByUserId",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.DropColumn(
                name: "SubmittedDate",
                table: "SupplierMeasurementSubmission");

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMeasurementSubmission_User_InspectorId",
                table: "SupplierMeasurementSubmission",
                column: "InspectorId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SupplierMeasurementSubmission_User_SupplierContactId",
                table: "SupplierMeasurementSubmission",
                column: "SupplierContactId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
