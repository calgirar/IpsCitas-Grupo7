using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ips.App.Persistencia.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Doctores_ConsultorioId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Doctores_EspecialidadId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Doctores_NombreDoctorId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Pacientes_NombrePacienteId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Citas_FechaId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Pacientes_CorreoId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Pacientes_NITId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Pacientes_NombreId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Pacientes_TelefonoId",
                table: "Facturas");

            migrationBuilder.DropTable(
                name: "Doctores");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.RenameColumn(
                name: "FechaId",
                table: "Facturas",
                newName: "FechaHorarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_FechaId",
                table: "Facturas",
                newName: "IX_Facturas_FechaHorarioId");

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

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Doctor_Eps",
                table: "Personas",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Edad",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Eps",
                table: "Personas",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EspecialidadId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Personas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Horario",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_EspecialidadId",
                table: "Personas",
                column: "EspecialidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Personas_ConsultorioId",
                table: "Citas",
                column: "ConsultorioId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Personas_EspecialidadId",
                table: "Citas",
                column: "EspecialidadId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Personas_NombreDoctorId",
                table: "Citas",
                column: "NombreDoctorId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Personas_NombrePacienteId",
                table: "Citas",
                column: "NombrePacienteId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Citas_FechaHorarioId",
                table: "Facturas",
                column: "FechaHorarioId",
                principalTable: "Citas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Personas_CorreoId",
                table: "Facturas",
                column: "CorreoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Personas_NITId",
                table: "Facturas",
                column: "NITId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Personas_NombreId",
                table: "Facturas",
                column: "NombreId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Personas_TelefonoId",
                table: "Facturas",
                column: "TelefonoId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Citas_Personas_ConsultorioId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Personas_EspecialidadId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Personas_NombreDoctorId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Personas_NombrePacienteId",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Citas_FechaHorarioId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Personas_CorreoId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Personas_NITId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Personas_NombreId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Facturas_Personas_TelefonoId",
                table: "Facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Especialidades_EspecialidadId",
                table: "Personas");

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
                name: "Discriminator",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Doctor_Eps",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Eps",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "EspecialidadId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Horario",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "FechaHorarioId",
                table: "Facturas",
                newName: "FechaId");

            migrationBuilder.RenameIndex(
                name: "IX_Facturas_FechaHorarioId",
                table: "Facturas",
                newName: "IX_Facturas_FechaId");

            migrationBuilder.CreateTable(
                name: "Doctores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Consultorio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eps = table.Column<bool>(type: "bit", nullable: false),
                    EspecialidadId = table.Column<int>(type: "int", nullable: true),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Horario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIT = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctores_Especialidades_EspecialidadId",
                        column: x => x.EspecialidadId,
                        principalTable: "Especialidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Eps = table.Column<bool>(type: "bit", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NIT = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctores_EspecialidadId",
                table: "Doctores",
                column: "EspecialidadId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Doctores_ConsultorioId",
                table: "Citas",
                column: "ConsultorioId",
                principalTable: "Doctores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Doctores_EspecialidadId",
                table: "Citas",
                column: "EspecialidadId",
                principalTable: "Doctores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Doctores_NombreDoctorId",
                table: "Citas",
                column: "NombreDoctorId",
                principalTable: "Doctores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Pacientes_NombrePacienteId",
                table: "Citas",
                column: "NombrePacienteId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Citas_FechaId",
                table: "Facturas",
                column: "FechaId",
                principalTable: "Citas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Pacientes_CorreoId",
                table: "Facturas",
                column: "CorreoId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Pacientes_NITId",
                table: "Facturas",
                column: "NITId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Pacientes_NombreId",
                table: "Facturas",
                column: "NombreId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Facturas_Pacientes_TelefonoId",
                table: "Facturas",
                column: "TelefonoId",
                principalTable: "Pacientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
