using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemasWeb01.Migrations
{
    public partial class Contacto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contactosdbcontex",
                columns: table => new
                {
                    ContactoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NombreContacto = table.Column<string>(type: "TEXT", nullable: false),
                    CorreoElectronico = table.Column<string>(type: "TEXT", nullable: true),
                    Telefono = table.Column<string>(type: "TEXT", nullable: true),
                    Mensaje = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactosdbcontex", x => x.ContactoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contactosdbcontex");
        }
    }
}
