using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ips.App.Persistencia.Migrations
{
    public partial class _8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Especialidades_EspecialidadId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "Eps");

            migrationBuilder.DropTable(
                name: "Especialidades");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropColumn(
                name: "Doctor_Eps",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "Horario",
                table: "Personas",
                newName: "RegistroMedico");

            migrationBuilder.RenameColumn(
                name: "EspecialidadId",
                table: "Personas",
                newName: "FechaHorarioId");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "Personas",
                newName: "Especialidad");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_EspecialidadId",
                table: "Personas",
                newName: "IX_Personas_FechaHorarioId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Personas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Eps",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Horarios_FechaHorarioId",
                table: "Personas",
                column: "FechaHorarioId",
                principalTable: "Horarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Horarios_FechaHorarioId",
                table: "Personas");

            migrationBuilder.RenameColumn(
                name: "RegistroMedico",
                table: "Personas",
                newName: "Horario");

            migrationBuilder.RenameColumn(
                name: "FechaHorarioId",
                table: "Personas",
                newName: "EspecialidadId");

            migrationBuilder.RenameColumn(
                name: "Especialidad",
                table: "Personas",
                newName: "Codigo");

            migrationBuilder.RenameIndex(
                name: "IX_Personas_FechaHorarioId",
                table: "Personas",
                newName: "IX_Personas_EspecialidadId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Personas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "Eps",
                table: "Personas",
                type: "bit",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.CreateTable(
                name: "Eps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEps = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelefonoEps = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especialidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEspecialidad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especialidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorreoId = table.Column<int>(type: "int", nullable: true),
                    Descuento = table.Column<bool>(type: "bit", nullable: false),
                    FechaHorarioId = table.Column<int>(type: "int", nullable: true),
                    NITId = table.Column<int>(type: "int", nullable: true),
                    NombreId = table.Column<int>(type: "int", nullable: true),
                    NombreSedeId = table.Column<int>(type: "int", nullable: true),
                    Precio = table.Column<double>(type: "float", nullable: false),
                    TelefonoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facturas_Citas_FechaHorarioId",
                        column: x => x.FechaHorarioId,
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
                name: "IX_Facturas_CorreoId",
                table: "Facturas",
                column: "CorreoId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_FechaHorarioId",
                table: "Facturas",
                column: "FechaHorarioId");

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
    }
}
