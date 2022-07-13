using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class V14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_Organisator_OrganisatorIDperson",
                table: "Admin");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubTournir_Tournir_TournirsIDtournir",
                table: "ClubTournir");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Club_ClubIDclub",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_TMatch_Tournir_TournirIDtournir",
                table: "TMatch");

            migrationBuilder.DropForeignKey(
                name: "FK_Tournir_Organisator_OrganisatorIDperson",
                table: "Tournir");

            migrationBuilder.DropColumn(
                name: "Cards",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "Goals",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "Ages",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "Draws",
                table: "Club");

            migrationBuilder.DropColumn(
                name: "Loses",
                table: "Club");

            migrationBuilder.DropColumn(
                name: "Wins",
                table: "Club");

            migrationBuilder.RenameColumn(
                name: "OrganisatorIDperson",
                table: "Tournir",
                newName: "TournirOrganisatorIDperson");

            migrationBuilder.RenameIndex(
                name: "IX_Tournir_OrganisatorIDperson",
                table: "Tournir",
                newName: "IX_Tournir_TournirOrganisatorIDperson");

            migrationBuilder.RenameColumn(
                name: "TournirIDtournir",
                table: "TMatch",
                newName: "TournirMIDtournir");

            migrationBuilder.RenameIndex(
                name: "IX_TMatch_TournirIDtournir",
                table: "TMatch",
                newName: "IX_TMatch_TournirMIDtournir");

            migrationBuilder.RenameColumn(
                name: "ClubIDclub",
                table: "Player",
                newName: "ClubPlayingForIDclub");

            migrationBuilder.RenameIndex(
                name: "IX_Player_ClubIDclub",
                table: "Player",
                newName: "IX_Player_ClubPlayingForIDclub");

            migrationBuilder.RenameColumn(
                name: "TournirsIDtournir",
                table: "ClubTournir",
                newName: "TournirsPlayingInIDtournir");

            migrationBuilder.RenameIndex(
                name: "IX_ClubTournir_TournirsIDtournir",
                table: "ClubTournir",
                newName: "IX_ClubTournir_TournirsPlayingInIDtournir");

            migrationBuilder.RenameColumn(
                name: "OrganisatorIDperson",
                table: "Admin",
                newName: "GiveAccessByIDperson");

            migrationBuilder.RenameIndex(
                name: "IX_Admin_OrganisatorIDperson",
                table: "Admin",
                newName: "IX_Admin_GiveAccessByIDperson");

            migrationBuilder.CreateTable(
                name: "ClubStatistic",
                columns: table => new
                {
                    IDcstatistic = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Loses = table.Column<int>(type: "int", nullable: false),
                    Draws = table.Column<int>(type: "int", nullable: false),
                    TournirClubIDtournir = table.Column<int>(type: "int", nullable: true),
                    ClubStatIDclub = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubStatistic", x => x.IDcstatistic);
                    table.ForeignKey(
                        name: "FK_ClubStatistic_Club_ClubStatIDclub",
                        column: x => x.ClubStatIDclub,
                        principalTable: "Club",
                        principalColumn: "IDclub",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClubStatistic_Tournir_TournirClubIDtournir",
                        column: x => x.TournirClubIDtournir,
                        principalTable: "Tournir",
                        principalColumn: "IDtournir",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerStatistic",
                columns: table => new
                {
                    IDpstatistic = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Goals = table.Column<int>(type: "int", nullable: false),
                    Cards = table.Column<int>(type: "int", nullable: false),
                    PlayerStatIDperson = table.Column<int>(type: "int", nullable: true),
                    TournirPlayerIDtournir = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerStatistic", x => x.IDpstatistic);
                    table.ForeignKey(
                        name: "FK_PlayerStatistic_Player_PlayerStatIDperson",
                        column: x => x.PlayerStatIDperson,
                        principalTable: "Player",
                        principalColumn: "IDperson",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerStatistic_Tournir_TournirPlayerIDtournir",
                        column: x => x.TournirPlayerIDtournir,
                        principalTable: "Tournir",
                        principalColumn: "IDtournir",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClubStatistic_ClubStatIDclub",
                table: "ClubStatistic",
                column: "ClubStatIDclub");

            migrationBuilder.CreateIndex(
                name: "IX_ClubStatistic_TournirClubIDtournir",
                table: "ClubStatistic",
                column: "TournirClubIDtournir");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStatistic_PlayerStatIDperson",
                table: "PlayerStatistic",
                column: "PlayerStatIDperson");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerStatistic_TournirPlayerIDtournir",
                table: "PlayerStatistic",
                column: "TournirPlayerIDtournir");

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_Organisator_GiveAccessByIDperson",
                table: "Admin",
                column: "GiveAccessByIDperson",
                principalTable: "Organisator",
                principalColumn: "IDperson",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubTournir_Tournir_TournirsPlayingInIDtournir",
                table: "ClubTournir",
                column: "TournirsPlayingInIDtournir",
                principalTable: "Tournir",
                principalColumn: "IDtournir",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Club_ClubPlayingForIDclub",
                table: "Player",
                column: "ClubPlayingForIDclub",
                principalTable: "Club",
                principalColumn: "IDclub",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TMatch_Tournir_TournirMIDtournir",
                table: "TMatch",
                column: "TournirMIDtournir",
                principalTable: "Tournir",
                principalColumn: "IDtournir",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tournir_Organisator_TournirOrganisatorIDperson",
                table: "Tournir",
                column: "TournirOrganisatorIDperson",
                principalTable: "Organisator",
                principalColumn: "IDperson",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_Organisator_GiveAccessByIDperson",
                table: "Admin");

            migrationBuilder.DropForeignKey(
                name: "FK_ClubTournir_Tournir_TournirsPlayingInIDtournir",
                table: "ClubTournir");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Club_ClubPlayingForIDclub",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_TMatch_Tournir_TournirMIDtournir",
                table: "TMatch");

            migrationBuilder.DropForeignKey(
                name: "FK_Tournir_Organisator_TournirOrganisatorIDperson",
                table: "Tournir");

            migrationBuilder.DropTable(
                name: "ClubStatistic");

            migrationBuilder.DropTable(
                name: "PlayerStatistic");

            migrationBuilder.RenameColumn(
                name: "TournirOrganisatorIDperson",
                table: "Tournir",
                newName: "OrganisatorIDperson");

            migrationBuilder.RenameIndex(
                name: "IX_Tournir_TournirOrganisatorIDperson",
                table: "Tournir",
                newName: "IX_Tournir_OrganisatorIDperson");

            migrationBuilder.RenameColumn(
                name: "TournirMIDtournir",
                table: "TMatch",
                newName: "TournirIDtournir");

            migrationBuilder.RenameIndex(
                name: "IX_TMatch_TournirMIDtournir",
                table: "TMatch",
                newName: "IX_TMatch_TournirIDtournir");

            migrationBuilder.RenameColumn(
                name: "ClubPlayingForIDclub",
                table: "Player",
                newName: "ClubIDclub");

            migrationBuilder.RenameIndex(
                name: "IX_Player_ClubPlayingForIDclub",
                table: "Player",
                newName: "IX_Player_ClubIDclub");

            migrationBuilder.RenameColumn(
                name: "TournirsPlayingInIDtournir",
                table: "ClubTournir",
                newName: "TournirsIDtournir");

            migrationBuilder.RenameIndex(
                name: "IX_ClubTournir_TournirsPlayingInIDtournir",
                table: "ClubTournir",
                newName: "IX_ClubTournir_TournirsIDtournir");

            migrationBuilder.RenameColumn(
                name: "GiveAccessByIDperson",
                table: "Admin",
                newName: "OrganisatorIDperson");

            migrationBuilder.RenameIndex(
                name: "IX_Admin_GiveAccessByIDperson",
                table: "Admin",
                newName: "IX_Admin_OrganisatorIDperson");

            migrationBuilder.AddColumn<int>(
                name: "Cards",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Goals",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ages",
                table: "Person",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Draws",
                table: "Club",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Loses",
                table: "Club",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Wins",
                table: "Club",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_Organisator_OrganisatorIDperson",
                table: "Admin",
                column: "OrganisatorIDperson",
                principalTable: "Organisator",
                principalColumn: "IDperson",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ClubTournir_Tournir_TournirsIDtournir",
                table: "ClubTournir",
                column: "TournirsIDtournir",
                principalTable: "Tournir",
                principalColumn: "IDtournir",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Club_ClubIDclub",
                table: "Player",
                column: "ClubIDclub",
                principalTable: "Club",
                principalColumn: "IDclub",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TMatch_Tournir_TournirIDtournir",
                table: "TMatch",
                column: "TournirIDtournir",
                principalTable: "Tournir",
                principalColumn: "IDtournir",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tournir_Organisator_OrganisatorIDperson",
                table: "Tournir",
                column: "OrganisatorIDperson",
                principalTable: "Organisator",
                principalColumn: "IDperson",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
