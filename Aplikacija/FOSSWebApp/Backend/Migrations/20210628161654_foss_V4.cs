using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class foss_V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Winner",
                table: "TMatch");

            migrationBuilder.AddColumn<int>(
                name: "WinnerIDclub",
                table: "TMatch",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TMatch_WinnerIDclub",
                table: "TMatch",
                column: "WinnerIDclub");

            migrationBuilder.AddForeignKey(
                name: "FK_TMatch_Club_WinnerIDclub",
                table: "TMatch",
                column: "WinnerIDclub",
                principalTable: "Club",
                principalColumn: "IDclub",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TMatch_Club_WinnerIDclub",
                table: "TMatch");

            migrationBuilder.DropIndex(
                name: "IX_TMatch_WinnerIDclub",
                table: "TMatch");

            migrationBuilder.DropColumn(
                name: "WinnerIDclub",
                table: "TMatch");

            migrationBuilder.AddColumn<string>(
                name: "Winner",
                table: "TMatch",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
