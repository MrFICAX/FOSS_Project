using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class foss_v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumOfTeamsPerGroup",
                table: "Tournir",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumOfTeamsPerGroup",
                table: "Tournir");
        }
    }
}
