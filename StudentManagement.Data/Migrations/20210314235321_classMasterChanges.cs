using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Data.Migrations
{
    public partial class classMasterChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "SessionId",
                table: "ClassMaster",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_ClassMaster_SessionId",
                table: "ClassMaster",
                column: "SessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassMaster_SessionMaster_SessionId",
                table: "ClassMaster",
                column: "SessionId",
                principalTable: "SessionMaster",
                principalColumn: "SessionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassMaster_SessionMaster_SessionId",
                table: "ClassMaster");

            migrationBuilder.DropIndex(
                name: "IX_ClassMaster_SessionId",
                table: "ClassMaster");

            migrationBuilder.DropColumn(
                name: "SessionId",
                table: "ClassMaster");
        }
    }
}
