using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class V12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "TrainerIDperson",
                table: "Club",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Club_TrainerIDperson",
                table: "Club",
                column: "TrainerIDperson");

            migrationBuilder.AddForeignKey(
                name: "FK_Club_Trainer_TrainerIDperson",
                table: "Club",
                column: "TrainerIDperson",
                principalTable: "Trainer",
                principalColumn: "IDperson",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Club_Trainer_TrainerIDperson",
                table: "Club");

            migrationBuilder.DropIndex(
                name: "IX_Club_TrainerIDperson",
                table: "Club");

            migrationBuilder.DropColumn(
                name: "TrainerIDperson",
                table: "Club");

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
    }
}
