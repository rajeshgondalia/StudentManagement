using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Data.Migrations
{
    public partial class Update_Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryPincode",
                table: "PersonalDetail");

            migrationBuilder.RenameColumn(
                name: "StatePincode",
                table: "PersonalDetail",
                newName: "StayPinCode");

            migrationBuilder.AddColumn<long>(
                name: "StayCityId",
                table: "PersonalDetail",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StayCountryId",
                table: "PersonalDetail",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StayStateId",
                table: "PersonalDetail",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CreatedBy",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifiedBy",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_StayCityId",
                table: "PersonalDetail",
                column: "StayCityId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_StayCountryId",
                table: "PersonalDetail",
                column: "StayCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_StayStateId",
                table: "PersonalDetail",
                column: "StayStateId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDetail_CityMaster_StayCityId",
                table: "PersonalDetail",
                column: "StayCityId",
                principalTable: "CityMaster",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDetail_CountryMaster_StayCountryId",
                table: "PersonalDetail",
                column: "StayCountryId",
                principalTable: "CountryMaster",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDetail_StateMaster_StayStateId",
                table: "PersonalDetail",
                column: "StayStateId",
                principalTable: "StateMaster",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDetail_CityMaster_StayCityId",
                table: "PersonalDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDetail_CountryMaster_StayCountryId",
                table: "PersonalDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDetail_StateMaster_StayStateId",
                table: "PersonalDetail");

            migrationBuilder.DropIndex(
                name: "IX_PersonalDetail_StayCityId",
                table: "PersonalDetail");

            migrationBuilder.DropIndex(
                name: "IX_PersonalDetail_StayCountryId",
                table: "PersonalDetail");

            migrationBuilder.DropIndex(
                name: "IX_PersonalDetail_StayStateId",
                table: "PersonalDetail");

            migrationBuilder.DropColumn(
                name: "StayCityId",
                table: "PersonalDetail");

            migrationBuilder.DropColumn(
                name: "StayCountryId",
                table: "PersonalDetail");

            migrationBuilder.DropColumn(
                name: "StayStateId",
                table: "PersonalDetail");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "AspNetRoles");

            migrationBuilder.RenameColumn(
                name: "StayPinCode",
                table: "PersonalDetail",
                newName: "StatePincode");

            migrationBuilder.AddColumn<string>(
                name: "CountryPincode",
                table: "PersonalDetail",
                type: "varchar(10)",
                nullable: true);
        }
    }
}
