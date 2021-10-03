using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ips.App.Persistencia.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdPaciente",
                table: "Personas",
                newName: "EspecialidadId");

            migrationBuilder.AddColumn<string>(
                name: "Codigo",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Consultorio",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Doctor_Eps",
                table: "Personas",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Horario",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especalidad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaId = table.Column<int>(type: "int", nullable: true),
                    NombreId = table.Column<int>(type: "int", nullable: true),
                    NITId = table.Column<int>(type: "int", nullable: true),
                    TelefonoId = table.Column<int>(type: "int", nullable: true),
                    CorreoId = table.Column<int>(type: "int", nullable: true),
                    Descuento = table.Column<bool>(type: "bit", nullable: false),
                    NombreSedeId = table.Column<int>(type: "int", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facturas_Citas_FechaId",
                        column: x => x.FechaId,
                        principalTable: "Citas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Personas_CorreoId",
                        column: x => x.CorreoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Personas_NITId",
                        column: x => x.NITId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Personas_NombreId",
                        column: x => x.NombreId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Personas_TelefonoId",
                        column: x => x.TelefonoId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facturas_Sedes_NombreSedeId",
                        column: x => x.NombreSedeId,
                        principalTable: "Sedes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EspecialidadId",
                table: "Personas",
                column: "EspecialidadId");

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
                name: "IX_Facturas_CorreoId",
                table: "Facturas",
                column: "CorreoId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_FechaId",
                table: "Facturas",
                column: "FechaId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_NITId",
                table: "Facturas",
                column: "NITId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_NombreId",
                table: "Facturas",
                column: "NombreId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_NombreSedeId",
                table: "Facturas",
                column: "NombreSedeId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_TelefonoId",
                table: "Facturas",
                column: "TelefonoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Especialidades_EspecialidadId",
                table: "Personas",
                column: "EspecialidadId",
                principalTable: "Especialidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Especialidades_EspecialidadId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Citas");

            migrationBuilder.DropTable(
                name: "Horarios");

            migrationBuilder.DropTable(
                name: "Sedes");

            migrationBuilder.DropIndex(
                name: "IX_Personas_EspecialidadId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Codigo",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Consultorio",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Doctor_Eps",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Horario",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "EspecialidadId",
                table: "Personas",
                newName: "IdPaciente");
        }
    }
}
