using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class V8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TMatch_Referee_RefereeIDperson",
                table: "TMatch");

            migrationBuilder.RenameColumn(
                name: "RefereeIDperson",
                table: "TMatch",
                newName: "RefereeeIDperson");

            migrationBuilder.RenameIndex(
                name: "IX_TMatch_RefereeIDperson",
                table: "TMatch",
                newName: "IX_TMatch_RefereeeIDperson");

            migrationBuilder.AddForeignKey(
                name: "FK_TMatch_Referee_RefereeeIDperson",
                table: "TMatch",
                column: "RefereeeIDperson",
                principalTable: "Referee",
                principalColumn: "IDperson",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TMatch_Referee_RefereeeIDperson",
                table: "TMatch");

            migrationBuilder.RenameColumn(
                name: "RefereeeIDperson",
                table: "TMatch",
                newName: "RefereeIDperson");

            migrationBuilder.RenameIndex(
                name: "IX_TMatch_RefereeeIDperson",
                table: "TMatch",
                newName: "IX_TMatch_RefereeIDperson");

            migrationBuilder.AddForeignKey(
                name: "FK_TMatch_Referee_RefereeIDperson",
                table: "TMatch",
                column: "RefereeIDperson",
                principalTable: "Referee",
                principalColumn: "IDperson",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
