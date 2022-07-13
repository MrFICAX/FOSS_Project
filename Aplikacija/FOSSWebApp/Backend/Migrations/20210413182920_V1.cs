using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    IDclub = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wins = table.Column<int>(type: "int", nullable: false),
                    Loses = table.Column<int>(type: "int", nullable: false),
                    Draws = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    MatchPlayed = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.IDclub);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    IDperson = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BornDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ages = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.IDperson);
                });

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

            migrationBuilder.CreateTable(
                name: "Organisator",
                columns: table => new
                {
                    IDperson = table.Column<int>(type: "int", nullable: false),
                    Pass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organisator", x => x.IDperson);
                    table.ForeignKey(
                        name: "FK_Organisator_Person_IDperson",
                        column: x => x.IDperson,
                        principalTable: "Person",
                        principalColumn: "IDperson",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Referee",
                columns: table => new
                {
                    IDperson = table.Column<int>(type: "int", nullable: false),
                    Quality = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referee", x => x.IDperson);
                    table.ForeignKey(
                        name: "FK_Referee_Person_IDperson",
                        column: x => x.IDperson,
                        principalTable: "Person",
                        principalColumn: "IDperson",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trainer",
                columns: table => new
                {
                    IDperson = table.Column<int>(type: "int", nullable: false),
                    ClubForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainer", x => x.IDperson);
                    table.ForeignKey(
                        name: "FK_Trainer_Club_ClubForeignKey",
                        column: x => x.ClubForeignKey,
                        principalTable: "Club",
                        principalColumn: "IDclub",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trainer_Person_IDperson",
                        column: x => x.IDperson,
                        principalTable: "Person",
                        principalColumn: "IDperson",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    IDperson = table.Column<int>(type: "int", nullable: false),
                    Num = table.Column<int>(type: "int", nullable: false),
                    Captain = table.Column<bool>(type: "bit", nullable: false),
                    Goals = table.Column<int>(type: "int", nullable: false),
                    Cards = table.Column<int>(type: "int", nullable: false),
                    PositionIDpositions = table.Column<int>(type: "int", nullable: true),
                    ClubIDclub = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.IDperson);
                    table.ForeignKey(
                        name: "FK_Player_Club_ClubIDclub",
                        column: x => x.ClubIDclub,
                        principalTable: "Club",
                        principalColumn: "IDclub",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Player_Person_IDperson",
                        column: x => x.IDperson,
                        principalTable: "Person",
                        principalColumn: "IDperson",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Player_Position_PositionIDpositions",
                        column: x => x.PositionIDpositions,
                        principalTable: "Position",
                        principalColumn: "IDposition",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tournir",
                columns: table => new
                {
                    IDtournir = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournirName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TournirWinner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TournirDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrganisatorIDperson = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournir", x => x.IDtournir);
                    table.ForeignKey(
                        name: "FK_Tournir_Organisator_OrganisatorIDperson",
                        column: x => x.OrganisatorIDperson,
                        principalTable: "Organisator",
                        principalColumn: "IDperson",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    IDadmin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnterKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganisatorIDperson = table.Column<int>(type: "int", nullable: true),
                    TournirIDtournir = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.IDadmin);
                    table.ForeignKey(
                        name: "FK_Admin_Organisator_OrganisatorIDperson",
                        column: x => x.OrganisatorIDperson,
                        principalTable: "Organisator",
                        principalColumn: "IDperson",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Admin_Tournir_TournirIDtournir",
                        column: x => x.TournirIDtournir,
                        principalTable: "Tournir",
                        principalColumn: "IDtournir",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClubTournir",
                columns: table => new
                {
                    ClubsIDclub = table.Column<int>(type: "int", nullable: false),
                    TournirsIDtournir = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubTournir", x => new { x.ClubsIDclub, x.TournirsIDtournir });
                    table.ForeignKey(
                        name: "FK_ClubTournir_Club_ClubsIDclub",
                        column: x => x.ClubsIDclub,
                        principalTable: "Club",
                        principalColumn: "IDclub",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubTournir_Tournir_TournirsIDtournir",
                        column: x => x.TournirsIDtournir,
                        principalTable: "Tournir",
                        principalColumn: "IDtournir",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TMatch",
                columns: table => new
                {
                    IDmatch = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MatchPhase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Live = table.Column<bool>(type: "bit", nullable: false),
                    HomeGoals = table.Column<int>(type: "int", nullable: false),
                    AwayGoals = table.Column<int>(type: "int", nullable: false),
                    Winner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TournirIDtournir = table.Column<int>(type: "int", nullable: true),
                    RefereeIDperson = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TMatch", x => x.IDmatch);
                    table.ForeignKey(
                        name: "FK_TMatch_Referee_RefereeIDperson",
                        column: x => x.RefereeIDperson,
                        principalTable: "Referee",
                        principalColumn: "IDperson",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TMatch_Tournir_TournirIDtournir",
                        column: x => x.TournirIDtournir,
                        principalTable: "Tournir",
                        principalColumn: "IDtournir",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClubTMatch",
                columns: table => new
                {
                    ClubsIDclub = table.Column<int>(type: "int", nullable: false),
                    TMatchesIDmatch = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubTMatch", x => new { x.ClubsIDclub, x.TMatchesIDmatch });
                    table.ForeignKey(
                        name: "FK_ClubTMatch_Club_ClubsIDclub",
                        column: x => x.ClubsIDclub,
                        principalTable: "Club",
                        principalColumn: "IDclub",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClubTMatch_TMatch_TMatchesIDmatch",
                        column: x => x.TMatchesIDmatch,
                        principalTable: "TMatch",
                        principalColumn: "IDmatch",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admin_OrganisatorIDperson",
                table: "Admin",
                column: "OrganisatorIDperson");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_TournirIDtournir",
                table: "Admin",
                column: "TournirIDtournir");

            migrationBuilder.CreateIndex(
                name: "IX_ClubTMatch_TMatchesIDmatch",
                table: "ClubTMatch",
                column: "TMatchesIDmatch");

            migrationBuilder.CreateIndex(
                name: "IX_ClubTournir_TournirsIDtournir",
                table: "ClubTournir",
                column: "TournirsIDtournir");

            migrationBuilder.CreateIndex(
                name: "IX_Player_ClubIDclub",
                table: "Player",
                column: "ClubIDclub");

            migrationBuilder.CreateIndex(
                name: "IX_Player_PositionIDpositions",
                table: "Player",
                column: "PositionIDpositions");

            migrationBuilder.CreateIndex(
                name: "IX_TMatch_RefereeIDperson",
                table: "TMatch",
                column: "RefereeIDperson");

            migrationBuilder.CreateIndex(
                name: "IX_TMatch_TournirIDtournir",
                table: "TMatch",
                column: "TournirIDtournir");

            migrationBuilder.CreateIndex(
                name: "IX_Tournir_OrganisatorIDperson",
                table: "Tournir",
                column: "OrganisatorIDperson");

            migrationBuilder.CreateIndex(
                name: "IX_Trainer_ClubForeignKey",
                table: "Trainer",
                column: "ClubForeignKey",
                unique: true,
                filter: "[ClubForeignKey] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "ClubTMatch");

            migrationBuilder.DropTable(
                name: "ClubTournir");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Trainer");

            migrationBuilder.DropTable(
                name: "TMatch");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropTable(
                name: "Referee");

            migrationBuilder.DropTable(
                name: "Tournir");

            migrationBuilder.DropTable(
                name: "Organisator");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
