using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.Data.Migrations
{
    public partial class Update_Tables_PersonalDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDetail_RelationMaster_StayRelationId",
                table: "PersonalDetail");

            migrationBuilder.AlterColumn<long>(
                name: "StayRelationId",
                table: "PersonalDetail",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDetail_RelationMaster_StayRelationId",
                table: "PersonalDetail",
                column: "StayRelationId",
                principalTable: "RelationMaster",
                principalColumn: "RelationId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDetail_RelationMaster_StayRelationId",
                table: "PersonalDetail");

            migrationBuilder.AlterColumn<long>(
                name: "StayRelationId",
                table: "PersonalDetail",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDetail_RelationMaster_StayRelationId",
                table: "PersonalDetail",
                column: "StayRelationId",
                principalTable: "RelationMaster",
                principalColumn: "RelationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
