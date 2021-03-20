using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Data.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassSubjectDetail_AspNetUsers_StudentId",
                table: "ClassSubjectDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSubjectDetail_SubjectDepartmentMaster_SubjectDepartmentId",
                table: "ClassSubjectDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDetail_CityMaster_CityId",
                table: "PersonalDetail");

            migrationBuilder.DropIndex(
                name: "IX_PersonalDetail_CityId",
                table: "PersonalDetail");

            migrationBuilder.DropIndex(
                name: "IX_ClassSubjectDetail_StudentId",
                table: "ClassSubjectDetail");

            migrationBuilder.DropIndex(
                name: "IX_ClassSubjectDetail_SubjectDepartmentId",
                table: "ClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "PersonalDetail");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "ClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "SubjectDepartmentId",
                table: "ClassSubjectDetail");

            migrationBuilder.AddColumn<long>(
                name: "SubjectDepartmentId",
                table: "SubjectMaster",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "StateId",
                table: "CityMaster",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubjectMaster_SubjectDepartmentId",
                table: "SubjectMaster",
                column: "SubjectDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CityMaster_StateId",
                table: "CityMaster",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_CityMaster_StateMaster_StateId",
                table: "CityMaster",
                column: "StateId",
                principalTable: "StateMaster",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectMaster_SubjectDepartmentMaster_SubjectDepartmentId",
                table: "SubjectMaster",
                column: "SubjectDepartmentId",
                principalTable: "SubjectDepartmentMaster",
                principalColumn: "SubjectDepartmentId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CityMaster_StateMaster_StateId",
                table: "CityMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectMaster_SubjectDepartmentMaster_SubjectDepartmentId",
                table: "SubjectMaster");

            migrationBuilder.DropIndex(
                name: "IX_SubjectMaster_SubjectDepartmentId",
                table: "SubjectMaster");

            migrationBuilder.DropIndex(
                name: "IX_CityMaster_StateId",
                table: "CityMaster");

            migrationBuilder.DropColumn(
                name: "SubjectDepartmentId",
                table: "SubjectMaster");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "CityMaster");

            migrationBuilder.AddColumn<long>(
                name: "CityId",
                table: "PersonalDetail",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "StudentId",
                table: "ClassSubjectDetail",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SubjectDepartmentId",
                table: "ClassSubjectDetail",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDetail_CityId",
                table: "PersonalDetail",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjectDetail_StudentId",
                table: "ClassSubjectDetail",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjectDetail_SubjectDepartmentId",
                table: "ClassSubjectDetail",
                column: "SubjectDepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSubjectDetail_AspNetUsers_StudentId",
                table: "ClassSubjectDetail",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassSubjectDetail_SubjectDepartmentMaster_SubjectDepartmentId",
                table: "ClassSubjectDetail",
                column: "SubjectDepartmentId",
                principalTable: "SubjectDepartmentMaster",
                principalColumn: "SubjectDepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDetail_CityMaster_CityId",
                table: "PersonalDetail",
                column: "CityId",
                principalTable: "CityMaster",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
