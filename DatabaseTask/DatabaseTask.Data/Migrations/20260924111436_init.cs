using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PRISON",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Maximum_capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRISON", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "SHIFT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    start_time = table.Column<int>(type: "int", nullable: false),
                    finish_time = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SHIFT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VISIT",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DATE = table.Column<DateOnly>(type: "date", nullable: false),
                    start_time = table.Column<int>(type: "int", nullable: false),
                    finish_time = table.Column<int>(type: "int", nullable: false),
                    visiting_status = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VISIT", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BLOCK",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    security_level = table.Column<int>(type: "int", nullable: false),
                    PRISON_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BLOCK", x => x.id);
                    table.ForeignKey(
                        name: "FK_BLOCK_PRISON_PRISON_Id",
                        column: x => x.PRISON_Id,
                        principalTable: "PRISON",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BUILDING",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PRISON_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BUILDING", x => x.id);
                    table.ForeignKey(
                        name: "FK_BUILDING_PRISON_PRISON_Id",
                        column: x => x.PRISON_Id,
                        principalTable: "PRISON",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GUARDS",
                columns: table => new
                {
                    GUARDS_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prison_Id = table.Column<int>(type: "int", nullable: false),
                    First_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Worker_number = table.Column<int>(type: "int", nullable: false),
                    job = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GUARDS", x => x.GUARDS_Id);
                    table.ForeignKey(
                        name: "FK_GUARDS_PRISON_Prison_Id",
                        column: x => x.Prison_Id,
                        principalTable: "PRISON",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VISITORS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    personal_number = table.Column<int>(type: "int", nullable: false),
                    Telephone_number = table.Column<int>(type: "int", nullable: false),
                    relation_to_the_prisoner = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    VISIT_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VISITORS", x => x.id);
                    table.ForeignKey(
                        name: "FK_VISITORS_VISIT_VISIT_Id",
                        column: x => x.VISIT_Id,
                        principalTable: "VISIT",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CHAMBER",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<int>(type: "int", nullable: false),
                    floor = table.Column<int>(type: "int", nullable: false),
                    maximum_capacity = table.Column<int>(type: "int", nullable: false),
                    BLOCKid = table.Column<int>(type: "int", nullable: true),
                    CHAMBERid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHAMBER", x => x.id);
                    table.ForeignKey(
                        name: "FK_CHAMBER_BLOCK_BLOCKid",
                        column: x => x.BLOCKid,
                        principalTable: "BLOCK",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_CHAMBER_CHAMBER_CHAMBERid",
                        column: x => x.CHAMBERid,
                        principalTable: "CHAMBER",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "GUARDSSHIFT",
                columns: table => new
                {
                    GUARDS_Id = table.Column<int>(type: "int", nullable: false),
                    ShiftsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GUARDSSHIFT", x => new { x.GUARDS_Id, x.ShiftsId });
                    table.ForeignKey(
                        name: "FK_GUARDSSHIFT_GUARDS_GUARDS_Id",
                        column: x => x.GUARDS_Id,
                        principalTable: "GUARDS",
                        principalColumn: "GUARDS_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GUARDSSHIFT_SHIFT_ShiftsId",
                        column: x => x.ShiftsId,
                        principalTable: "SHIFT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PRISONERS",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    personal_number = table.Column<int>(type: "int", nullable: false),
                    arrival_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prisoner_status = table.Column<bool>(type: "bit", nullable: false),
                    VISIT_Id = table.Column<int>(type: "int", nullable: false),
                    CHAMBER_Id = table.Column<int>(type: "int", nullable: false),
                    VISITORSid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRISONERS", x => x.id);
                    table.ForeignKey(
                        name: "FK_PRISONERS_CHAMBER_CHAMBER_Id",
                        column: x => x.CHAMBER_Id,
                        principalTable: "CHAMBER",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PRISONERS_VISITORS_VISITORSid",
                        column: x => x.VISITORSid,
                        principalTable: "VISITORS",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_PRISONERS_VISIT_VISIT_Id",
                        column: x => x.VISIT_Id,
                        principalTable: "VISIT",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CRIME",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Difficulty_level = table.Column<int>(type: "int", nullable: false),
                    PRISONER_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CRIME", x => x.id);
                    table.ForeignKey(
                        name: "FK_CRIME_PRISONERS_PRISONER_Id",
                        column: x => x.PRISONER_Id,
                        principalTable: "PRISONERS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PUNISHMENT",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    punishment_Type = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PRISONERS_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PUNISHMENT", x => x.id);
                    table.ForeignKey(
                        name: "FK_PUNISHMENT_PRISONERS_PRISONERS_Id",
                        column: x => x.PRISONERS_Id,
                        principalTable: "PRISONERS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BLOCK_PRISON_Id",
                table: "BLOCK",
                column: "PRISON_Id");

            migrationBuilder.CreateIndex(
                name: "IX_BUILDING_PRISON_Id",
                table: "BUILDING",
                column: "PRISON_Id");

            migrationBuilder.CreateIndex(
                name: "IX_CHAMBER_BLOCKid",
                table: "CHAMBER",
                column: "BLOCKid");

            migrationBuilder.CreateIndex(
                name: "IX_CHAMBER_CHAMBERid",
                table: "CHAMBER",
                column: "CHAMBERid");

            migrationBuilder.CreateIndex(
                name: "IX_CRIME_PRISONER_Id",
                table: "CRIME",
                column: "PRISONER_Id");

            migrationBuilder.CreateIndex(
                name: "IX_GUARDS_Prison_Id",
                table: "GUARDS",
                column: "Prison_Id");

            migrationBuilder.CreateIndex(
                name: "IX_GUARDSSHIFT_ShiftsId",
                table: "GUARDSSHIFT",
                column: "ShiftsId");

            migrationBuilder.CreateIndex(
                name: "IX_PRISONERS_CHAMBER_Id",
                table: "PRISONERS",
                column: "CHAMBER_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PRISONERS_VISIT_Id",
                table: "PRISONERS",
                column: "VISIT_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PRISONERS_VISITORSid",
                table: "PRISONERS",
                column: "VISITORSid");

            migrationBuilder.CreateIndex(
                name: "IX_PUNISHMENT_PRISONERS_Id",
                table: "PUNISHMENT",
                column: "PRISONERS_Id");

            migrationBuilder.CreateIndex(
                name: "IX_VISITORS_VISIT_Id",
                table: "VISITORS",
                column: "VISIT_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BUILDING");

            migrationBuilder.DropTable(
                name: "CRIME");

            migrationBuilder.DropTable(
                name: "GUARDSSHIFT");

            migrationBuilder.DropTable(
                name: "PUNISHMENT");

            migrationBuilder.DropTable(
                name: "GUARDS");

            migrationBuilder.DropTable(
                name: "SHIFT");

            migrationBuilder.DropTable(
                name: "PRISONERS");

            migrationBuilder.DropTable(
                name: "CHAMBER");

            migrationBuilder.DropTable(
                name: "VISITORS");

            migrationBuilder.DropTable(
                name: "BLOCK");

            migrationBuilder.DropTable(
                name: "VISIT");

            migrationBuilder.DropTable(
                name: "PRISON");
        }
    }
}
