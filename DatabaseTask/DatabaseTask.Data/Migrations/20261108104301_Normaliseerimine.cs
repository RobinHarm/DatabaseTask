using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class Normaliseerimine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Koolitaja",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KoolitajaEesnimi = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    KoolitajaPerekonnanimi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    KoolitajaEPost = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    KoolitajaTelefon = table.Column<int>(type: "int", nullable: false),
                    Spetsialiseerumine = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    TööleAsumiseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TasuTunniEest = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Koolitaja", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Registreerimine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegistreerimiseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistreerimiseStaatus = table.Column<bool>(type: "bit", nullable: false),
                    RegistreerimiseViis = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RegistreerimiseTöötaja = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MakseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registreerimine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ruum",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RuumiNimi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Hoone = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Korrus = table.Column<int>(type: "int", nullable: false),
                    KohtadeArv = table.Column<int>(type: "int", nullable: false),
                    RuumiTüüp = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KoolitusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ruum", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Makse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MakseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MakseSumma = table.Column<int>(type: "int", nullable: false),
                    MakseViis = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    MakseStaatus = table.Column<bool>(type: "bit", nullable: false),
                    ArveNumber = table.Column<int>(type: "int", nullable: false),
                    MakseTähtaeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Viivis = table.Column<int>(type: "int", nullable: false),
                    RegistreerimineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Makse_Registreerimine_RegistreerimineId",
                        column: x => x.RegistreerimineId,
                        principalTable: "Registreerimine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Õppija",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Märkused = table.Column<int>(type: "int", nullable: false),
                    Eesnimi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Perekonnanimi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Isikukood = table.Column<int>(type: "int", nullable: false),
                    Sünnikuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EPost = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Telefon = table.Column<int>(type: "int", nullable: false),
                    Tänav = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Linn = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Postiindeks = table.Column<int>(type: "int", nullable: false),
                    Valdkond = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Tase = table.Column<int>(type: "int", nullable: false),
                    Hinne = table.Column<int>(type: "int", nullable: false),
                    LäbitudTunnid = table.Column<int>(type: "int", nullable: false),
                    PuudumisteArv = table.Column<int>(type: "int", nullable: false),
                    TunnistusVäljastatud = table.Column<bool>(type: "bit", nullable: false),
                    TagasisideHinne = table.Column<int>(type: "int", nullable: false),
                    TagasisideKommentaar = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LõpetamiseKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegistreerimineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Õppija", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Õppija_Registreerimine_RegistreerimineId",
                        column: x => x.RegistreerimineId,
                        principalTable: "Registreerimine",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Koolitus",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KoolituseNimi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KoolituseKirjeldus = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AlgusKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LõppKuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MahtTundides = table.Column<int>(type: "int", nullable: false),
                    Hind = table.Column<float>(type: "real", nullable: false),
                    KoolituseStaatus = table.Column<bool>(type: "bit", nullable: false),
                    KoolitajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ÕppijaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RegistreerimineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RuumId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Koolitus", x => x.id);
                    table.ForeignKey(
                        name: "FK_Koolitus_Koolitaja_KoolitajaId",
                        column: x => x.KoolitajaId,
                        principalTable: "Koolitaja",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Koolitus_Registreerimine_RegistreerimineId",
                        column: x => x.RegistreerimineId,
                        principalTable: "Registreerimine",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Koolitus_Ruum_RuumId",
                        column: x => x.RuumId,
                        principalTable: "Ruum",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KoolitusÕppija",
                columns: table => new
                {
                    Koolitusedid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ÕppijadId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KoolitusÕppija", x => new { x.Koolitusedid, x.ÕppijadId });
                    table.ForeignKey(
                        name: "FK_KoolitusÕppija_Koolitus_Koolitusedid",
                        column: x => x.Koolitusedid,
                        principalTable: "Koolitus",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KoolitusÕppija_Õppija_ÕppijadId",
                        column: x => x.ÕppijadId,
                        principalTable: "Õppija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Koolitus_KoolitajaId",
                table: "Koolitus",
                column: "KoolitajaId",
                unique: true,
                filter: "[KoolitajaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Koolitus_RegistreerimineId",
                table: "Koolitus",
                column: "RegistreerimineId",
                unique: true,
                filter: "[RegistreerimineId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Koolitus_RuumId",
                table: "Koolitus",
                column: "RuumId");

            migrationBuilder.CreateIndex(
                name: "IX_KoolitusÕppija_ÕppijadId",
                table: "KoolitusÕppija",
                column: "ÕppijadId");

            migrationBuilder.CreateIndex(
                name: "IX_Makse_RegistreerimineId",
                table: "Makse",
                column: "RegistreerimineId");

            migrationBuilder.CreateIndex(
                name: "IX_Õppija_RegistreerimineId",
                table: "Õppija",
                column: "RegistreerimineId",
                unique: true,
                filter: "[RegistreerimineId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KoolitusÕppija");

            migrationBuilder.DropTable(
                name: "Makse");

            migrationBuilder.DropTable(
                name: "Koolitus");

            migrationBuilder.DropTable(
                name: "Õppija");

            migrationBuilder.DropTable(
                name: "Koolitaja");

            migrationBuilder.DropTable(
                name: "Ruum");

            migrationBuilder.DropTable(
                name: "Registreerimine");
        }
    }
}
