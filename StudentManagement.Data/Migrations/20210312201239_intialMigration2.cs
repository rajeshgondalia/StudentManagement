using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Data.Migrations
{
    public partial class intialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HistoryClassSubjectDetail",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ClassSubjectDetailId = table.Column<long>(nullable: true),
                    ClassId = table.Column<long>(nullable: true),
                    SubjectId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoryClassSubjectDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HistoryClassSubjectDetail_ClassMaster_ClassId",
                        column: x => x.ClassId,
                        principalTable: "ClassMaster",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HistoryClassSubjectDetail_ClassSubjectDetail_ClassSubjectDetailId",
                        column: x => x.ClassSubjectDetailId,
                        principalTable: "ClassSubjectDetail",
                        principalColumn: "ClassSubjectDetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HistoryClassSubjectDetail_ClassId",
                table: "HistoryClassSubjectDetail",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoryClassSubjectDetail_ClassSubjectDetailId",
                table: "HistoryClassSubjectDetail",
                column: "ClassSubjectDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HistoryClassSubjectDetail");
        }
    }
}
