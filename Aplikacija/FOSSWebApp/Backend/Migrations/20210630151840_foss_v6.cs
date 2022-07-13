using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class foss_v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GoalsDifference",
                table: "ClubStatistic",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoalsDifference",
                table: "ClubStatistic");
        }
    }
}
