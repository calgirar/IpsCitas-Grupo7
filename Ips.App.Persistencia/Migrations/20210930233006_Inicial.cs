using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ips.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Horarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHorario = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Horarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sedes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreSede = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionSede = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiudadSede = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoSede = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sedes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIT = table.Column<int>(type: "int", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistroMedico = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaHorarioId = table.Column<int>(type: "int", nullable: true),
                    Consultorio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eps = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personas_Horarios_FechaHorarioId",
                        column: x => x.FechaHorarioId,
                        principalTable: "Horarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePacienteId = table.Column<int>(type: "int", nullable: true),
                    FechaHorarioId = table.Column<int>(type: "int", nullable: true),
                    NombreDoctorId = table.Column<int>(type: "int", nullable: true),
                    EspecialidadId = table.Column<int>(type: "int", nullable: true),
                    TipoCita = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombreSedeId = table.Column<int>(type: "int", nullable: true),
                    DireccionSedeId = table.Column<int>(type: "int", nullable: true),
                    CiudadSedeId = table.Column<int>(type: "int", nullable: true),
                    ConsultorioId = table.Column<int>(type: "int", nullable: true),
                    TelefonoSedeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citas_Horarios_FechaHorarioId",
                        column: x => x.FechaHorarioId,
                        principalTable: "Horarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Personas_ConsultorioId",
                        column: x => x.ConsultorioId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Personas_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Personas_NombreDoctorId",
                        column: x => x.NombreDoctorId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Personas_NombrePacienteId",
                        column: x => x.NombrePacienteId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Sedes_CiudadSedeId",
                        column: x => x.CiudadSedeId,
                        principalTable: "Sedes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Sedes_DireccionSedeId",
                        column: x => x.DireccionSedeId,
                        principalTable: "Sedes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Sedes_NombreSedeId",
                        column: x => x.NombreSedeId,
                        principalTable: "Sedes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citas_Sedes_TelefonoSedeId",
                        column: x => x.TelefonoSedeId,
                        principalTable: "Sedes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_CiudadSedeId",
                table: "Citas",
                column: "CiudadSedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_ConsultorioId",
                table: "Citas",
                column: "ConsultorioId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_DireccionSedeId",
                table: "Citas",
                column: "DireccionSedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_EspecialidadId",
                table: "Citas",
                column: "EspecialidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_FechaHorarioId",
                table: "Citas",
                column: "FechaHorarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_NombreDoctorId",
                table: "Citas",
                column: "NombreDoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_NombrePacienteId",
                table: "Citas",
                column: "NombrePacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_NombreSedeId",
                table: "Citas",
                column: "NombreSedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_TelefonoSedeId",
                table: "Citas",
                column: "TelefonoSedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_FechaHorarioId",
                table: "Personas",
                column: "FechaHorarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Sedes");

            migrationBuilder.DropTable(
                name: "Horarios");
        }
    }
}
