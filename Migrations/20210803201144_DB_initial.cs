using Microsoft.EntityFrameworkCore.Migrations;

namespace Challenge.PreAceleracion.Migrations
{
    public partial class DB_initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "icons");

            migrationBuilder.RenameTable(
                name: "GeographicIcons",
                newName: "GeographicIcons",
                newSchema: "icons");

            migrationBuilder.RenameTable(
                name: "Continents",
                newName: "Continents",
                newSchema: "icons");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "City",
                newSchema: "icons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "GeographicIcons",
                schema: "icons",
                newName: "GeographicIcons");

            migrationBuilder.RenameTable(
                name: "Continents",
                schema: "icons",
                newName: "Continents");

            migrationBuilder.RenameTable(
                name: "City",
                schema: "icons",
                newName: "City");
        }
    }
}
