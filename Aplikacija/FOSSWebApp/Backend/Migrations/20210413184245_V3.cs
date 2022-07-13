using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class V3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trainer_Club_ClubForeignKey",
                table: "Trainer");

            migrationBuilder.DropIndex(
                name: "IX_Trainer_ClubForeignKey",
                table: "Trainer");

            migrationBuilder.DropColumn(
                name: "ClubForeignKey",
                table: "Trainer");

            migrationBuilder.AddColumn<int>(
                name: "Trainings",
                table: "Club",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Club_Trainings",
                table: "Club",
                column: "Trainings",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Club_Trainer_Trainings",
                table: "Club",
                column: "Trainings",
                principalTable: "Trainer",
                principalColumn: "IDperson",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Club_Trainer_Trainings",
                table: "Club");

            migrationBuilder.DropIndex(
                name: "IX_Club_Trainings",
                table: "Club");

            migrationBuilder.DropColumn(
                name: "Trainings",
                table: "Club");

            migrationBuilder.AddColumn<int>(
                name: "ClubForeignKey",
                table: "Trainer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Trainer_ClubForeignKey",
                table: "Trainer",
                column: "ClubForeignKey",
                unique: true,
                filter: "[ClubForeignKey] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Trainer_Club_ClubForeignKey",
                table: "Trainer",
                column: "ClubForeignKey",
                principalTable: "Club",
                principalColumn: "IDclub",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
