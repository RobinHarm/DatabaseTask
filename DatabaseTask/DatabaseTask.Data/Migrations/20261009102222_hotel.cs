using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class hotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HospitalCure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArrivingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeavingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalCure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicineName = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ActiveIngredient = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Producer = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Telephone = table.Column<float>(type: "real", nullable: false),
                    HospitalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospital",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WorkerNr = table.Column<int>(type: "int", nullable: false),
                    Telephone = table.Column<float>(type: "real", nullable: false),
                    Speciality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctor_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PrescribedMedicine",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Dose = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    HowManyDay = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MedicineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescribedMedicine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrescribedMedicine_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PrescribedMedicine_Medicine_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicine",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Study",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    StudyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Study", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Study_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonalId = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Telephone = table.Column<float>(type: "real", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    StudyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HospitalCureId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PrescribedMedicineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_HospitalCure_HospitalCureId",
                        column: x => x.HospitalCureId,
                        principalTable: "HospitalCure",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_PrescribedMedicine_PrescribedMedicineId",
                        column: x => x.PrescribedMedicineId,
                        principalTable: "PrescribedMedicine",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Patient_Study_StudyId",
                        column: x => x.StudyId,
                        principalTable: "Study",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Visit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<float>(type: "real", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visit_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Visit_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ward",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<float>(type: "real", nullable: false),
                    AmountOfBed = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ward_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Department_HospitalId",
                table: "Department",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_DepartmentId",
                table: "Doctor",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_HospitalCureId",
                table: "Patient",
                column: "HospitalCureId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_PrescribedMedicineId",
                table: "Patient",
                column: "PrescribedMedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_StudyId",
                table: "Patient",
                column: "StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescribedMedicine_DoctorId",
                table: "PrescribedMedicine",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescribedMedicine_MedicineId",
                table: "PrescribedMedicine",
                column: "MedicineId",
                unique: true,
                filter: "[MedicineId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Study_DoctorId",
                table: "Study",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_DoctorId",
                table: "Visit",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_PatientId",
                table: "Visit",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Ward_PatientId",
                table: "Ward",
                column: "PatientId",
                unique: true,
                filter: "[PatientId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visit");

            migrationBuilder.DropTable(
                name: "Ward");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "HospitalCure");

            migrationBuilder.DropTable(
                name: "PrescribedMedicine");

            migrationBuilder.DropTable(
                name: "Study");

            migrationBuilder.DropTable(
                name: "Medicine");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Hospital");
        }
    }
}
