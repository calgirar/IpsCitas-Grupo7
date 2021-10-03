using Microsoft.EntityFrameworkCore.Migrations;

namespace Ips.App.Persistencia.Migrations
{
    public partial class _5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Especalidad",
                table: "Especialidades",
                newName: "NombreEspecialidad");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreEspecialidad",
                table: "Especialidades",
                newName: "Especalidad");
        }
    }
}
