using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Data.Migrations
{
    public partial class MakeNullable_EntraceExamId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentQualication_EntranceExamMaster_EntranceExamId",
                table: "StudentQualication");

            migrationBuilder.AlterColumn<long>(
                name: "EntranceExamId",
                table: "StudentQualication",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentQualication_EntranceExamMaster_EntranceExamId",
                table: "StudentQualication",
                column: "EntranceExamId",
                principalTable: "EntranceExamMaster",
                principalColumn: "EntranceExamId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentQualication_EntranceExamMaster_EntranceExamId",
                table: "StudentQualication");

            migrationBuilder.AlterColumn<long>(
                name: "EntranceExamId",
                table: "StudentQualication",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentQualication_EntranceExamMaster_EntranceExamId",
                table: "StudentQualication",
                column: "EntranceExamId",
                principalTable: "EntranceExamMaster",
                principalColumn: "EntranceExamId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
