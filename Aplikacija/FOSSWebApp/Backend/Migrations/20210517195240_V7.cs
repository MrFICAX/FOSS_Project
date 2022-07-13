using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class V7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Position_PositionIDpositions",
                table: "Player");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropIndex(
                name: "IX_Player_PositionIDpositions",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "PositionIDpositions",
                table: "Player");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Player",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Position",
                table: "Player");

            migrationBuilder.AddColumn<int>(
                name: "PositionIDpositions",
                table: "Player",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    IDposition = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.IDposition);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_PositionIDpositions",
                table: "Player",
                column: "PositionIDpositions");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Position_PositionIDpositions",
                table: "Player",
                column: "PositionIDpositions",
                principalTable: "Position",
                principalColumn: "IDposition",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
