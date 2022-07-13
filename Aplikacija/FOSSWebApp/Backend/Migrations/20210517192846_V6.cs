using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class V6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_Tournir_TournirIDtournir",
                table: "Admin");

            migrationBuilder.DropTable(
                name: "ClubTMatch");

            migrationBuilder.DropIndex(
                name: "IX_Admin_TournirIDtournir",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "TournirIDtournir",
                table: "Admin");

            migrationBuilder.AddColumn<int>(
                name: "Club1IDclub",
                table: "TMatch",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Club2IDclub",
                table: "TMatch",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AdminTournir",
                columns: table => new
                {
                    AdminsIDadmin = table.Column<int>(type: "int", nullable: false),
                    TournirsIDtournir = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminTournir", x => new { x.AdminsIDadmin, x.TournirsIDtournir });
                    table.ForeignKey(
                        name: "FK_AdminTournir_Admin_AdminsIDadmin",
                        column: x => x.AdminsIDadmin,
                        principalTable: "Admin",
                        principalColumn: "IDadmin",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminTournir_Tournir_TournirsIDtournir",
                        column: x => x.TournirsIDtournir,
                        principalTable: "Tournir",
                        principalColumn: "IDtournir",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TMatch_Club1IDclub",
                table: "TMatch",
                column: "Club1IDclub");

            migrationBuilder.CreateIndex(
                name: "IX_TMatch_Club2IDclub",
                table: "TMatch",
                column: "Club2IDclub");

            migrationBuilder.CreateIndex(
                name: "IX_AdminTournir_TournirsIDtournir",
                table: "AdminTournir",
                column: "TournirsIDtournir");

            migrationBuilder.AddForeignKey(
                name: "FK_TMatch_Club_Club1IDclub",
                table: "TMatch",
                column: "Club1IDclub",
                principalTable: "Club",
                principalColumn: "IDclub",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TMatch_Club_Club2IDclub",
                table: "TMatch",
                column: "Club2IDclub",
                principalTable: "Club",
                principalColumn: "IDclub",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TMatch_Club_Club1IDclub",
                table: "TMatch");

            migrationBuilder.DropForeignKey(
                name: "FK_TMatch_Club_Club2IDclub",
                table: "TMatch");

            migrationBuilder.DropTable(
                name: "AdminTournir");

            migrationBuilder.DropIndex(
                name: "IX_TMatch_Club1IDclub",
                table: "TMatch");

            migrationBuilder.DropIndex(
                name: "IX_TMatch_Club2IDclub",
                table: "TMatch");

            migrationBuilder.DropColumn(
                name: "Club1IDclub",
                table: "TMatch");

            migrationBuilder.DropColumn(
                name: "Club2IDclub",
                table: "TMatch");

            migrationBuilder.AddColumn<int>(
                name: "TournirIDtournir",
                table: "Admin",
                type: "int",
                nullable: true);

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
                name: "IX_Admin_TournirIDtournir",
                table: "Admin",
                column: "TournirIDtournir");

            migrationBuilder.CreateIndex(
                name: "IX_ClubTMatch_TMatchesIDmatch",
                table: "ClubTMatch",
                column: "TMatchesIDmatch");

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_Tournir_TournirIDtournir",
                table: "Admin",
                column: "TournirIDtournir",
                principalTable: "Tournir",
                principalColumn: "IDtournir",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
