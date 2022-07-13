using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class v51 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClubStatistic_Tournir_TournirClubIDtournir",
                table: "ClubStatistic");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerStatistic_Tournir_TournirPlayerIDtournir",
                table: "PlayerStatistic");

            migrationBuilder.RenameColumn(
                name: "TournirPlayerIDtournir",
                table: "PlayerStatistic",
                newName: "TournirStatPIDtournir");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerStatistic_TournirPlayerIDtournir",
                table: "PlayerStatistic",
                newName: "IX_PlayerStatistic_TournirStatPIDtournir");

            migrationBuilder.RenameColumn(
                name: "TournirClubIDtournir",
                table: "ClubStatistic",
                newName: "TournirStatCIDtournir");

            migrationBuilder.RenameIndex(
                name: "IX_ClubStatistic_TournirClubIDtournir",
                table: "ClubStatistic",
                newName: "IX_ClubStatistic_TournirStatCIDtournir");

            migrationBuilder.AlterColumn<string>(
                name: "BornDate",
                table: "Person",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddForeignKey(
                name: "FK_ClubStatistic_Tournir_TournirStatCIDtournir",
                table: "ClubStatistic",
                column: "TournirStatCIDtournir",
                principalTable: "Tournir",
                principalColumn: "IDtournir",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerStatistic_Tournir_TournirStatPIDtournir",
                table: "PlayerStatistic",
                column: "TournirStatPIDtournir",
                principalTable: "Tournir",
                principalColumn: "IDtournir",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClubStatistic_Tournir_TournirStatCIDtournir",
                table: "ClubStatistic");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerStatistic_Tournir_TournirStatPIDtournir",
                table: "PlayerStatistic");

            migrationBuilder.RenameColumn(
                name: "TournirStatPIDtournir",
                table: "PlayerStatistic",
                newName: "TournirPlayerIDtournir");

            migrationBuilder.RenameIndex(
                name: "IX_PlayerStatistic_TournirStatPIDtournir",
                table: "PlayerStatistic",
                newName: "IX_PlayerStatistic_TournirPlayerIDtournir");

            migrationBuilder.RenameColumn(
                name: "TournirStatCIDtournir",
                table: "ClubStatistic",
                newName: "TournirClubIDtournir");

            migrationBuilder.RenameIndex(
                name: "IX_ClubStatistic_TournirStatCIDtournir",
                table: "ClubStatistic",
                newName: "IX_ClubStatistic_TournirClubIDtournir");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BornDate",
                table: "Person",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubStatistic_Tournir_TournirClubIDtournir",
                table: "ClubStatistic",
                column: "TournirClubIDtournir",
                principalTable: "Tournir",
                principalColumn: "IDtournir",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerStatistic_Tournir_TournirPlayerIDtournir",
                table: "PlayerStatistic",
                column: "TournirPlayerIDtournir",
                principalTable: "Tournir",
                principalColumn: "IDtournir",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
