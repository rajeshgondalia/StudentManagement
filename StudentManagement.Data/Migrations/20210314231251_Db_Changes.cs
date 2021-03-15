using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Data.Migrations
{
    public partial class Db_Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubjectCode",
                table: "SubjectMaster",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "SubjectTypeId",
                table: "SubjectMaster",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ActaulL",
                table: "HistoryClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CT",
                table: "HistoryClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Credit",
                table: "HistoryClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ESE",
                table: "HistoryClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "L",
                table: "HistoryClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "P",
                table: "HistoryClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "StudentId",
                table: "HistoryClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SubjectDepartmentId",
                table: "HistoryClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "T",
                table: "HistoryClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "TA",
                table: "HistoryClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ActaulL",
                table: "ClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CT",
                table: "ClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "Credit",
                table: "ClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ESE",
                table: "ClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "L",
                table: "ClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "P",
                table: "ClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "StudentId",
                table: "ClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "SubjectDepartmentId",
                table: "ClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "T",
                table: "ClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "TA",
                table: "ClassSubjectDetail",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "BranchId",
                table: "ClassMaster",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CampusId",
                table: "ClassMaster",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "CollegeId",
                table: "ClassMaster",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "CourseId",
                table: "ClassMaster",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "YearSemesterId",
                table: "ClassMaster",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HistoryClassMaster",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    ClassId = table.Column<long>(nullable: false),
                    SessionId = table.Column<long>(nullable: false),
                    CampusId = table.Column<long>(nullable: false),
                    CollegeId = table.Column<long>(nullable: false),
                    CourseId = table.Column<long>(nullable: false),
                    BranchId = table.Column<long>(nullable: false),
                    YearSemesterId = table.Column<long>(nullable: false),
                    ClassName = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryClassMaster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SessionMaster",
                columns: table => new
                {
                    SessionId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    SessionName = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SessionMaster", x => x.SessionId);
                });

            migrationBuilder.CreateTable(
                name: "SubjectDepartmentMaster",
                columns: table => new
                {
                    SubjectDepartmentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectDepartmentMaster", x => x.SubjectDepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "SubjectTypeMaster",
                columns: table => new
                {
                    SubjectTypeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    SubjectType = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTypeMaster", x => x.SubjectTypeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectMaster_SubjectTypeId",
                table: "SubjectMaster",
                column: "SubjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjectDetail_StudentId",
                table: "ClassSubjectDetail",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassSubjectDetail_SubjectDepartmentId",
                table: "ClassSubjectDetail",
                column: "SubjectDepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassMaster_BranchId",
                table: "ClassMaster",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassMaster_CampusId",
                table: "ClassMaster",
                column: "CampusId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassMaster_CollegeId",
                table: "ClassMaster",
                column: "CollegeId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassMaster_CourseId",
                table: "ClassMaster",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassMaster_YearSemesterId",
                table: "ClassMaster",
                column: "YearSemesterId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassMaster_BranchMaster_BranchId",
                table: "ClassMaster",
                column: "BranchId",
                principalTable: "BranchMaster",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassMaster_CampusMaster_CampusId",
                table: "ClassMaster",
                column: "CampusId",
                principalTable: "CampusMaster",
                principalColumn: "CampusId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassMaster_CollegeMaster_CollegeId",
                table: "ClassMaster",
                column: "CollegeId",
                principalTable: "CollegeMaster",
                principalColumn: "CollegeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassMaster_CourseMaster_CourseId",
                table: "ClassMaster",
                column: "CourseId",
                principalTable: "CourseMaster",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassMaster_YearSemesterMaster_YearSemesterId",
                table: "ClassMaster",
                column: "YearSemesterId",
                principalTable: "YearSemesterMaster",
                principalColumn: "YearSemesterId",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_SubjectMaster_SubjectTypeMaster_SubjectTypeId",
                table: "SubjectMaster",
                column: "SubjectTypeId",
                principalTable: "SubjectTypeMaster",
                principalColumn: "SubjectTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassMaster_BranchMaster_BranchId",
                table: "ClassMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassMaster_CampusMaster_CampusId",
                table: "ClassMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassMaster_CollegeMaster_CollegeId",
                table: "ClassMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassMaster_CourseMaster_CourseId",
                table: "ClassMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassMaster_YearSemesterMaster_YearSemesterId",
                table: "ClassMaster");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSubjectDetail_AspNetUsers_StudentId",
                table: "ClassSubjectDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassSubjectDetail_SubjectDepartmentMaster_SubjectDepartmentId",
                table: "ClassSubjectDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectMaster_SubjectTypeMaster_SubjectTypeId",
                table: "SubjectMaster");

            migrationBuilder.DropTable(
                name: "HistoryClassMaster");

            migrationBuilder.DropTable(
                name: "SessionMaster");

            migrationBuilder.DropTable(
                name: "SubjectDepartmentMaster");

            migrationBuilder.DropTable(
                name: "SubjectTypeMaster");

            migrationBuilder.DropIndex(
                name: "IX_SubjectMaster_SubjectTypeId",
                table: "SubjectMaster");

            migrationBuilder.DropIndex(
                name: "IX_ClassSubjectDetail_StudentId",
                table: "ClassSubjectDetail");

            migrationBuilder.DropIndex(
                name: "IX_ClassSubjectDetail_SubjectDepartmentId",
                table: "ClassSubjectDetail");

            migrationBuilder.DropIndex(
                name: "IX_ClassMaster_BranchId",
                table: "ClassMaster");

            migrationBuilder.DropIndex(
                name: "IX_ClassMaster_CampusId",
                table: "ClassMaster");

            migrationBuilder.DropIndex(
                name: "IX_ClassMaster_CollegeId",
                table: "ClassMaster");

            migrationBuilder.DropIndex(
                name: "IX_ClassMaster_CourseId",
                table: "ClassMaster");

            migrationBuilder.DropIndex(
                name: "IX_ClassMaster_YearSemesterId",
                table: "ClassMaster");

            migrationBuilder.DropColumn(
                name: "SubjectCode",
                table: "SubjectMaster");

            migrationBuilder.DropColumn(
                name: "SubjectTypeId",
                table: "SubjectMaster");

            migrationBuilder.DropColumn(
                name: "ActaulL",
                table: "HistoryClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "CT",
                table: "HistoryClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "Credit",
                table: "HistoryClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "ESE",
                table: "HistoryClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "L",
                table: "HistoryClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "P",
                table: "HistoryClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "HistoryClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "SubjectDepartmentId",
                table: "HistoryClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "T",
                table: "HistoryClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "TA",
                table: "HistoryClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "ActaulL",
                table: "ClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "CT",
                table: "ClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "Credit",
                table: "ClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "ESE",
                table: "ClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "L",
                table: "ClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "P",
                table: "ClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "ClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "SubjectDepartmentId",
                table: "ClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "T",
                table: "ClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "TA",
                table: "ClassSubjectDetail");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "ClassMaster");

            migrationBuilder.DropColumn(
                name: "CampusId",
                table: "ClassMaster");

            migrationBuilder.DropColumn(
                name: "CollegeId",
                table: "ClassMaster");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "ClassMaster");

            migrationBuilder.DropColumn(
                name: "YearSemesterId",
                table: "ClassMaster");
        }
    }
}
